using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    public class History
    {
        public History(int historyId, string assassinName, string missionName)
        {
            this.historyId = historyId;
            this.assassinName = assassinName;
            this.missionName = missionName;
        }

        public int historyId {  get; set; }
        public string assassinName { get; set; }
        public string missionName { get; set; }
    }
}
