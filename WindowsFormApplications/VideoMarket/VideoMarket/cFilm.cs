using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoMarket
{
    public class cFilm
    {
        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _yonetmen;
        private string _oyuncular;
        private string _ozet;
        private int _miktar;
        private int _fiyat;

        #region Properties
        public int FilmNo
        {
            get
            {
                return _filmNo;
            }

            set
            {
                _filmNo = value;
            }
        }

        public string FilmAd
        {
            get
            {
                return _filmAd;
            }

            set
            {
                _filmAd = value;
            }
        }

        public int FilmTurNo
        {
            get
            {
                return _filmTurNo;
            }

            set
            {
                _filmTurNo = value;
            }
        }

        public string Yonetmen
        {
            get
            {
                return _yonetmen;
            }

            set
            {
                _yonetmen = value;
            }
        }

        public string Oyuncular
        {
            get
            {
                return _oyuncular;
            }

            set
            {
                _oyuncular = value;
            }
        }

        public string Ozet
        {
            get
            {
                return _ozet;
            }

            set
            {
                _ozet = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _miktar;
            }

            set
            {
                _miktar = value;
            }
        }

        public int Fiyat
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

        SqlConnection conn = new SqlConnection(cGenel.connStr);


    }
}
