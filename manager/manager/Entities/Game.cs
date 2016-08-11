using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manager.Constants;

namespace manager.Entities
{
    class Game : Entity
    {
        DateTime _matchdate;
        string _location;
        Team _receiving;
        Team _guest;
        Enumerations.Weather _weather;
        public Game(uID ID, DateTime matchdate, string location, Team receiving, Team guest, Enumerations.Weather weather) : base(ID)
        {
            _matchdate = matchdate;
            _location = location;
            _receiving = receiving;
            _guest = guest;
            _weather = weather;
        }
    }

    class Stadium : Entity
    {
        string _name;
        string _city;
        Team _belongsTo;

        public Stadium(uID ID, string name, string city, Team belongsTo) : base(ID)
        {
            _name = name;
            _city = city;
            _belongsTo = belongsTo;

        }
    }
}
