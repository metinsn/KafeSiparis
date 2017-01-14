using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparis
{
    public class Masa
    {
        public Masa()
        {
            siparisler = new List<Siparis>();
        }

        public int masaNo { get; set; }
        public List<Siparis> siparisler { get; set; }
    }
}
