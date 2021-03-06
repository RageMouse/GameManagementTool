﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class RaceCollection
    {
        //Properties
        private List<Race> Races { get; set; }

        //Constructors
        public RaceCollection(List<Race> races)
        {
            Races = GetRaces();
        }

        //Methods
        private List<Race> GetRaces()
        {
            throw new NotImplementedException();
        }

        public void AddRace(Race races)
        {
            Races.Add(races);
        }

        public void RemoveRace(Race race)
        {
            Races.Remove(race);
        }
    }
}
