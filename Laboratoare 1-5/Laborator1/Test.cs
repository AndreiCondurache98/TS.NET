using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Test
    {
        static void Main(string[] args)
        {
            InfoDisplay infodisplay = new InfoDisplay();
            Info info = new Info();
            // inregistrare metoda callback pentru event
            Info.InfoDelegate del = new Info.InfoDelegate(infodisplay.InfoChanged);
            info.InfoChanged += del;

            // schimbare stare in Info
            info.SetInfo = "changed";
            // unregister
            info.InfoChanged -= del;
        }
    }
}
