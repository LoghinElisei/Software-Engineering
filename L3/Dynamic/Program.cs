using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // se încearcă încărcarea DLL-ului
            
            Assembly a = Assembly.LoadFrom(@"C:\\Users\\loghi\\Desktop\\GIT PROJECT\\Software Engineering\\L3\\Dynamic\\bin\\Debug\\Prim.dll"); // se va înlocui cu calea construită mai sus
                                                    // se identifică tipul (clasa) care trebuie instanțiată
                                                    // dacă în clasa din DLL există un namespace,
                                                    // se folosește numele complet al clasei din assembly, incluzând namespace-ul
            Type t = a.GetType("Prim.Prim"); // namespace.clasa
                                                     // se identifică metoda care ne interesează
            MethodInfo mi = t.GetMethod("isPrim"); // metoda
                                                   // se creează o instanță a clasei dorite
                                                   // aici se apelează constructorul implicit
           
            object[] argsx = new object[1]; // atenție că args apare ca argument în main, redenumiți
            argsx[0] = 274;
            // apelul efectiv al metodei și memorarea rezultatului
            bool result = (bool)mi.Invoke(null, argsx);

            Console.WriteLine(result);
          
            while(true)
            {

            }
        }
    }
}
