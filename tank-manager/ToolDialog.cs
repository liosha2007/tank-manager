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
    public partial class ToolDialog : Form
    {
        private PatronDialog patronDialog = null;
        private Tool selected = null;

        public ToolDialog()
        {
            InitializeComponent();
        }

        private void m_addPatron_Click(object sender, EventArgs e)
        {
            patronDialog = new PatronDialog();
            patronDialog.Show();
        }

        private void ToolDialog_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            ICriteria criteria = session.CreateCriteria<Tool>();
            IList<Tool> items = criteria.List<Tool>();

            ICriteria patronCriteria = session.CreateCriteria<Patron>();
            IList<Patron> patrons = patronCriteria.List<Patron>();

            Factory.CommitTransaction();
            Factory.CommitSession();

            m_exists.Items.Clear();
            if (items != null)
            {
                foreach (Tool item in items)
                {
                    m_exists.Items.Add(item);
                }
            }

            m_patron.Items.Clear();
            if (patrons != null)
            {
                foreach (Patron item in patrons)
                {
                    m_patron.Items.Add(item);
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


            ISession session = Factory.BeginSession();
            Factory.BeginTransaction();

            Tool item = new Tool();
            if (selected != null)
            {
                item = selected;
            }
            item.ammunition = Convert.ToInt32(m_ammunition.Value);
            item.disorder = Convert.ToDouble(m_disorder.Value);
            item.experience = Convert.ToInt32(m_experience.Value);
            item.reduction = Convert.ToDouble(m_reduction.Value);
            item.level = Convert.ToInt32(m_level.Value);
            item.massa = Convert.ToDouble(m_massa.Value);
            item.name = m_name.Text;

            IList<Patron> patrons = new List<Patron>();
            foreach (Patron patron in m_patron.CheckedItems)
            {
                patrons.Add(patron);
            }
            item.patrons = patrons;

            item.price = Convert.ToInt32(m_price.Value);
            item.rate = Convert.ToInt32(m_rate.Value);
            item.reservation = Convert.ToInt32(m_reservation.Value);
            item.stowage = Convert.ToInt32(m_stowage.Value);

            session.SaveOrUpdate(item);

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
            selected = (Tool)m_exists.SelectedItem;
            if (selected != null)
            {

                m_ammunition.Value = selected.ammunition;
                m_disorder.Value = Convert.ToDecimal(selected.disorder);
                m_experience.Value = selected.experience;
                m_level.Value = selected.level;
                m_massa.Value = Convert.ToDecimal(selected.massa);
                m_name.Text = selected.name;

                List<Patron> ptrs = new List<Patron>();
                foreach (Patron patron in m_patron.Items)
                {
                    foreach (Patron cptr in selected.patrons)
                    {
                        if (patron.Id == cptr.Id)
                        {
                            ptrs.Add(patron);
                        }
                    }
                }


                foreach (int index in m_patron.CheckedIndices)
                {
                    m_patron.SetItemCheckState(index, CheckState.Unchecked);
                }

                foreach (Patron patron in ptrs)
                {
                    m_patron.SetItemCheckState(m_patron.Items.IndexOf(patron), CheckState.Checked);
                }

                m_price.Value = selected.price;
                m_rate.Value = Convert.ToDecimal(selected.rate);
                m_reduction.Value = Convert.ToDecimal(selected.reduction);
                m_reservation.Value = selected.reservation;
                m_stowage.Value = Convert.ToDecimal(selected.stowage);
            }
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            if (m_exists.SelectedItem != null)
            {
                try
                {
                    Tool elem = (Tool)m_exists.SelectedItem;

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
