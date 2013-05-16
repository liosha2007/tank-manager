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
using System.Threading;

namespace tank_manager
{
    public partial class MainWindow : Form
    {
        private Thread thread = null;
        private ToolDialog toolDialog = null;
        private TowerDialog towerDialog = null;
        private EngineDialog engineDialog = null;
        private CrawlerDialog crawlerDialog = null;
        private RadionDialog radioDialog = null;
        private ModulesDialog modulesDialog = null;
        private TankDialog tankDialog = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void m_connect_Click(object sender, EventArgs e)
        {
            m_connect.Enabled = false;
            m_status.Text = "Инициализация базы данных...";
            thread = new Thread(new ThreadStart(this.ThreadCallback));
            thread.Start();
        }

        public void ThreadCallback()
        {
            Factory.Initialize(m_server.Text, m_login.Text, m_password.Text);
            m_status.BeginInvoke((Action)(() => databaseInitialized()));
        }

        public void databaseInitialized()
        {
            m_status.Text = "База данных инициализирована!";
            m_connect.Enabled = true;

            m_addCrawler.Enabled = true;
            m_addEngine.Enabled = true;
            m_addRadio.Enabled = true;
            m_addTank.Enabled = true;
            m_addTool.Enabled = true;
            m_addTower.Enabled = true;
            m_changePrc.Enabled = true;
            m_exists.Enabled = true;
            m_refresh.Enabled = true;
        }

        private void m_addTool_Click(object sender, EventArgs e)
        {
            toolDialog = new ToolDialog();
            toolDialog.Show();
        }

        private void m_addTower_Click(object sender, EventArgs e)
        {
            towerDialog = new TowerDialog();
            towerDialog.Show();
        }

        private void m_addEngine_Click(object sender, EventArgs e)
        {
            engineDialog = new EngineDialog();
            engineDialog.Show();
        }

        private void m_addCrawler_Click(object sender, EventArgs e)
        {
            crawlerDialog = new CrawlerDialog();
            crawlerDialog.Show();
        }

        private void m_addRadio_Click(object sender, EventArgs e)
        {
            radioDialog = new RadionDialog();
            radioDialog.Show();
        }

        private void m_changePrc_Click(object sender, EventArgs e)
        {
            modulesDialog = new ModulesDialog();
            modulesDialog.Show();
        }

        private void m_addTank_Click(object sender, EventArgs e)
        {
            tankDialog = new TankDialog();
            tankDialog.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
            }
        }

        private void m_currentTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSummary();
        }

        private void update()
        {
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Tank>();
            IList<Tank> tanks = criteria.List<Tank>();
            m_exists.Items.Clear();
            foreach (Tank tank in tanks)
            {
                m_exists.Items.Add(tank);
            }

            Factory.CommitTransaction();
            Factory.CommitSession();
        }

        private void showSummary()
        {
            Tank tank = (Tank)m_exists.SelectedItem;
            m_summary.Items.Clear();
            m_summary.Items.Add("Название: " + tank.name);
            m_summary.Items.Add("Уровень: " + tank.level);
            m_summary.Items.Add("Вес: " + tank.massa);
            m_summary.Items.Add("Опыт: " + tank.experience);
            m_summary.Items.Add("Цена: " + tank.price);
            m_summary.Items.Add("Броня: " + tank.reservation);
            m_summary.Items.Add("Прочность: " + tank.turning);
            m_summary.Items.Add("Скорость: " + tank.speed);
            m_summary.Items.Add("Поворотливость: " + tank.strength);
        }

        private void m_refresh_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
