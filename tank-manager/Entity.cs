using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Entity
    {
        private long _id;

        public virtual long id
        {
            get { return _id; }
            protected set { _id = value; }
        }
    }
}
