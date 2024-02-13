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
       

        public Missions CreateMission(int mission_id, string name, string title, string description, TimeSpan Mission_duration)
        {
            return new Missions (name, title, description, Mission_duration);
        }

        Missions mission1 = new Missions("Learning Poison", "the ambasador", "send your henchmen to kill the ambasador", TimeSpan.Parse("00:05:00:00"));
        Missions mission2 = new Missions("Clear The Path", "The Ambasador", "Kill the 'Fox' and retrive his weapon of doom", TimeSpan.Parse("00:10:00:00"));
        Missions mission3 = new Missions("Documents", "Castle Muzii", "retrive a sertain document hhidden in a tomb", TimeSpan.Parse("00:15:05:00"));
        Missions mission4 = new Missions("Fortify", "Castle Takeover", "Kill all the underground guards", TimeSpan.Parse("00:20:00:00"));
        Missions mission5 = new Missions("Eurika", "Machiavelli's documents", "Send Blue print to Machiavelli so that he can giv the information to davinchi about a sertain war machine", TimeSpan.Parse("00:50:00:00"));



    }


}
