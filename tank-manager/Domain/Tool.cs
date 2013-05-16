using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Tool : Entity
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
        public virtual IList<Patron> patrons
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

        public override string ToString()
        {
            return (name == null) ? string.Empty : name;
        }
    }
}
