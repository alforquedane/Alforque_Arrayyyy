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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\AlforqueArray.xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;
            bool log = false;
            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, 9].Value == txt_Username.Text && sheet.Range[i, 10].Value == txt_Password.Text)
                {
                    log = true;
                    break;
                }
                else
                {
                    log = false;
                }
            }
            if (log == true)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Invalid");
                txt_Password.Clear();
                txt_Username.Clear();
            }
        }
    }
}
