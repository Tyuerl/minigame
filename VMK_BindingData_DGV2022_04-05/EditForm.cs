namespace VMK_BindingData_DGV2022_04_05
{
    public partial class EditForm : Form
    {
        public TableRowData UserData { get; set; }
        public EditForm(TableRowData ud)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            UserData = ud;
            numericUpDown1.DataBindings.Add("Text", UserData, "Id");
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
