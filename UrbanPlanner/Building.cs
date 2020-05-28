using System;

namespace UrbanPlanner
{
    public class Building
    {
        private string _designer { get; set; } = "Jon Durr";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume
        {
            get 
            {
                return Stories * Depth * 3;
            }
        }
        public void Contruct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }

        public Building(string address)
        {
            _address = address;
        }

        public override string ToString()
        {
            return $@"
            {_address}
            -----------------
            Designed By {_designer}
            Constructed on {_dateConstructed}
            Owned by {_owner}
            {Volume} cubic meters of space
            ";
        } 
    }
}