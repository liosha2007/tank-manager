using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.Windows.Forms;

namespace tank_manager.Dao
{
    class Factory
    {
        private static ISessionFactory sessionFactory = null;
        private static ITransaction transaction = null;
        private static ISession session = null;

        public static void Initialize(string server, string username, string password)
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
            }
            string connection_string = "Server={0};Database={3};User ID={1};Password={2};";
            connection_string = connection_string.Replace("{0}", server);
            connection_string = connection_string.Replace("{1}", username);
            connection_string = connection_string.Replace("{2}", password);
            connection_string = connection_string.Replace("{3}", "liosha_nhtest");
            try
            {
                sessionFactory = new Configuration().Configure("Config\\hibernate.cfg.xml").SetProperty("connection.connection_string", connection_string).BuildSessionFactory();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
