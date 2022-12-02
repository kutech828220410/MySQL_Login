using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL_Login;
namespace TEST_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loginUI.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQL_Login.LoginDataWebAPI.Class_login_data class_Login_Data = this.loginUI.Get_login_data(1);
            List<LoginDataWebAPI.Class_login_data_index> list_class_login_data_index = this.loginUI.Get_login_data_index();
            string jsonString = this.loginUI.Get_login_data_index_JSONString();

            bool flag = loginUI.Get_login_data_byName(3, "批次領藥權限");
        }
    }
}
