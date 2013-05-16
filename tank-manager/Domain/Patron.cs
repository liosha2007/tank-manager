using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Patron : Entity
    {
        public virtual string name
        {
            get;
            set;
        }

        public virtual int calibre
        {
            get;
            set;
        }

        public virtual int probity
        {
            get;
            set;
        }

        public virtual int damage
        {
            get;
            set;
        }

        public virtual int price
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
