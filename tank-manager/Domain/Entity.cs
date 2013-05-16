using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tank_manager.Domain
{
    class Entity
    {
        private long id;

        public virtual long Id
        {
            get { return id; }
            protected set { id = value; }
        }
    }
}
