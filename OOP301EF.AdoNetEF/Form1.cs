using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP301EF.AdoNetEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ForEntFAdoNetEntities db = new ForEntFAdoNetEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Teachers.ToList();
            dataGridView1.DataSource = values;
            MessageBox.Show("Teachers are listed");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.Name = txtName.Text;
            teachers.Surname = txtSurname.Text;
            db.Teachers.Add(teachers);
            db.SaveChanges();
            MessageBox.Show("Teacher was added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Teachers.Find(id);
            updateValue.Name = txtName.Text;
            updateValue.Surname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Teacher's informations has been updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Teachers.Find(id);
            db.Teachers.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Teacher's informations has been deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Teachers.Where(x=>x.AdminId == id).ToList();
            dataGridView1.DataSource = values;
            db.SaveChanges();
        }
    }
}
