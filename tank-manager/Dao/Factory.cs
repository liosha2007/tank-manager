using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace tank_manager.Dao
{
    class Factory
    {
        private static ISessionFactory sessionFactory = new Configuration().Configure("Config\\hibernate.cfg.xml").BuildSessionFactory();
        private static ITransaction transaction = null;
        private static ISession session = null;

        public static ISession BeginSession()
        {
            if (session == null)
            {
                session = sessionFactory.OpenSession();
            }
            return session;
        }

        public static ITransaction BeginTransaction()
        {
            if (session != null)
            {
                if (transaction != null)
                {
                    return transaction;
                }
                transaction = session.BeginTransaction();
                return transaction;
            }
            return null;
        }

        public static void CommitTransaction()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction = null;
            }
        }

        public static void CommitSession()
        {
            if (session != null)
            {
                if (transaction != null)
                {
                    CommitTransaction();
                }
                session.Flush();
                session.Clear();
                session.Close();
                session = null;
            }
        }
    }
}
