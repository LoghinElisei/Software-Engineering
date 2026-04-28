/**************************************************************************
 *                                                                        *
 *  File:        ChangeFormatCommand.cs                                   *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Spreadsheet application with Command pattern.            *
 *               Concrete command class (Software Engineering lab 10)     *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Drawing;

namespace Spreadsheet
{
    public class ChangeFormatCommand : Command
    {
        private ExtendedTextBox _cell;
        private FontStyle _newStyle;
        private FontStyle _previousStyle;

        public ChangeFormatCommand(ExtendedTextBox cell, FontStyle format, string description)
        {
            _cell = cell;
            _newStyle = format;
            Description = description;
        }

        public override bool MakesChanges()
        {
            return _cell.Font.Style != _newStyle;
        }

        public override void Execute()
        {
            _previousStyle = _cell.Font.Style;
            _cell.Font = new Font(_cell.Font, _newStyle);
        }

        public override void Undo()
        {
            _cell.Font = new Font(_cell.Font, _previousStyle);
        }

        public override void Redo()
        {
            _cell.Font = new Font(_cell.Font, _newStyle);
        }
    }
}