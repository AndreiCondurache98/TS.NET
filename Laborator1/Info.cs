using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    public class Info
    {
        // delegate pentru eveniment
        public delegate void InfoDelegate(object obj);
        // event ce foloseste delegate InfoDelegate
        public event InfoDelegate InfoChanged;
        // data membru
        object _obiect;
        public object SetInfo
        {
            set
            {
                _obiect = value;
                // genereaza eveniment
                InfoChanged(_obiect);
            }
        }
    }
}
