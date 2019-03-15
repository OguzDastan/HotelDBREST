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

        public Facility()
        {
            
        }

        public Facility(int id, string name)
        {
            id = _id;
            name = _name;
        }
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}
