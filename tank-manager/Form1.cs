using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tank_manager.Domain;
using tank_manager.Dao;
using NHibernate;

namespace tank_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Factory.BeginSession(); // Create Sessopn object

            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            Engine en = new Engine();
            en.name = "nametests";
            session.Save(en);

            Factory.CommitTransaction();
            
        }
    }
}
