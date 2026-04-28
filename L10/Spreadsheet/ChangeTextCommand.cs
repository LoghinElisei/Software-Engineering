/**************************************************************************
 *                                                                        *
 *  File:        ChangeTextCommand.cs                                     *
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

namespace Spreadsheet
{
    public class ChangeTextCommand : Command
    {
        private ExtendedTextBox _cell;
        private string _newText;
        private string _previousText;

        public ChangeTextCommand(ExtendedTextBox cell, string description)
        {
            _cell = cell;
            Description = description;
            _newText = cell.Text;
            _previousText = cell.PreviousText;
        }

        public override bool MakesChanges()
        {
            return _newText != _previousText;
        }

        public override void Execute()
        {
            _cell.PreviousText = _newText;
        }

        public override void Undo()
        {
            _cell.Text = _previousText;
            _cell.PreviousText = _previousText;
        }

        public override void Redo()
        {
            _cell.Text = _newText;
            _cell.PreviousText = _newText;
        }
    }
}