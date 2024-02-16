using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    internal class Missions
    {
        public int Mission_id { get; set; }
        public string Mission_name { get; set; }
        public string Mission_title { get; set; }
        public string Mission_description { get; set; }
        public TimeSpan Mission_duration { get; set; }

        public Missions(int mission_id, string mission_name, string mission_title, string mission_description, TimeSpan mission_duration)
        {
            Mission_id = mission_id;
            Mission_name = mission_name;
            Mission_title = mission_title;
            Mission_description = mission_description;
            Mission_duration = mission_duration;
        }
       

    }


}
