using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Bitki : Canli
    {
        string _fotosentez;

        public string Fotosentez
        {
            get
            {
                return _fotosentez;
            }

            set
            {
                _fotosentez = value;
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
    }
}
