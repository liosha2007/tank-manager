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
    public partial class RadionDialog : Form
    {
        private Radio selected = null;

        public RadionDialog()
        {
            InitializeComponent();
        }

        private void RadionDialog_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Radio>();
            IList<Radio> items = criteria.List<Radio>();

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_exists.Items.Clear();
            if (items != null)
            {
                foreach (Radio item in items)
                {
                    m_exists.Items.Add(item);
                }
            }
        }

        private void m_refresh_Click(object sender, EventArgs e)
        {
            update();
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

            Radio elem = new Radio();
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
            selected = (Radio)m_exists.SelectedItem;
            if (selected != null)
            {
                m_experience.Value = selected.experience;
                m_level.Value = selected.level;
                m_massa.Value = Convert.ToDecimal(selected.massa);
                m_name.Text = selected.name;
                m_price.Value = selected.price;
                m_reservation.Value = selected.reservation;
            }
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            if (m_exists.SelectedItem != null)
            {
                try
                {
                    Radio elem = (Radio)m_exists.SelectedItem;

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
