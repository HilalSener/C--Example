using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    abstract class Canli
    {
        string _solunum;
        string _beslenme;
        string _bosaltim;
        string _ureme;

        #region Properties
        public string Solunum
        {
            get
            {
                return _solunum;
            }

            set
            {
                _solunum = value;
            }
        }

        public string Beslenme
        {
            get
            {
                return _beslenme;
            }

            set
            {
                _beslenme = value;
            }
        }

        public string Bosaltim
        {
            get
            {
                return _bosaltim;
            }

            set
            {
                _bosaltim = value;
            }
        }

        public string Ureme
        {
            get
            {
                return _ureme;
            }

            set
            {
                _ureme = value;
            }
        }
        #endregion

        public abstract void Beslen();
        //Abstract metotlar, abstract class lar içinde tanımlanabilir. Miras alan sınıflar tarafından mutlaka override edilip kullanılmalıdır. Abstract metotlar otomatik olarak virtual kabul edilirler.
        public abstract void SuIc();
    }
}
