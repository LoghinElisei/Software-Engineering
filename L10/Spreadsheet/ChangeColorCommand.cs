/**************************************************************************
 *                                                                        *
 *  File:        ChangeColorCommand.cs                                    *
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
    internal class ChangeColorCommand : Command
    {
        private ExtendedTextBox _cell;
        private Color _color;
        private Color _previousColor;

        public ChangeColorCommand(ExtendedTextBox cell, Color color, string description)
        {
            _cell = cell;
            _color = color;
            Description = description;
        }

        public override bool MakesChanges()
        {
            return _cell.ForeColor != _color;
        }

        public override void Execute()
        {
            _previousColor = _cell.ForeColor;
            _cell.ForeColor = _color;
        }

        public override void Undo()
        {
            _cell.ForeColor = _previousColor;
        }

        public override void Redo()
        {
            _cell.ForeColor = _color;
        }
    }
}