using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.model
{
    public class Facility
    {
        private int _id;
        private string _name;
        private int _antal;

        public string Name
        {
            get => _name; 
            set => _name = value; 
        }

        public int Id
        {
            get => _id; 
            set => _id = value;
        }
        public int Antal
        {
            get => _antal;
            set => _antal = value;
        }

        public Facility(int id, string name)
        {
            id = Id;
            name = Name;
        }
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}
