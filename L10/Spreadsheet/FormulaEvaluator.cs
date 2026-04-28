using System;
using System.Collections.Generic;
using System.Text;

namespace Spreadsheet
{
    public class FormulaEvaluator
    {
        private TextBoxGrid _grid;

        public FormulaEvaluator(TextBoxGrid grid)
        {
            _grid = grid;
        }

        public string Evaluate(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Trim().Length == 0) return text;

            string[] parts = text.Split(new[] { ' ', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3)
            {
                string op = parts[0].ToUpper();
                if (op == "ADD" || op == "SUB" || op == "MUL" || op == "DIV")
                {
                    try
                    {
                        double val1 = GetCellValue(parts[1]);
                        double val2 = GetCellValue(parts[2]);
                        double result = 0;

                        switch (op)
                        {
                            case "ADD": result = val1 + val2; break;
                            case "SUB": result = val1 - val2; break;
                            case "MUL": result = val1 * val2; break;
                            case "DIV":
                                result = (val2 != 0) ? val1 / val2 : double.NaN; 
                                break;
                        }
                        return result.ToString();
                    }
                    catch
                    {
                        return "ERR";
                    }
                }
            }
            return text;
        }

        private double GetCellValue(string coord)
        {
            try
            {
                coord = coord.ToUpper().Trim();
                int x = coord[0] - 'A';
                int y = int.Parse(coord.Substring(1)) - 1;

                int index = y * TextBoxGrid.Size + x;
                ExtendedTextBox cell = _grid.GetCell(index);

                double val = 0;
                double.TryParse(cell.Text, out val);
                return val;
            }
            catch
            {
                return 0;
            }
        }
    }
}
