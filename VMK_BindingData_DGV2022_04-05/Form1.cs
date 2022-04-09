using System.ComponentModel;
using System.Text;

namespace VMK_BindingData_DGV2022_04_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingList<TableRowData> dataList = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataList;
            dataList.Add(new TableRowData(1, "Значение 1_1", "Значение 1_2", true));
            dataList.Add(new TableRowData(2, "Значение 2_1", "Значение 2_2", false));
            dataList.Add(new TableRowData(3, "Значение 3_1", "Значение 3_2", true));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new EditForm();
            //f2.Show(this); //-- открытие формы в немодальном режиме
            if (f2.ShowDialog(this) == DialogResult.OK)
            {
                dataList.Add(f2.UserData);
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new EditForm(dataList[dataGridView1.SelectedRows[0].Index]);
            f2.ShowDialog(this);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данные из списка?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Прям точно уверены? Данные нельзя будет восстановить!", "Ой!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Ну, тогда я удаляю, да?", "Последний шанс!", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        dataList.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Удалил! ;(", "Фсё! :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            MessageBox.Show("Ну и правильно! Мало ли для чего еще пригодятся!", "(...испугааался...)",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}