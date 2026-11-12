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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        ForEntFAdoNetEntities db = new ForEntFAdoNetEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.InformationOfUsers.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InformationOfUsers users = new InformationOfUsers();
            users.UserName = txtName.Text;
            users.UserSurname = txtSurname.Text;
            users.UserAge = int.Parse(txtAge.Text);
            users.UserPhoneNumber = txtPhoneNumber.Text;
            users.UserWeight = txtWeight.Text;
            users.UserPoints = byte.Parse(nudStudentCapacity.Text.ToString());
            users.AdminId = int.Parse(cmbTeacher.SelectedValue.ToString());
            db.InformationOfUsers.Add(users);
            db.SaveChanges();
            MessageBox.Show("Student was added");
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            var values = db.Teachers.Select(x => new {

                FullName = x.Name + " " + x.Surname,
                x.AdminId
            }
            ).ToList();
            cmbTeacher.DisplayMember = "FullName";
            cmbTeacher.ValueMember = "AdminId";
            cmbTeacher.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.InformationOfUsers.Find(id);
            updatedValue.UserName = txtName.Text;
            updatedValue.UserSurname = txtSurname.Text;
            updatedValue.UserAge = int.Parse(txtAge.Text);
            updatedValue.UserPhoneNumber = txtPhoneNumber.Text;
            updatedValue.UserWeight = txtWeight.Text;
            updatedValue.UserPoints = byte.Parse(nudStudentCapacity.Text);
            updatedValue.AdminId = int.Parse(cmbTeacher.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Student's information has been updated");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.InformationOfUsers.Find(id);
            db.InformationOfUsers.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Student's information has been deleted");
        }
    }
}
