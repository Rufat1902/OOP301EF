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
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        ForEntFAdoNetEntities db = new ForEntFAdoNetEntities();

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            lblStudentCount.Text = db.InformationOfUsers.Count().ToString();
            lblTotalCapacity.Text = db.InformationOfUsers.Sum(x => x.UserPoints).ToString();
            lblAdminCount.Text = db.Teachers.Count().ToString();
            lblAverageCapacity.Text = db.InformationOfUsers.Average(x => x.UserPoints).ToString();
            lblAverageAge.Text = db.InformationOfUsers.Average(x => x.UserAge).ToString();
            lblMaxAge.Text = db.InformationOfUsers.Max(x => x.UserAge).ToString();
            lblMinAge.Text = db.InformationOfUsers.Min(x => x.UserAge).ToString();
            var theLastStudent = db.InformationOfUsers.Max(x => x.UserId);
            lblLastStudent.Text = db.InformationOfUsers.Where(x => x.UserId == theLastStudent).Select(y => y.UserName + " " + y.UserSurname).FirstOrDefault();
            var theTeachersStudent = db.Teachers.Where(x => x.Name == "Rufat" && x.Surname == "Valiyev").Select(y => y.AdminId).FirstOrDefault();
            lblTeachersStudents.Text = db.InformationOfUsers.Where(x => x.AdminId == theTeachersStudent).Count().ToString();
            var theBestStudents = db.InformationOfUsers.Max(x => x.UserPoints);
            lblTheBestStudent.Text = db.InformationOfUsers.Where(x => x.UserPoints == theBestStudents).Select(y => y.UserName + " " + y.UserSurname).FirstOrDefault();
        }
    }
}
