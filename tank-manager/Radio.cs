using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Radio : Entity
    {
        private int _level;
        private string _name;
        private int _reservation;
        private double _massa;
        private int _price;
        private int _experience;

        public virtual int level
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual int reservation
        {
            get;
            set;
        }

        public virtual double massa
        {
            get;
            set;
        }

        public virtual int price
        {
            get;
            set;
        }

        public virtual int experience
        {
            get;
            set;
        }

    }
}
