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
        private Binding v2Binding;
        private bool _canClose = true;
        public EditForm(TableRowData ud)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            UserData = ud;
            numericUpDown1.DataBindings.Add("Value", UserData, "Id");
            textBox1.DataBindings.Add("Text", UserData, "Value1");
            v2Binding = textBox2.DataBindings.Add("Text", UserData, "Value2");
            v2Binding.FormattingEnabled = true;//!!!!
            v2Binding.BindingComplete += v2BindingComplete;
            checkBox1.DataBindings.Add("Checked", UserData, "IsChecked");
        }

        private void v2BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState != BindingCompleteState.Success)
            {
                MessageBox.Show(e.Exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.OrangeRed;
                _canClose = false;
            }
            else _canClose = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserData is null) 
                UserData = new TableRowData(
                    (int)numericUpDown1.Value,
                    textBox1.Text,
                    textBox2.Text,
                    checkBox1.Checked
                );
            if (_canClose)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
    }
}
