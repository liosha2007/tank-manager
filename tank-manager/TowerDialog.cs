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
    public partial class TowerDialog : Form
    {

        private Tower selected = null;

        public TowerDialog()
        {
            InitializeComponent();
        }

        private void TowerDialog_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Tower>();
            IList<Tower> items = criteria.List<Tower>();

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_exists.Items.Clear();
            if (items != null)
            {
                foreach (Tower item in items)
                {
                    m_exists.Items.Add(item);
                }
            }
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

            Tower elem = new Tower();
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
            elem.review = Convert.ToInt32(m_review.Value);
            elem.rotation = Convert.ToInt32(m_rotation.Value);
            elem.strength = Convert.ToInt32(m_strength.Value);

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
            selected = (Tower)m_exists.SelectedItem;
            if (selected != null)
            {
                m_experience.Value = selected.experience;
                m_level.Value = selected.level;
                m_massa.Value = Convert.ToDecimal(selected.massa);
                m_name.Text = selected.name;
                m_price.Value = selected.price;
                m_reservation.Value = selected.reservation;
                m_review.Value = selected.review;
                m_rotation.Value = selected.rotation;
                m_strength.Value = selected.strength;
            }
        }

        private void m_refresh_Click(object sender, EventArgs e)
        {
            update();
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            if (m_exists.SelectedItem != null)
            {
                try
                {
                    Tower elem = (Tower)m_exists.SelectedItem;

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
    }
}
