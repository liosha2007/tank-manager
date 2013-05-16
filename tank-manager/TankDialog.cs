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
using NHibernate.Exceptions;

namespace tank_manager
{
    public partial class TankDialog : Form
    {
        private Tank selected = null;

        public TankDialog()
        {
            InitializeComponent();
        }

        private void TankDialog_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Tank>();
            IList<Tank> tanks = criteria.List<Tank>();

            criteria = session.CreateCriteria<Tool>();
            IList<Tool> tools = criteria.List<Tool>();

            criteria = session.CreateCriteria<Tower>();
            IList<Tower> towers = criteria.List<Tower>();

            criteria = session.CreateCriteria<Engine>();
            IList<Engine> engines = criteria.List<Engine>();

            criteria = session.CreateCriteria<Crawler>();
            IList<Crawler> crawlers = criteria.List<Crawler>();

            criteria = session.CreateCriteria<Radio>();
            IList<Radio> radios = criteria.List<Radio>();

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_exists.Items.Clear();
            m_exists.Items.AddRange(tanks.ToArray<Tank>());

            m_tool.Items.Clear();
            m_tool.Items.AddRange(tools.ToArray<Tool>());

            m_tower.Items.Clear();
            m_tower.Items.AddRange(towers.ToArray<Tower>());

            m_engine.Items.Clear();
            m_engine.Items.AddRange(engines.ToArray<Engine>());

            m_crawler.Items.Clear();
            m_crawler.Items.AddRange(crawlers.ToArray<Crawler>());

            m_radio.Items.Clear();
            m_radio.Items.AddRange(radios.ToArray<Radio>());
        }

        private void m_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_name.Text))
            {
                MessageBox.Show("Введи название!!!");
                return;
            }
            m_status.Text = "Сохранение в базу...";
            m_create.Enabled = false;
            m_createAndClose.Enabled = false;

            Tank elem = new Tank();
            if (selected != null)
            {
                elem = selected;
            }
            elem.experience = Convert.ToInt32(m_experience.Value);
            elem.level = Convert.ToInt32(m_level.Value);
            elem.massa = Convert.ToDouble(m_massa.Value);
            elem.name = m_name.Text;
            elem.price = Convert.ToInt32(m_price.Value);
            elem.reservation = Convert.ToInt32(m_reservation.Value);
            elem.speed = Convert.ToInt32(m_speed.Value);
            elem.turning = Convert.ToInt32(m_turning.Value);
            elem.strength = Convert.ToInt32(m_strength.Value);
            
            elem.tools = new List<Tool>();
            elem.towers = new List<Tower>();
            elem.engins = new List<Engine>();
            elem.crawlers = new List<Crawler>();
            elem.radios = new List<Radio>();

            foreach (Tool item in m_tool.CheckedItems)
            {
                elem.tools.Add(item);
            }

            foreach (Tower item in m_tower.CheckedItems)
            {
                elem.towers.Add(item);
            }

            foreach (Engine item in m_engine.CheckedItems)
            {
                elem.engins.Add(item);
            }

            foreach (Crawler item in m_crawler.CheckedItems)
            {
                elem.crawlers.Add(item);
            }

            foreach (Radio item in m_radio.CheckedItems)
            {
                elem.radios.Add(item);
            }

            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            session.SaveOrUpdate(elem);

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_status.Text = "Сохранено!";
            m_create.Enabled = true;
            m_createAndClose.Enabled = true;
            update();
        }

        private void m_createAndClose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_name.Text))
            {
                MessageBox.Show("Введи название!!!");
                return;
            }
            m_create_Click(sender, e);
            Close();
        }

        private void m_edit_Click(object sender, EventArgs e)
        {
            selected = (Tank)m_exists.SelectedItem;
            if (selected != null)
            {
                m_experience.Value = selected.experience;
                m_level.Value = selected.level;
                m_massa.Value = Convert.ToDecimal(selected.massa);
                m_name.Text = selected.name;
                m_price.Value = selected.price;
                m_reservation.Value = selected.reservation;
                m_speed.Value = selected.speed;
                m_turning.Value = selected.turning;
                m_strength.Value = selected.strength;
                //
                foreach (int index in m_tool.CheckedIndices)
                {
                    m_tool.SetItemCheckState(index, CheckState.Unchecked);
                }

                foreach (Tool tool in selected.tools)
                {
                    m_tool.SetItemCheckState(m_tool.Items.IndexOf(tool), CheckState.Checked);
                }
                //
                foreach (int index in m_tower.CheckedIndices)
                {
                    m_tower.SetItemCheckState(index, CheckState.Unchecked);
                }

                foreach (Tower tower in selected.towers)
                {
                    m_tower.SetItemCheckState(m_tower.Items.IndexOf(tower), CheckState.Checked);
                }
                //
                foreach (int index in m_engine.CheckedIndices)
                {
                    m_engine.SetItemCheckState(index, CheckState.Unchecked);
                }

                foreach (Engine engine in selected.engins)
                {
                    m_engine.SetItemCheckState(m_engine.Items.IndexOf(engine), CheckState.Checked);
                }
                //
                foreach (int index in m_crawler.CheckedIndices)
                {
                    m_crawler.SetItemCheckState(index, CheckState.Unchecked);
                }

                foreach (Crawler crawler in selected.crawlers)
                {
                    m_crawler.SetItemCheckState(m_crawler.Items.IndexOf(crawler), CheckState.Checked);
                }
                //
                foreach (int index in m_radio.CheckedIndices)
                {
                    m_radio.SetItemCheckState(index, CheckState.Unchecked);
                }

                foreach (Radio radio in selected.radios)
                {
                    m_radio.SetItemCheckState(m_radio.Items.IndexOf(radio), CheckState.Checked);
                }
            }
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            if (m_exists.SelectedItem != null)
            {
                try
                {
                    Tank elem = (Tank)m_exists.SelectedItem;

                    ISession session = Factory.BeginSession();
                    Factory.BeginTransaction();

                    session.Delete(elem);

                    Factory.CommitTransaction();
                    Factory.CommitSession();
                    update();
                }
                catch (GenericADOException ex)
                {
                    MessageBox.Show("Нельзя удалить! Модуль используется!\r\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void m_addTool_Click(object sender, EventArgs e)
        {
            new ToolDialog().Show();
        }

        private void m_addTower_Click(object sender, EventArgs e)
        {
            new TowerDialog().Show();
        }

        private void m_addEngine_Click(object sender, EventArgs e)
        {
            new EngineDialog().Show();
        }

        private void m_addCrawler_Click(object sender, EventArgs e)
        {
            new CrawlerDialog().Show();
        }

        private void m_addRadio_Click(object sender, EventArgs e)
        {
            new RadionDialog().Show();
        }
    }
}
