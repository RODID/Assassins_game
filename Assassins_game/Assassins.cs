using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    public class Assassins
    {
        public Assassins(int assassinId, string assassinName, string assassinRank)
        {
            this.assassinId = assassinId;
            this.assassinName = assassinName;
            this.assassinRank = assassinRank;
        }

        public int assassinId {  get; set; }
        public string assassinName { get; set; }
        public string assassinRank { get; set; }


    }
}
