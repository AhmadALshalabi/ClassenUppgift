using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassenUppgift
{
    class Backpack
    {
        public string BackpackbBrand { get; set; }
        public string[] Snacks { get; set; }

        public Backpack(string backpackBrand = "Fjallraven")
        {
            this.BackpackbBrand = backpackBrand;
        }
        public Backpack()
        {
            this.Snacks = new string[] { "Sandwich", "Cake", "Chips" };
            
        }
    }
}
