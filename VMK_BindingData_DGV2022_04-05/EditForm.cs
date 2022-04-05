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
    public partial class EditForm : Form
    {
        public TableRowData UserData { get; private set; }
        public EditForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            UserData = new TableRowData(
                (int)numericUpDown1.Value,
                textBox1.Text,
                textBox2.Text,
                checkBox1.Checked
            );
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
