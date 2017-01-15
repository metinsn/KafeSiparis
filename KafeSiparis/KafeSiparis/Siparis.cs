using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparis
{
    public class Siparis
    {
        public string isim { get; set; }
        public int adet { get; set; }

        public int tutar
        {
            get
            {
                if (isim == "Kuru Fasulye ")
                    return adet  * 5;
                else if (isim == "Tavuklu Pilav")
                    return adet  * 6;
                else if (isim == "Pizza        ")
                    return adet * 10;
                else if (isim == "Hamburger    ")
                    return adet * 8;
                else if (isim == "Tost         ")
                    return adet * 3;
                else if (isim == "Cola         ")
                    return adet * 3;
                else if (isim == "Fanta        ")
                    return adet * 3;
                else if (isim == "Çay          ")
                    return adet * 2;
                else if (isim == "Su           ")
                    return adet * 1;
                else if (isim == "Kahve        ")
                    return adet * 5;
                else
                    return 0;
            }
        }

        
        public override string ToString()
        {
            return isim + " \t\t  "+ adet+ " \t  "+ tutar;
        }


    }
}
