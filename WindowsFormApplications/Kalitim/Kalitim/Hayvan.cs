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

        public override void Beslen()
        {
            throw new NotImplementedException();
        }

        public override void SuIc()
        {
            throw new NotImplementedException();
        }

        public virtual string YeniDogan()  //Virtual metotlar miras alan sonoflar tarafından değiştirilerek(override) kullanılabilirler.
        {
            return "civciv";
        }
    }
}
