using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Tower : Entity
    {
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

        public override string ToString()
        {
            return (name == null) ? string.Empty : name;
        }
    }
}
