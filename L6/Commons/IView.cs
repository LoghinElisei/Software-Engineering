using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public interface IView
    {
        void Display(string text, string color);

        void SetPresenter(IPresenter presenter);
    }
}
