
namespace Tyuiu.SychevAD.Sprint7.Project.V2
{
    partial class FormWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWork));
            saveFileDialogTable_SAD = new SaveFileDialog();
            openFileDialogTable_SAD = new OpenFileDialog();
            menuStrip_SAD = new MenuStrip();
            SearchToolStripMenuItem_SAD = new ToolStripMenuItem();
            toolStripTextBoxSearch_SAD = new ToolStripTextBox();
            toolStripMenuFile_SAD = new ToolStripMenuItem();
            toolStripMenuItemAdd_SAD = new ToolStripMenuItem();
            toolStripMenuItemOpen_SAD = new ToolStripMenuItem();
            toolStripMenuItemSave_SAD = new ToolStripMenuItem();
            toolStripMenuItemInfo_SAD = new ToolStripMenuItem();
            toolStripMenuItemInstruction_SAD = new ToolStripMenuItem();
            toolStripMenuItemAbout_SAD = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemExit_SAD = new ToolStripMenuItem();
            tabPageStats_SAD = new TabPage();
            buttonGetStats_SAD = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageOrderData_SAD = new TabPage();
            groupBoxMovesOrders_SAD = new GroupBox();
            groupBox5 = new GroupBox();
            textBoxFilter_SAD = new TextBox();
            groupBox4 = new GroupBox();
            textBoxSearch_SAD = new TextBox();
            groupBox3 = new GroupBox();
            comboBoxColsNames_SAD = new ComboBox();
            groupBox1 = new GroupBox();
            buttonRemoveRows_SAD = new Button();
            buttonAddOrders_SAD = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            buttonDownloadOrders_SAD = new Button();
            buttonOpenOrder_SAD = new Button();
            dataGridViewTableOrders_SAD = new DataGridView();
            NumberOrder_SAD = new DataGridViewTextBoxColumn();
            DateDone_SAD = new DataGridViewTextBoxColumn();
            PriceOrder_SAD = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            NameOrder_SAD = new DataGridViewTextBoxColumn();
            buttonFilter_SAD = new Button();
            tabControl_SAD = new TabControl();
            splitter1 = new Splitter();
            menuStrip_SAD.SuspendLayout();
            tabPageStats_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPageOrderData_SAD.SuspendLayout();
            groupBoxMovesOrders_SAD.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_SAD).BeginInit();
            tabControl_SAD.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTable_SAD
            // 
            openFileDialogTable_SAD.FileName = "openFileDialog1";
            // 
            // menuStrip_SAD
            // 
            menuStrip_SAD.BackColor = SystemColors.Info;
            menuStrip_SAD.ImageScalingSize = new Size(20, 20);
            menuStrip_SAD.Items.AddRange(new ToolStripItem[] { SearchToolStripMenuItem_SAD, toolStripMenuFile_SAD, toolStripMenuItemInfo_SAD, toolStripMenuItemExit_SAD });
            menuStrip_SAD.Location = new Point(0, 0);
            menuStrip_SAD.Name = "menuStrip_SAD";
            menuStrip_SAD.Padding = new Padding(8, 3, 0, 3);
            menuStrip_SAD.Size = new Size(1457, 28);
            menuStrip_SAD.TabIndex = 4;
            menuStrip_SAD.Text = "menuStrip1";
            // 
            // SearchToolStripMenuItem_SAD
            // 
            SearchToolStripMenuItem_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxSearch_SAD });
            SearchToolStripMenuItem_SAD.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SearchToolStripMenuItem_SAD.Name = "SearchToolStripMenuItem_SAD";
            SearchToolStripMenuItem_SAD.Size = new Size(69, 22);
            SearchToolStripMenuItem_SAD.Text = "Найти";
            // 
            // toolStripTextBoxSearch_SAD
            // 
            toolStripTextBoxSearch_SAD.Name = "toolStripTextBoxSearch_SAD";
            toolStripTextBoxSearch_SAD.Size = new Size(100, 27);
            toolStripTextBoxSearch_SAD.TextChanged += toolStripTextBoxSearch_SAD_TextChanged;
            // 
            // toolStripMenuFile_SAD
            // 
            toolStripMenuFile_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAdd_SAD, toolStripMenuItemOpen_SAD, toolStripMenuItemSave_SAD });
            toolStripMenuFile_SAD.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripMenuFile_SAD.Name = "toolStripMenuFile_SAD";
            toolStripMenuFile_SAD.Size = new Size(64, 22);
            toolStripMenuFile_SAD.Text = "Файл";
            // 
            // toolStripMenuItemAdd_SAD
            // 
            toolStripMenuItemAdd_SAD.Name = "toolStripMenuItemAdd_SAD";
            toolStripMenuItemAdd_SAD.Size = new Size(173, 26);
            toolStripMenuItemAdd_SAD.Text = "Добавить";
            toolStripMenuItemAdd_SAD.Click += buttonAdd_SAD_Click;
            // 
            // toolStripMenuItemOpen_SAD
            // 
            toolStripMenuItemOpen_SAD.Name = "toolStripMenuItemOpen_SAD";
            toolStripMenuItemOpen_SAD.Size = new Size(173, 26);
            toolStripMenuItemOpen_SAD.Text = "Открыть";
            toolStripMenuItemOpen_SAD.Click += buttonOpen_SAD_Click;
            // 
            // toolStripMenuItemSave_SAD
            // 
            toolStripMenuItemSave_SAD.Name = "toolStripMenuItemSave_SAD";
            toolStripMenuItemSave_SAD.Size = new Size(173, 26);
            toolStripMenuItemSave_SAD.Text = "Сохранить";
            toolStripMenuItemSave_SAD.Click += buttonDownload_SAD_Click;
            // 
            // toolStripMenuItemInfo_SAD
            // 
            toolStripMenuItemInfo_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_SAD, toolStripMenuItemAbout_SAD, поддержкаToolStripMenuItem });
            toolStripMenuItemInfo_SAD.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_SAD.Name = "toolStripMenuItemInfo_SAD";
            toolStripMenuItemInfo_SAD.Size = new Size(88, 22);
            toolStripMenuItemInfo_SAD.Text = "Справка";
            // 
            // toolStripMenuItemInstruction_SAD
            // 
            toolStripMenuItemInstruction_SAD.Name = "toolStripMenuItemInstruction_SAD";
            toolStripMenuItemInstruction_SAD.Size = new Size(377, 26);
            toolStripMenuItemInstruction_SAD.Text = "Краткое руководство пользователя";
            toolStripMenuItemInstruction_SAD.Click += toolStripMenuItemInstruction_SAD_Click;
            // 
            // toolStripMenuItemAbout_SAD
            // 
            toolStripMenuItemAbout_SAD.Name = "toolStripMenuItemAbout_SAD";
            toolStripMenuItemAbout_SAD.Size = new Size(377, 26);
            toolStripMenuItemAbout_SAD.Text = "О программе ";
            toolStripMenuItemAbout_SAD.Click += buttonInfo_SAD_Click;
            // 
            // поддержкаToolStripMenuItem
            // 
            поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            поддержкаToolStripMenuItem.Size = new Size(377, 26);
            поддержкаToolStripMenuItem.Text = "Поддержка";
            поддержкаToolStripMenuItem.Click += поддержкаToolStripMenuItem_Click;
            // 
            // toolStripMenuItemExit_SAD
            // 
            toolStripMenuItemExit_SAD.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripMenuItemExit_SAD.Name = "toolStripMenuItemExit_SAD";
            toolStripMenuItemExit_SAD.Size = new Size(73, 22);
            toolStripMenuItemExit_SAD.Text = "Выход";
            toolStripMenuItemExit_SAD.Click += toolStripMenuItemExit_SAD_Click;
            // 
            // tabPageStats_SAD
            // 
            tabPageStats_SAD.Controls.Add(buttonGetStats_SAD);
            tabPageStats_SAD.Controls.Add(chart1);
            tabPageStats_SAD.Location = new Point(4, 37);
            tabPageStats_SAD.Margin = new Padding(4, 5, 4, 5);
            tabPageStats_SAD.Name = "tabPageStats_SAD";
            tabPageStats_SAD.Size = new Size(1449, 883);
            tabPageStats_SAD.TabIndex = 2;
            tabPageStats_SAD.Text = "Статистика";
            tabPageStats_SAD.UseVisualStyleBackColor = true;
            // 
            // buttonGetStats_SAD
            // 
            buttonGetStats_SAD.Location = new Point(588, 722);
            buttonGetStats_SAD.Margin = new Padding(4, 5, 4, 5);
            buttonGetStats_SAD.Name = "buttonGetStats_SAD";
            buttonGetStats_SAD.Size = new Size(227, 60);
            buttonGetStats_SAD.TabIndex = 1;
            buttonGetStats_SAD.Text = "Получить статистику по выручке из каждого филиала";
            buttonGetStats_SAD.UseVisualStyleBackColor = true;
            buttonGetStats_SAD.Click += button1_Click;
            // 
            // chart1
            // 
            chartArea2.Name = "Размер выручки";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Размер выручки";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(11, 5);
            chart1.Margin = new Padding(4, 5, 4, 5);
            chart1.Name = "chart1";
            series2.ChartArea = "Размер выручки";
            series2.Legend = "Размер выручки";
            series2.MarkerSize = 1;
            series2.Name = "Размер выручки";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart1.Series.Add(series2);
            chart1.Size = new Size(1425, 708);
            chart1.TabIndex = 0;
            chart1.Text = "Размер выручки";
            chart1.Click += chart1_Click;
            // 
            // tabPageOrderData_SAD
            // 
            tabPageOrderData_SAD.Controls.Add(groupBoxMovesOrders_SAD);
            tabPageOrderData_SAD.Location = new Point(4, 37);
            tabPageOrderData_SAD.Margin = new Padding(4, 5, 4, 5);
            tabPageOrderData_SAD.Name = "tabPageOrderData_SAD";
            tabPageOrderData_SAD.Padding = new Padding(4, 5, 4, 5);
            tabPageOrderData_SAD.Size = new Size(1449, 883);
            tabPageOrderData_SAD.TabIndex = 1;
            tabPageOrderData_SAD.Text = "База данных сети магазинов ИП Сычев А.Д";
            tabPageOrderData_SAD.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovesOrders_SAD
            // 
            groupBoxMovesOrders_SAD.BackColor = SystemColors.Info;
            groupBoxMovesOrders_SAD.Controls.Add(groupBox5);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox4);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox3);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox1);
            groupBoxMovesOrders_SAD.Controls.Add(label3);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox2);
            groupBoxMovesOrders_SAD.Controls.Add(dataGridViewTableOrders_SAD);
            groupBoxMovesOrders_SAD.Controls.Add(buttonFilter_SAD);
            groupBoxMovesOrders_SAD.Location = new Point(4, 0);
            groupBoxMovesOrders_SAD.Name = "groupBoxMovesOrders_SAD";
            groupBoxMovesOrders_SAD.Size = new Size(1443, 800);
            groupBoxMovesOrders_SAD.TabIndex = 4;
            groupBoxMovesOrders_SAD.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.AccessibleRole = AccessibleRole.None;
            groupBox5.BackColor = SystemColors.Info;
            groupBox5.Controls.Add(textBoxFilter_SAD);
            groupBox5.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox5.Location = new Point(867, 0);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(292, 100);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Введите ключ для фильтрации:";
            // 
            // textBoxFilter_SAD
            // 
            textBoxFilter_SAD.BackColor = Color.SeaShell;
            textBoxFilter_SAD.Enabled = false;
            textBoxFilter_SAD.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxFilter_SAD.Location = new Point(27, 45);
            textBoxFilter_SAD.Margin = new Padding(4, 5, 4, 5);
            textBoxFilter_SAD.Name = "textBoxFilter_SAD";
            textBoxFilter_SAD.Size = new Size(236, 29);
            textBoxFilter_SAD.TabIndex = 1;
            textBoxFilter_SAD.TextChanged += textBoxFilter_SAD_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Info;
            groupBox4.Controls.Add(textBoxSearch_SAD);
            groupBox4.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(617, 0);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(288, 100);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Введите ключ для поиска:\n";
            // 
            // textBoxSearch_SAD
            // 
            textBoxSearch_SAD.BackColor = Color.SeaShell;
            textBoxSearch_SAD.Location = new Point(8, 48);
            textBoxSearch_SAD.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch_SAD.Name = "textBoxSearch_SAD";
            textBoxSearch_SAD.Size = new Size(185, 28);
            textBoxSearch_SAD.TabIndex = 1;
            textBoxSearch_SAD.TextChanged += textBoxSearch_SAD_TextChanged_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(comboBoxColsNames_SAD);
            groupBox3.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(409, 0);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(272, 100);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите столбец";
            // 
            // comboBoxColsNames_SAD
            // 
            comboBoxColsNames_SAD.BackColor = Color.DarkSalmon;
            comboBoxColsNames_SAD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColsNames_SAD.ForeColor = SystemColors.WindowText;
            comboBoxColsNames_SAD.FormattingEnabled = true;
            comboBoxColsNames_SAD.Items.AddRange(new object[] { "", "Номер филиала", "Название магазина", "Адрес", "Ежемесячная выручка", "Контактный телефон" });
            comboBoxColsNames_SAD.Location = new Point(8, 48);
            comboBoxColsNames_SAD.Margin = new Padding(4, 5, 4, 5);
            comboBoxColsNames_SAD.Name = "comboBoxColsNames_SAD";
            comboBoxColsNames_SAD.Size = new Size(191, 31);
            comboBoxColsNames_SAD.TabIndex = 3;
            comboBoxColsNames_SAD.SelectedIndexChanged += comboBoxColsNames_SAD_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(buttonRemoveRows_SAD);
            groupBox1.Controls.Add(buttonAddOrders_SAD);
            groupBox1.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(225, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(227, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить/Удалить ";
            // 
            // buttonRemoveRows_SAD
            // 
            buttonRemoveRows_SAD.BackColor = SystemColors.Info;
            buttonRemoveRows_SAD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRemoveRows_SAD.Enabled = false;
            buttonRemoveRows_SAD.FlatStyle = FlatStyle.Flat;
            buttonRemoveRows_SAD.ForeColor = Color.Black;
            buttonRemoveRows_SAD.Image = (Image)resources.GetObject("buttonRemoveRows_SAD.Image");
            buttonRemoveRows_SAD.Location = new Point(88, 38);
            buttonRemoveRows_SAD.Name = "buttonRemoveRows_SAD";
            buttonRemoveRows_SAD.Size = new Size(51, 51);
            buttonRemoveRows_SAD.TabIndex = 0;
            buttonRemoveRows_SAD.UseVisualStyleBackColor = false;
            buttonRemoveRows_SAD.Click += buttonRemoveRows_SAD_Click;
            // 
            // buttonAddOrders_SAD
            // 
            buttonAddOrders_SAD.BackColor = SystemColors.Info;
            buttonAddOrders_SAD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddOrders_SAD.FlatStyle = FlatStyle.Flat;
            buttonAddOrders_SAD.Image = (Image)resources.GetObject("buttonAddOrders_SAD.Image");
            buttonAddOrders_SAD.Location = new Point(20, 38);
            buttonAddOrders_SAD.Name = "buttonAddOrders_SAD";
            buttonAddOrders_SAD.Size = new Size(49, 51);
            buttonAddOrders_SAD.TabIndex = 0;
            buttonAddOrders_SAD.UseVisualStyleBackColor = false;
            buttonAddOrders_SAD.Click += buttonAdd_SAD_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(buttonDownloadOrders_SAD);
            groupBox2.Controls.Add(buttonOpenOrder_SAD);
            groupBox2.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(7, 0);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(263, 100);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сохранить/Выгрузить";
            // 
            // buttonDownloadOrders_SAD
            // 
            buttonDownloadOrders_SAD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDownloadOrders_SAD.FlatStyle = FlatStyle.Flat;
            buttonDownloadOrders_SAD.Image = (Image)resources.GetObject("buttonDownloadOrders_SAD.Image");
            buttonDownloadOrders_SAD.Location = new Point(43, 35);
            buttonDownloadOrders_SAD.Name = "buttonDownloadOrders_SAD";
            buttonDownloadOrders_SAD.Size = new Size(56, 54);
            buttonDownloadOrders_SAD.TabIndex = 0;
            buttonDownloadOrders_SAD.UseVisualStyleBackColor = true;
            buttonDownloadOrders_SAD.Click += buttonDownload_SAD_Click;
            // 
            // buttonOpenOrder_SAD
            // 
            buttonOpenOrder_SAD.BackColor = SystemColors.Info;
            buttonOpenOrder_SAD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenOrder_SAD.FlatStyle = FlatStyle.Flat;
            buttonOpenOrder_SAD.Image = (Image)resources.GetObject("buttonOpenOrder_SAD.Image");
            buttonOpenOrder_SAD.Location = new Point(104, 35);
            buttonOpenOrder_SAD.Name = "buttonOpenOrder_SAD";
            buttonOpenOrder_SAD.Size = new Size(56, 54);
            buttonOpenOrder_SAD.TabIndex = 0;
            buttonOpenOrder_SAD.UseVisualStyleBackColor = false;
            buttonOpenOrder_SAD.Click += buttonOpen_SAD_Click;
            // 
            // dataGridViewTableOrders_SAD
            // 
            dataGridViewTableOrders_SAD.AllowUserToAddRows = false;
            dataGridViewTableOrders_SAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTableOrders_SAD.BackgroundColor = SystemColors.Info;
            dataGridViewTableOrders_SAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTableOrders_SAD.Columns.AddRange(new DataGridViewColumn[] { NumberOrder_SAD, DateDone_SAD, PriceOrder_SAD, Column1, NameOrder_SAD });
            dataGridViewTableOrders_SAD.Location = new Point(5, 105);
            dataGridViewTableOrders_SAD.Name = "dataGridViewTableOrders_SAD";
            dataGridViewTableOrders_SAD.RowHeadersVisible = false;
            dataGridViewTableOrders_SAD.RowHeadersWidth = 51;
            dataGridViewTableOrders_SAD.RowTemplate.Height = 24;
            dataGridViewTableOrders_SAD.Size = new Size(1431, 685);
            dataGridViewTableOrders_SAD.TabIndex = 1;
            dataGridViewTableOrders_SAD.RowPrePaint += dataGridViewTable_SAD_RowPrePaint;
            // 
            // NumberOrder_SAD
            // 
            NumberOrder_SAD.HeaderText = "Номер филиала";
            NumberOrder_SAD.MinimumWidth = 6;
            NumberOrder_SAD.Name = "NumberOrder_SAD";
            NumberOrder_SAD.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DateDone_SAD
            // 
            DateDone_SAD.HeaderText = "Название магазина";
            DateDone_SAD.MinimumWidth = 6;
            DateDone_SAD.Name = "DateDone_SAD";
            DateDone_SAD.Resizable = DataGridViewTriState.True;
            DateDone_SAD.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceOrder_SAD
            // 
            PriceOrder_SAD.HeaderText = "Адрес";
            PriceOrder_SAD.MinimumWidth = 6;
            PriceOrder_SAD.Name = "PriceOrder_SAD";
            PriceOrder_SAD.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ежемесячная выручка";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NameOrder_SAD
            // 
            NameOrder_SAD.HeaderText = "Проходимость людей/ч";
            NameOrder_SAD.MinimumWidth = 6;
            NameOrder_SAD.Name = "NameOrder_SAD";
            NameOrder_SAD.Resizable = DataGridViewTriState.True;
            NameOrder_SAD.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonFilter_SAD
            // 
            buttonFilter_SAD.Enabled = false;
            buttonFilter_SAD.Font = new Font("Sitka Banner", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonFilter_SAD.Location = new Point(1241, 22);
            buttonFilter_SAD.Name = "buttonFilter_SAD";
            buttonFilter_SAD.Size = new Size(139, 77);
            buttonFilter_SAD.TabIndex = 0;
            buttonFilter_SAD.Text = "Отфильтровать";
            buttonFilter_SAD.UseVisualStyleBackColor = true;
            buttonFilter_SAD.Click += buttonFilter_SAD_Click;
            // 
            // tabControl_SAD
            // 
            tabControl_SAD.Controls.Add(tabPageOrderData_SAD);
            tabControl_SAD.Controls.Add(tabPageStats_SAD);
            tabControl_SAD.Dock = DockStyle.Fill;
            tabControl_SAD.Font = new Font("Sitka Banner", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            tabControl_SAD.Location = new Point(0, 28);
            tabControl_SAD.Margin = new Padding(4, 5, 4, 5);
            tabControl_SAD.Name = "tabControl_SAD";
            tabControl_SAD.SelectedIndex = 0;
            tabControl_SAD.Size = new Size(1457, 924);
            tabControl_SAD.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 28);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 924);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // FormWork
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 952);
            Controls.Add(splitter1);
            Controls.Add(tabControl_SAD);
            Controls.Add(menuStrip_SAD);
            MaximumSize = new Size(1475, 999);
            MinimizeBox = false;
            MinimumSize = new Size(1475, 999);
            Name = "FormWork";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рабочая среда by Sychev®";
            menuStrip_SAD.ResumeLayout(false);
            menuStrip_SAD.PerformLayout();
            tabPageStats_SAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabPageOrderData_SAD.ResumeLayout(false);
            groupBoxMovesOrders_SAD.ResumeLayout(false);
            groupBoxMovesOrders_SAD.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_SAD).EndInit();
            tabControl_SAD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SAD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SAD;
        private System.Windows.Forms.MenuStrip menuStrip_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SAD;
        private System.Windows.Forms.TabPage tabPageStats_SAD;
        private System.Windows.Forms.TabPage tabPageOrderData_SAD;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_SAD;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_SAD;
        private System.Windows.Forms.Button buttonOpenOrder_SAD;
        private System.Windows.Forms.Button buttonAddOrders_SAD;
        private System.Windows.Forms.Button buttonDownloadOrders_SAD;
        private System.Windows.Forms.TabControl tabControl_SAD;
        private System.Windows.Forms.Button buttonFilter_SAD;
        private System.Windows.Forms.TextBox textBoxSearch_SAD;
        private System.Windows.Forms.TextBox textBoxFilter_SAD;
        private System.Windows.Forms.Button buttonRemoveRows_SAD;
        private System.Windows.Forms.ComboBox comboBoxColsNames_SAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGetStats_SAD;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem_SAD;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_SAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem поддержкаToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private DataGridViewTextBoxColumn NumberOrder_SAD;
        private DataGridViewTextBoxColumn DateDone_SAD;
        private DataGridViewTextBoxColumn PriceOrder_SAD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn NameOrder_SAD;
    }
}

