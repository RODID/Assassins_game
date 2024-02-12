﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assassins_game
{
    internal class Missions
    {
        public string Mission_name { get; set; }
        public string Mission_title { get; set; }
        public string Mission_description { get; set; }
        public TimeSpan Mission_duration { get; set; }


        public Missions (string mission_name, string mission_title, string mission_description, TimeSpan mission_duration)
        {
            Mission_name = mission_name;
            Mission_title = mission_title;
            Mission_description = mission_description;
            Mission_duration = mission_duration;
        }

        public Missions CreateMission(string name, string title, string description, TimeSpan Mission_duration)
        {
            return new Missions (name, title, description, Mission_duration);
        } 

        Missions mission1 = new Missions("Learning Poison", "the ambasador", "send your henchmen to kill the ambasador", '00:00:05:00' );

    }


}