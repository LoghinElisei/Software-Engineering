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
        // alte campuri

        public ChangeColorCommand(ExtendedTextBox cell, Color color, string description)
        {
            // se seteaza valorile campurilor
            // pentru descriere, se foloseste proprietatea Description definita in clasa de baza Command
            throw new Exception("Aceasta metoda trebuie completata");
        }

        public override bool MakesChanges()
        {
            // returneaza true daca se modifica ceva in celula de tip ExtendedTextBox
            // returneaza false daca nu se modifica nimic

            throw new Exception("Aceasta metoda trebuie completata");
        }

        public override void Execute()
        {
            throw new Exception("Aceasta metoda trebuie completata");
        }

        public override void Undo()
        {
            throw new Exception("Aceasta metoda trebuie completata");
        }

        public override void Redo()
        {
            throw new Exception("Aceasta metoda trebuie completata");
        }
    }
}