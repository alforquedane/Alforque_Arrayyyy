using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Alforque_Arrayyyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();

        string[] Student = new string[5];
        //int x = 0;
        int i = 0;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";
            string favoritecolor = "";
            string saying = "";

            data += txt_Name.Text;

            if (rb_Male.Checked)
            {
                gender = rb_Male.Text + "";
            }
            if (rb_Female.Checked)
            {
                gender = rb_Female.Text + "";
            }
            if (cb_Basketball.Checked)
            {
                hobbies += cb_Basketball.Text + ", ";
            }
            if (cb_Volleyball.Checked)
            {
                hobbies = cb_Volleyball.Text + ", ";
            }
            if (cb_Soccer.Checked)
            {
                hobbies += cb_Soccer.Text + ", ";
            }

                favoritecolor = cmb_Color.Text + "";
                saying = txt_Saying.Text + "";

                Student[i] = data;
                i++;

                f2.insert(txt_Name.Text, gender, hobbies, favoritecolor, saying);
                txt_Name.Clear();
                rb_Male.Checked = false;
                rb_Female.Checked = false;
                cb_Basketball.Checked = false;
                cb_Volleyball.Checked = false;
                cb_Soccer.Checked = false;
                cmb_Color.SelectedIndex = -1;
                txt_Saying.Clear();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            string Dis = "";

            for (int x = 0; x < Student.Length; x++)
            {
               Dis += "[" + x + "]" + Student[x] + "\n";
            }

            //MessageBox.Show(Dis);
            f2.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";
            string favoritecolor = "";
            string saying = "";

            data += txt_Name.Text;

            if (rb_Male.Checked)
            {
                gender = rb_Male.Text + "";
            }
            if (rb_Female.Checked)
            {
                gender = rb_Female.Text + "";
            }
            if (cb_Basketball.Checked)
            {
                hobbies += cb_Basketball.Text + ", ";
            }
            if (cb_Volleyball.Checked)
            {
                hobbies = cb_Volleyball.Text + ", ";
            }
            if (cb_Soccer.Checked)
            {
                hobbies += cb_Soccer.Text + ", ";
            }

            favoritecolor = cmb_Color.Text + "";
            saying = txt_Saying.Text + "";

            Student[i] = data;
            i++;

            f2.update(Convert.ToInt32(lbl_Id.Text), txt_Name.Text, gender, hobbies, favoritecolor, saying);
            txt_Name.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cb_Basketball.Checked = false;
            cb_Volleyball.Checked = false;
            cb_Soccer.Checked = false;
            cmb_Color.SelectedIndex = -1;
            txt_Saying.Clear();
        }

    }
}
