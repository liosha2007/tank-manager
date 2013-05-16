using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Tank : Entity
    {
        public virtual IList<Tool> tools
        {
            get;
            set;
        }

        public virtual IList<Tower> towers
        {
            get;
            set;
        }

        public virtual IList<Engine> engins
        {
            get;
            set;
        }

        public virtual IList<Crawler> crawlers
        {
            get;
            set;
        }

        public virtual IList<Radio> radios
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

        public override string ToString()
        {
            return (name == null) ? string.Empty : name;
        }
    }
}
