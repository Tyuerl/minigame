namespace VMK_BindingData_DGV2022_04_05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAll = new System.Windows.Forms.ToolStripButton();
            this.adv = new System.Windows.Forms.ToolStripButton();
            this.infl = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 92);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фамилииToolStripMenuItem,
            this.зарплатеToolStripMenuItem,
            this.номеруToolStripMenuItem,
            this.имениToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // фамилииToolStripMenuItem
            // 
            this.фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            this.фамилииToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.фамилииToolStripMenuItem.Text = "Фамилии";
            this.фамилииToolStripMenuItem.Click += new System.EventHandler(this.фамилииToolStripMenuItem_Click);
            // 
            // зарплатеToolStripMenuItem
            // 
            this.зарплатеToolStripMenuItem.Name = "зарплатеToolStripMenuItem";
            this.зарплатеToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.зарплатеToolStripMenuItem.Text = "Зарплате";
            this.зарплатеToolStripMenuItem.Click += new System.EventHandler(this.зарплатеToolStripMenuItem_Click);
            // 
            // номеруToolStripMenuItem
            // 
            this.номеруToolStripMenuItem.Name = "номеруToolStripMenuItem";
            this.номеруToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.номеруToolStripMenuItem.Text = "Номеру";
            this.номеруToolStripMenuItem.Click += new System.EventHandler(this.номеруToolStripMenuItem_Click);
            // 
            // имениToolStripMenuItem
            // 
            this.имениToolStripMenuItem.Name = "имениToolStripMenuItem";
            this.имениToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.имениToolStripMenuItem.Text = "Имени";
            this.имениToolStripMenuItem.Click += new System.EventHandler(this.имениToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "Файлы JSON|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы JSON|*.json";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.deleteAll,
            this.adv,
            this.infl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.load});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Сохранить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(133, 22);
            this.load.Text = "Загрузить";
            this.load.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteAll.Image = ((System.Drawing.Image)(resources.GetObject("deleteAll.Image")));
            this.deleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(82, 22);
            this.deleteAll.Text = "Удалить всех";
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // adv
            // 
            this.adv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adv.Image = ((System.Drawing.Image)(resources.GetObject("adv.Image")));
            this.adv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adv.Name = "adv";
            this.adv.Size = new System.Drawing.Size(72, 22);
            this.adv.Text = "Статистика";
            this.adv.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // infl
            // 
            this.infl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infl.Image = ((System.Drawing.Image)(resources.GetObject("infl.Image")));
            this.infl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infl.Name = "infl";
            this.infl.Size = new System.Drawing.Size(69, 22);
            this.infl.Text = "Инфляция";
            this.infl.Click += new System.EventHandler(this.infl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private ToolStripMenuItem фамилииToolStripMenuItem;
        private ToolStripMenuItem зарплатеToolStripMenuItem;
        private ToolStripMenuItem номеруToolStripMenuItem;
        private ToolStripMenuItem имениToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton adv;
        private ToolStripButton infl;
        private ToolStripButton deleteAll;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem load;
    }
}