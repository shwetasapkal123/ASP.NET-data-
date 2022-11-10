using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class Rice
    {
        public List<TypeOfRice> typeOfRice;
        public List<TypeOfPulses> typeOfPulses;
        public List<TypeOfWheat> typeOfWheat;
    }
    public class TypeOfRice
    {
        //propeerties of rice
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
    public class TypeOfPulses
    {
        //propeerties of rice
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
    public class TypeOfWheat
    {
        //propeerties of rice
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
}
