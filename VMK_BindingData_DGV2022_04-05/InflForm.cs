using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMK_BindingData_DGV2022_04_05
{
    public partial class InflForm : Form
    {
        private List <TableRowData> UserData { get; set; }
        private BindingList<TableRowData> SourceUserData;
        public InflForm(BindingList <TableRowData>? ud = null)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            if (ud is not null)
            {
                SourceUserData = ud;
            }
            else
            {
                MessageBox.Show("Ошибка", "Табличка пустая");
               // Close();
            };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label3.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
            }
            else
            {
                label3.Visible = true;
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double all_zp = 0;
            double infl = double.Parse(inflytion.Text) / 100;
            if (checkBox1.Checked == true)
                for (int i = 0; i < SourceUserData.Count; i++)
                    all_zp += SourceUserData[i].Salary * (infl);
            else
            {
                foreach (TableRowData qur in SourceUserData)
                    if (numericUpDown1.Value < qur.Id && qur.Id < numericUpDown2.Value)
                        all_zp += qur.Salary * (infl);
            }
            if (MessageBox.Show("Вы точно хотите поднять зарлату всем сотрудникам в общей сумме: " + all_zp,
                "Подятие зп, вы уверены?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkBox1.Checked == true)
                    for (int i = 0; i < SourceUserData.Count; i++)
                     SourceUserData[i].Salary += SourceUserData[i].Salary * (infl);
                else
                {
                    for (int i = 0; i < SourceUserData.Count; i++)
                        if (numericUpDown1.Value < SourceUserData[i].Id && SourceUserData[i].Id < numericUpDown2.Value)
                            SourceUserData[i].Salary += SourceUserData[i].Salary * (infl);
                }
            }
            else
                MessageBox.Show("Больно много хотят, и так миллионы получают", "мои деньги мои бургеры",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void inflytion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
