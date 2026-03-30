using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class Menus
    {
       
        public enum UserChoice { AdminMenu, UserMenu, PreviousMenu, Route, AddCity, RemoveCity, Exit, List, Undefined };
        public enum MenuState { Main, Administrator, User };

        public struct MenuOption
        {
            // structura pentru construirea dinamica a unui meniu
            // reprezinta o optiune intr-un meniu

            public readonly string Number;
            public readonly string Text;
            public readonly UserChoice Choice;

            public MenuOption(string number, string text, UserChoice choice)
            {
                Number = number;
                Text = text;
                Choice = choice;
            }
        }

        // metodele de mai jos trebuie plasate in clasele potrivite
        public static void MainMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati rolul";
            options = new List<MenuOption>(3);
            options.Add(new MenuOption("1", "Utilizator", UserChoice.UserMenu));
            options.Add(new MenuOption("2", "Administrator", UserChoice.AdminMenu));
            options.Add(new MenuOption("3", "Iesire", UserChoice.Exit));
        }

        public static void AdminMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati actiunea dorita";
            options = new List<MenuOption> {
                new MenuOption("1", "Afisarea tuturor oraselor", UserChoice.List),
                new MenuOption("2", "Introducerea unui nou oras", UserChoice.AddCity),
                new MenuOption("3", "Stergerea unui oras", UserChoice.RemoveCity),
                new MenuOption("4", "Intoarcere la meniul principal", UserChoice.PreviousMenu),
                new MenuOption("5", "Iesire", UserChoice.Exit)
            };
        }

        public static void UserMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati actiunea dorita";
            options = new List<MenuOption> {
                new MenuOption("1", "Informatii despre o ruta", UserChoice.Route),
                new MenuOption("2", "Afisarea tuturor oraselor", UserChoice.List),
                new MenuOption("3", "Intoarcere la meniul principal", UserChoice.PreviousMenu),
                new MenuOption("4", "Iesire", UserChoice.Exit)
            };
        }

    }
}
