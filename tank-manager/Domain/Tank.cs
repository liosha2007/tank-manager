using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Tank : Entity
    {
        private Tool _tool;
        private Tower _tower;
        private Engine _engine;
        private Crawler _crawler;
        private Radio _radio;
        private int _price;
        private string _name;
        private int _experience;
        private int _strength;
        private double _massa;
        private int _reservation;
        private int _speed;
        private int _turning;
        private int _level;

        public virtual Tool tool
        {
            get;
            set;
        }

        public virtual Tower tower
        {
            get;
            set;
        }

        public virtual Engine engine
        {
            get;
            set;
        }

        public virtual Crawler crawler
        {
            get;
            set;
        }

        public virtual Radio radio
        {
            get;
            set;
        }

        public virtual int price
        {
            get;
            set;
        }

        public virtual string name
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

        public virtual double massa
        {
            get;
            set;
        }

        public virtual int reservation
        {
            get;
            set;
        }

        public virtual int speed
        {
            get;
            set;
        }

        public virtual int turning
        {
            get;
            set;
        }

        public virtual int level
        {
            get;
            set;
        }
    }
}
