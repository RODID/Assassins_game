using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    public class Missions
    {
        public Missions(int mission_id, string mission_name, string mission_description, string mission_Location, TimeSpan mission_Time, bool completed)
        {
            Mission_id = mission_id;
            Mission_name = mission_name;
            Mission_description = mission_description;
            Mission_Location = mission_Location;
            Mission_Time = mission_Time;
            Completed = completed;
        }

        public int Mission_id { get; set; }
        public string Mission_name { get; set; }
        public string Mission_description { get; set; }
        public string Mission_Location { get; set; }
        public TimeSpan Mission_Time { get; set; }
        public bool Completed { get; set; } 


    }

}
