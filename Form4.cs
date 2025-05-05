using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alforque_Arrayyyy
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
            lbl_MaleNo.Text = showCount(2, "Male").ToString();
            lbl_FemaleNo.Text = showCount(2, "Female").ToString();
            lbl_BasketballNo.Text = showCount(3, "Basketball").ToString();
            lbl_VolleyballNo.Text = showCount(3, "Volleyball").ToString();
            lbl_SoccerNo.Text = showCount(3, "Soccer").ToString();
            lbl_BsitNo.Text = showCount(12, "BSIT").ToString();
            lbl_BeedNo.Text = showCount(12, "BEED").ToString();
            lbl_WhiteNo.Text = showCount(7, "White").ToString();
            lbl_BlackNo.Text = showCount(7, "Black").ToString();
            lbl_PinkNo.Text = showCount(7, "Pink").ToString();
            lbl_BlueNo.Text = showCount(7, "Blue").ToString();
            lbl_ActiveNo.Text = showCount(13, "1").ToString();
            lbl_InactiveNo.Text = showCount(13, "0").ToString();
        }




        public int showCount(int c, string val)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\AlforqueArray.xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;
            int Counter = 0;
            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, c].Value == val)
                {
                    Counter++;

                }
            }
            return Counter;
        }

        private void btn_Logs_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            logs.Show();
            this.Show();
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.showStudent("1");
            fm2.Show();
        }

        private void btn_Inactive_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.showStudent("1");
            fm2.Show();
        }
    }
}
