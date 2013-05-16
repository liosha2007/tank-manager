using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using tank_manager.Dao;
using tank_manager.Domain;
using NHibernate.Criterion;

namespace tank_manager
{
    public partial class ModulesDialog : Form
    {
        private IList<Modules> modules = null;
        private Dictionary<ModuleType, NumericUpDown> modules2pp = new Dictionary<ModuleType, NumericUpDown>();
        private Dictionary<ModuleType, NumericUpDown> modules2uh = new Dictionary<ModuleType, NumericUpDown>();

        public ModulesDialog()
        {
            InitializeComponent();

            modules2pp.Add(ModuleType.Body, m_bodyPp);
            modules2pp.Add(ModuleType.Charging, m_chargingPp);
            modules2pp.Add(ModuleType.Chest, m_chestPp);
            modules2pp.Add(ModuleType.Commander, m_commanderPp);
            modules2pp.Add(ModuleType.Crawler, m_crawlerPp);
            modules2pp.Add(ModuleType.Device, m_devicePp);
            modules2pp.Add(ModuleType.Driver, m_driverPp);
            modules2pp.Add(ModuleType.Engine, m_enginePp);
            modules2pp.Add(ModuleType.Gunner, m_gunnerPp);
            modules2pp.Add(ModuleType.Miss, m_missPp);
            modules2pp.Add(ModuleType.Operator, m_operatorPp);
            modules2pp.Add(ModuleType.Radio, m_radionPp);
            modules2pp.Add(ModuleType.Stowage, m_stowagePp);
            modules2pp.Add(ModuleType.Turn, m_turnPp);

            modules2uh.Add(ModuleType.Body, m_bodyUh);
            modules2uh.Add(ModuleType.Charging, m_chargingUh);
            modules2uh.Add(ModuleType.Chest, m_chestUh);
            modules2uh.Add(ModuleType.Commander, m_commanderUh);
            modules2uh.Add(ModuleType.Crawler, m_crawlerUh);
            modules2uh.Add(ModuleType.Device, m_deviceUh);
            modules2uh.Add(ModuleType.Driver, m_driverUh);
            modules2uh.Add(ModuleType.Engine, m_engineUh);
            modules2uh.Add(ModuleType.Gunner, m_gunnerUh);
            modules2uh.Add(ModuleType.Miss, m_missUh);
            modules2uh.Add(ModuleType.Operator, m_operatorUh);
            modules2uh.Add(ModuleType.Radio, m_radioUh);
            modules2uh.Add(ModuleType.Stowage, m_stowageUh);
            modules2uh.Add(ModuleType.Turn, m_turnUh);
        }

        private void m_create_Click(object sender, EventArgs e)
        {
            m_status.Text = "Сохранение в базу...";
            m_createAndClose.Enabled = false;

            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            if (modules != null && modules.Count > 0)
            {
                foreach (Modules module in modules)
                {
                    module.prcdeter = Convert.ToDouble(modules2pp[module.moduleType].Value);
                    module.prchit = Convert.ToDouble(modules2uh[module.moduleType].Value);
                    session.SaveOrUpdate(module);
                }
            }
            else
            {
                foreach (ModuleType mt in modules2pp.Keys)
                {
                    Modules module = new Modules();
                    module.level = Convert.ToInt32(m_level.Value);
                    module.moduleType = mt;
                    module.prcdeter = Convert.ToDouble(modules2pp[mt].Value);
                    module.prchit = Convert.ToDouble(modules2uh[mt].Value);
                    session.SaveOrUpdate(module);
                }
            }

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_status.Text = "Сохранено!";
            m_createAndClose.Enabled = true;
            update();
        }

        public void update()
        {
            int level = Convert.ToInt32(m_level.Value);
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Modules>().Add(Restrictions.Eq(Modules.LEVEL, level));
            modules = criteria.List<Modules>();

            Factory.CommitTransaction();
            Factory.CommitSession();

            if (modules != null && modules.Count > 0)
            {
                foreach (Modules module in modules)
                {
                    NumericUpDown pp = modules2pp[module.moduleType];
                    pp.Value = Convert.ToDecimal(module.prcdeter);

                    NumericUpDown uh = modules2uh[module.moduleType];
                    uh.Value = Convert.ToDecimal(module.prchit);
                }
            }
        }

        private void ModulesDialog_Load(object sender, EventArgs e)
        {
            update();
        }

        private void m_level_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_create_Click(sender, e);
            Close();
        }

        private void m_level_Enter(object sender, EventArgs e)
        {
            update();
        }
    }
}
