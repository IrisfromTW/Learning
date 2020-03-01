using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Form
{
    class myForm : Form
    {
        Button btnOk=new Button();
        public myForm()
        {
            btnOk.Text = "Confirm";
            btnOk.Width = 60;
            btnOk.Height = 30;
            btnOk.Visible = true;
            btnOk.Left = 20;
            btnOk.Top = 15;
            this.Width = 270;
            this.Height = 100;
            this.Controls.Add(btnOk);
            this.Text = "First Form";
            btnOk.Click += new EventHandler(BtnOk);
        }

        private void BtnOk(System.Object sender,System.EventArgs e)
        {
            MessageBox.Show("Hello World!\nyeeeeeeeeeeeeeeeeee");
        }
    }
}
