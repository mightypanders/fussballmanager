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
    public struct uID
    {

    }
}
