using System.ComponentModel;
using System.Text;
using System.Text.Json;

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

            dataList.Add(new TableRowData(1, "Стив", "Джобс", true, new DateTime(1940, 03, 02), 500000, 2));
            dataList.Add(new TableRowData(2, "Стив", "Цукерберг", true, new DateTime(1940, 03, 02), 490000, 3));
            dataList.Add(new TableRowData(3, "Марк", "Цукерберг", true, new DateTime(1940, 03, 02), 1000000, 0));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new EditForm();
            if (f2.ShowDialog(this) == DialogResult.OK)
            {
                dataList.Add(f2.UserData);
            }
        //f2.Show(this); //-- открытие формы в немодальном режиме

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    return;
                var f2 = new EditForm(dataList[dataGridView1.SelectedRows[0].Index]);
                f2.ShowDialog(this);
            }
            catch (BindingException)
            { 

            }

        }

        private void button_infl_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            if (dataList.Count == 0 || dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Удалять нечево");
                return;
            }
            if (MessageBox.Show("Вы уверены, что хотите удалить данные из списка?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataList.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Удалил! ;(", "Фсё! :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Ну и правильно! Мало ли для чего еще пригодятся!", "(...испугааался...)",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var filename = saveFileDialog1.FileName;
                using var fs = new FileStream(filename, FileMode.Create);
                JsonSerializer.Serialize(fs, dataList);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //stat
        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void delete_Click(object sender, EventArgs e)
        {


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        //загрузить
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                bool t = true;
                var filename = openFileDialog1.FileName;
                using var sr = new StreamReader(filename, Encoding.UTF8);
                dataList.Clear();
                while (!sr.EndOfStream && t)
                {
                    var line = sr.ReadLine() ?? "";
                    try
                    {
                        var obj = JsonSerializer.Deserialize<TableRowData>(line);
                        if (obj is not null)
                        {
                            dataList.Add(obj);
                        }
                    }
                    catch (JsonException)
                    {
                        MessageBox.Show("вы используете не того формата таблицу");
                        t = false;
                    }

                }
            }
        }

        // сохранение 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var filename = saveFileDialog1.FileName;
                using var file = new FileStream(filename, FileMode.Create);
                using var sw = new StreamWriter(file, Encoding.UTF8);
                var jso = new JsonSerializerOptions();
                jso.WriteIndented = false;
                foreach (var elem in dataList)
                {
                    sw.WriteLine(JsonSerializer.Serialize<TableRowData>(elem, jso));
                }
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данные из списка?", "Внимание!",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                while (dataList.Count > 0)
                    dataList.Remove(dataList[0]);
                MessageBox.Show("Удалил! ;(", "Фсё! :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Ну и правильно! Мало ли для чего еще пригодятся!", "(...испугааался...)",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }

}