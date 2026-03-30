using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.Menus;

namespace View
{
    public class ConsoleView: TransportInfo.IView
    {
        private IPresenter _presenter;
        private IModel _model;
        private List<MenuOption> _menuOptions;

        public ConsoleView(IModel model)
        {
            _model = model;
        }
        public void Start()
        {
            Menus.UserChoice choice = Menus.UserChoice.Undefined;
            Menus.MenuState menuState = Menus.MenuState.Main;

            while (choice != Menus.UserChoice.Exit)
            {
                choice = GetMenuOption(menuState);

                switch (choice)
                {
                    case UserChoice.Route:
                        string cn1, cn2;
                        GetTwoCities(out cn1, out cn2);
                        _presenter.ComputeRoute(cn1, cn2);
                        break;

                    case UserChoice.RemoveCity:
                        Display("Introduceti numele orasului de sters:", "default");
                        string cityToDelete = GetCity();
                        _presenter.RemoveCity(cityToDelete);
                        break;

                    case UserChoice.AddCity:
                        City c = InputCity();
                        _presenter.AddCity(c);
                        break;

                    case UserChoice.List:
                        ListAll();
                        break;

                    case UserChoice.Exit:
                        _presenter.Exit();
                        break;

                    case UserChoice.AdminMenu:
                        menuState = MenuState.Administrator;
                        break;

                    case UserChoice.UserMenu:
                        menuState = MenuState.User;
                        break;

                    case UserChoice.PreviousMenu:
                        menuState = MenuState.Main;
                        break;
                }
               
                
            }
        }

        public void Display(string text, string color)
        {
            ConsoleColor c = ConsoleColor.DarkGray;

            switch (color)
            {
                case "default": c = ConsoleColor.White; break;
                case "red": c = ConsoleColor.Red; break;
                case "green": c = ConsoleColor.Green; break;
                case "blue": c = ConsoleColor.Blue; break;
                case "yellow": c = ConsoleColor.Yellow; break;
                case "magenta": c = ConsoleColor.Magenta; break;
            }

            Console.ForegroundColor = c;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private Menus.UserChoice GetMenuOption(Menus.MenuState menuType)
        {
            string action = "";

            switch (menuType)
            {
                case Menus.MenuState.Main:
                    Menus.MainMenu(out _menuOptions, out action);
                    break;
                case Menus.MenuState.Administrator:
                    Menus.AdminMenu(out _menuOptions, out action);
                    break;
                case Menus.MenuState.User:
                    Menus.UserMenu(out _menuOptions, out action);
                    break;
            }
            Menus.UserChoice choice = Menus.UserChoice.Undefined;
            while (choice == Menus.UserChoice.Undefined)
            {
                Display(action + Environment.NewLine, "yellow");

                for (int i = 0; i < _menuOptions.Count; i++)
                    Display(_menuOptions[i].Number + ". " + _menuOptions[i].Text, "default");

                Console.Write(Environment.NewLine + "Optiunea dumneavoastra: ");
                string userChoiceNumber = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < _menuOptions.Count; i++)
                {
                    if (userChoiceNumber == _menuOptions[i].Number)
                    {
                        choice = _menuOptions[i].Choice;
                        break;
                    }
                }
            }

            return choice;
        }
        //plus metodele de pe diagrama de clase care nu sunt trecute aici

        private void GetTwoCities(out string cityName1, out string cityName2)
        {
            Console.Write("Orasul de plecare: ");
            cityName1 = Console.ReadLine();
            Console.Write("Orasul de sosire: ");
            cityName2 = Console.ReadLine();
        }
        private string GetCity() => Console.ReadLine();
        private City InputCity()
        {
            try
            {
                Console.Write("Nume oras: ");
                string name = Console.ReadLine();
                Console.Write("Latitudine: ");
                double lat = Convert.ToDouble(Console.ReadLine());
                Console.Write("Longitudine: ");
                double lon = Convert.ToDouble(Console.ReadLine());
                return new City(name, lat, lon);
            }
            catch
            {
                Display("Date invalide! Folositi virgula sau punctul conform setarilor sistemului.", "red");
                return new City("Invalide", 0, 0);
            }
        }

        private void ListAll()
        {
            string list = _model.ListAll();
            if (string.IsNullOrEmpty(list))
                Display("Baza de date este goala.", "yellow");
            else
            {
                Display("Orase:", "red");
                Display(list, "green");
            }
        }

        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
        }
    }
}
