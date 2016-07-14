using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager
{
    class Entity
    {
        uID _ID;
        public Entity(uID ID)
        {
            _ID = ID;
        }
    }
    class Person : Entity
    {
        private string _name;
        private DateTime _birth;
        public Person(uID ID, string name, DateTime birth) : base(ID)
        {
            _name = name;
            _birth = birth;

        }
    }

    class Team : Entity
    {

        private List<Person> _Members;
        private string _name;
        private DateTime _founded;
        private Person _manager;
        private Person _trainer;

        public Team(uID ID, string name, DateTime founded, Person manager, Person trainer) : base(ID)
        {
            _name = name;
            _founded = founded;
            _manager = manager;
            _trainer = trainer;
        }

    }


    class Game : Entity
    {
        DateTime _matchdate;
        string _location;
        Team _receiving;
        Team _guest;
        public Game(uID ID, DateTime matchdate, string location, Team receiving, Team guest) : base(ID)
        {
            _matchdate = matchdate;
            _location = location;
            _receiving = receiving;
            _guest = guest;
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


    public struct uID
    {

    }
}
