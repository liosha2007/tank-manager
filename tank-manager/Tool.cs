using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Tool : Entity
    {
        private int _level;
        private string _name;
        private Patron _patron;
        private double _rate;
        private double _disorder;
        private double _reduction;
        private double _massa;
        private int _price;
        private int _experience;
        private int _ammunition;
        private int _reservation;
        private double _stowage;

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
        public virtual Patron patron
        {
            get;
            set;
        }
        public virtual double rate
        {
            get;
            set;
        }
        public virtual double disorder
        {
            get;
            set;
        }
        public virtual double reduction
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
        public virtual int ammunition
        {
            get;
            set;
        }
        public virtual int reservation
        {
            get;
            set;
        }
        public virtual double stowage
        {
            get;
            set;
        }
    }
}
