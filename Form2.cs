using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Alforque_Arrayyyy
{

    public partial class Form2 : Form
    {
        Workbook book = new Workbook();
        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();
        }

        private void LoadExcelFile()
        {
        
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\AlforqueArray.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();
            dgvDisplay.DataSource = dt;
        }

        public void insert(string name, string gender, string hobbies, string favoritecolor, string saying)
        {
            int i = dgvDisplay.Rows.Add();
            dgvDisplay.Rows[i].Cells[0].Value = name;
            dgvDisplay.Rows[i].Cells[1].Value = gender;
            dgvDisplay.Rows[i].Cells[2].Value = hobbies;
            dgvDisplay.Rows[i].Cells[3].Value = favoritecolor;
            dgvDisplay.Rows[i].Cells[4].Value = saying;
        }

        public void update(int id, string name, string gender, string hobbies, string favoritecolor, string saying)
        {
            dgvDisplay.Rows[id].Cells[0].Value = name;
            dgvDisplay.Rows[id].Cells[1].Value = gender;
            dgvDisplay.Rows[id].Cells[2].Value = hobbies;
            dgvDisplay.Rows[id].Cells[3].Value = favoritecolor;
            dgvDisplay.Rows[id].Cells[4].Value = saying;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow items in dgvDisplay.SelectedRows)
            {
                dgvDisplay.Rows.RemoveAt(items.Index);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgvDisplay.ClearSelection();

            foreach (DataGridViewRow i in dgvDisplay.Rows)
            {
                if (i.Cells[0].Value.ToString().Equals(txt_Search.Text))
                {
                    i.Selected = true;
                    break;
                }
            }
        }

        private void dgv_DisplayCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            int r = dgvDisplay.CurrentCell.RowIndex;
            f1.txt_Name.Text = dgvDisplay.Rows[r].Cells[0].Value.ToString();
            f1.lbl_Id.Text = r.ToString();
            string gender = dgvDisplay.Rows[r].Cells[1].Value.ToString();
            string[] gen = gender.Split();
            if (gender.Trim() == "Male")
            {
                f1.rb_Male.Checked = true;
            }
            if (gender.Trim() == "Female")
            {
                f1.rb_Female.Checked = true;
            }
            string hobbies = dgvDisplay.Rows[r].Cells[2].Value.ToString();
            string[] hob = hobbies.Split(',');
            foreach (string h in hob)
            {
                if (h.Trim() == "Basketball")
                {
                    f1.cb_Basketball.Checked = true;
                }
                if (h.Trim() == "Volleyball")
                {
                    f1.cb_Volleyball.Checked = true;
                }
                if (h.Trim() == "Soccer")

                {
                    f1.cb_Soccer.Checked = true;
                }
            }
            f1.cmb_Color.SelectedItem = dgvDisplay.Rows[r].Cells[3].Value.ToString();
            f1.txt_Saying.Text = dgvDisplay.Rows[r].Cells[4].Value.ToString();


            //dgvDisplay.Rows[i].Cells[1].Value.ToString();
            //dgvDisplay.Rows[i].Cells[2].Value.ToString();
            //dgvDisplay.Rows[i].Cells[3].Value.ToString();
            //dgvDisplay.Rows[i].Cells[4].Value.ToString();
        }

        public void showStudent(string status)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\AlforqueArray.xlsx");
            Worksheet sheet = book.Worksheets[0];

            DataTable dt = sheet.ExportDataTable();

            DataRow[] row = dt.Select("STATUS=" + status);

            int count = 0;

            foreach (DataRow r in row)
            {

                dgvDisplay.Rows.Insert(count,
                     r[0],
                     r[1],
                     r[2],
                     r[3],
                     r[4],
                     r[5],
                     r[6],
                     r[7],
                     r[8],
                     r[9],
                     r[10],
                     r[11],
                     r[12]
                     );
                count++;
            }


        }
    }
}
