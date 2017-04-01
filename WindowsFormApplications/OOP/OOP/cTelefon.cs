using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class cTelefon   //class cTelefon bu projeden her yerde görülebilir.
    {
        #region Members
        private string _marka;
        private string _model;
        private string _islemci;
        private string _hafiza;
        private string _kamera;
        private string _ekran;
        private double _fiyat; 
        #endregion

        #region Properties
        public string Marka
        {
            get
            {
                return _marka;
            }

            set
            {
                _marka = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Islemci
        {
            get
            {
                return _islemci;
            }

            set
            {
                _islemci = value;
            }
        }

        public string Hafiza
        {
            get
            {
                return _hafiza;
            }

            set
            {
                _hafiza = value;
            }
        }

        public string Kamera
        {
            get
            {
                return _kamera;
            }

            set
            {
                _kamera = value;
            }
        }

        public string Ekran
        {
            get
            {
                return _ekran;
            }

            set
            {
                _ekran = value;
            }
        }

        public double Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }
        #endregion


    }
}
