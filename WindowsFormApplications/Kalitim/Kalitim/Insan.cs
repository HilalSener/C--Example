using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    sealed class Insan : Hayvan
    {
        string _düsünme;

        public string Düsünme
        {
            get
            {
                return _düsünme;
            }

            set
            {
                _düsünme = value;
            }
        }

        public override string YeniDogan()
        {
            return "bebek";
        }
    }
}
