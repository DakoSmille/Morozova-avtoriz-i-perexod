using Morozova_avtoriz_i_perexod.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Morozova_avtoriz_i_perexod.Model;

namespace Morozova_avtoriz_i_perexod
{
    public partial class FormDirector : Form
    {
        public FormDirector()
        {
            InitializeComponent();
        }

        public static Users Enter_User;
 
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDirector_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            //Используя ранее заполненное статическое поле формы авторизации заполняем эту форму данными
            labelNames.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            labelRole.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_User.Pictures);
        }
    }
}
