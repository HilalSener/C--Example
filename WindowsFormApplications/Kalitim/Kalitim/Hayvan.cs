using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Hayvan : Canli
    {
        string _hareket;

        public string Hareket
        {
            get
            {
                return _hareket;
            }

            set
            {
                _hareket = value;
            }
        }
    }
}
