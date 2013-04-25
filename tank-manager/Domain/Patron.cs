using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Patron : Entity
    {
        private string _name;
        private int _calibre;
        private int _probity;
        private int _damage;
        private int _price;

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
    }
}
