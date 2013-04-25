using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Tower : Entity
    {
        private int _level;
        private string _name;
        private int _reservation;
        private int _rotation;
        private int _review;
        private double _massa;
        private int _price;
        private int _experience;
        private int _strength;

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
        public virtual int rotation
        {
            get;
            set;
        }
        public virtual int review
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
        public virtual int strength
        {
            get;
            set;
        }
    }
}
