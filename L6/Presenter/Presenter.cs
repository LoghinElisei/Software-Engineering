using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransportInfo;

namespace Presenter
{
    public class Presenter: IPresenter
    {
        public Presenter(in IView view, in IModel model) { }
        private IModel _model;
        private IView _view;

        public Presenter(IView view, IModel model)
        {
          
            _view = view;
            _model = model;
        }
        public void Init()//trebuie apelata pentru a initializa prezentarea
        {
            if (!_model.DataExists())
            {
                _view.Display("Fisierul cu orase nu exista." + Environment.NewLine, "red");
            }
            else
            {
                _model.InitializeData();
                _view.Display("Fisier incarcat: " + _model.CityCount + " orase." + Environment.NewLine, "magenta");
            }
        }

        public void Exit()
        {
            if (_model.SaveData())
                _view.Display("Fisierul a fost salvat." + Environment.NewLine, "magenta");
            _view.Display("La revedere.", "default");
            // Application.DoEvents(); // numai pentru Windows Forms
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
        // plus metodele de pe diagrama de clase

        public void AddCity(City c)
        {
            bool isNew = _model.Add(c);
            if (isNew)
                _view.Display($"Orasul {c.Name} a fost adaugat cu succes.", "green");
            else
                _view.Display($"Orasul {c.Name} exista deja si a fost actualizat.", "yellow");
        }

        public bool CityExists(string name)
        {
            return _model.Exists(name);
        }

        public void ComputeRoute(string city1, string city2)
        {
            if (!_model.Exists(city1))
            {
                _view.Display($"Eroare: Orasul '{city1}' nu a fost gasit.", "red");
                return;
            }
            if (!_model.Exists(city2))
            {
                _view.Display($"Eroare: Orasul '{city2}' nu a fost gasit.", "red");
                return;
            }

            City c1 = _model.Search(city1);
            City c2 = _model.Search(city2);

            double distance = Calculator.Distance(c1, c2);
            double cost = Calculator.Cost(distance);

          
            _view.Display($"Distanta {c1.Name} - {c2.Name}: {distance:F2} km", "green");
            _view.Display($"Cost estimat: {cost:F2} lei", "green");
        }

   

        public City GetCity(string name)
        { return _model.Search(name); }
        
         public void RemoveCity(string name)
        {
            if (_model.Delete(name))
                _view.Display($"Orasul {name} a fost sters.", "green");
            else
                _view.Display($"Eroare: Orasul {name} nu a fost gasit.", "red");
        }
    }
}
