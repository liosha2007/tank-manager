using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tank_manager.Domain;
using NHibernate;
using tank_manager.Dao;
using NHibernate.Exceptions;

namespace tank_manager
{
    public partial class PatronDialog : Form
    {
        private IList<Patron> patrons = null;
        private Patron selectedPatron = null;

        public PatronDialog()
        {
            InitializeComponent();
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

            Patron patron = new Patron();
            if (selectedPatron != null)
            {
                patron = selectedPatron;
            }
            patron.calibre = (int)m_calibre.Value;
            patron.damage = (int)m_damage.Value;
            patron.name = m_name.Text;
            patron.price = (int)m_price.Value;
            patron.probity = (int)m_probity.Value;

            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            session.SaveOrUpdate(patron);

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

        private void update()
        {
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Patron>();
            patrons = criteria.List<Patron>();

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_exists.Items.Clear();
            if (patrons != null)
            {
                foreach (Patron item in patrons)
                {
                    m_exists.Items.Add(item);
                }
            }
        }

        private void m_refresh_Click(object sender, EventArgs e)
        {
            update();
        }

        private void m_edit_Click(object sender, EventArgs e)
        {
            selectedPatron = (Patron)m_exists.SelectedItem;
            if (selectedPatron != null)
            {
                m_name.Text = selectedPatron.name;
                m_calibre.Value = selectedPatron.calibre;
                m_probity.Value = selectedPatron.probity;
                m_damage.Value = selectedPatron.damage;
                m_price.Value = selectedPatron.price;
            }
        }

        private void PatronDialog_Load(object sender, EventArgs e)
        {
            update();
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            if (m_exists.SelectedItem != null)
            {
                try
                {
                    Patron elem = (Patron)m_exists.SelectedItem;

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
