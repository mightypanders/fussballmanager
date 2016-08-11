using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manager;
using manager.Constants;

namespace manager.Entities
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
        private Enumerations.Satisfaction _satisfaction;

        public Person(uID ID, string name, DateTime birth, Enumerations.Satisfaction satisfaction) : base(ID)
        {
            _name = name;
            _birth = birth;
            _satisfaction = satisfaction;
        }
    }

    class Team : Entity
    {

        private List<Person> _Members;
        private string _name;
        private DateTime _founded;
        private Person _manager;
        private Person _trainer;
        private Enumerations.Morale _morale;

        public Team(uID ID, string name, DateTime founded, Person manager, Person trainer, Enumerations.Morale morale) : base(ID)
        {
            _name = name;
            _founded = founded;
            _manager = manager;
            _trainer = trainer;
            _morale = morale;
        }

    }




}
