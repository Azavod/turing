namespace turing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.alphabet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progGrid = new System.Windows.Forms.DataGridView();
            this.lenta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oneStep = new System.Windows.Forms.Button();
            this.allCmd = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.numCmd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearLog = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тест1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тест2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тест3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тест4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.AddQ = new System.Windows.Forms.Button();
            this.SubQ = new System.Windows.Forms.Button();
            this.saveWrd = new System.Windows.Forms.Button();
            this.loadWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.progGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alphabet
            // 
            this.alphabet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphabet.Location = new System.Drawing.Point(86, 156);
            this.alphabet.Name = "alphabet";
            this.alphabet.Size = new System.Drawing.Size(181, 23);
            this.alphabet.TabIndex = 0;
            this.alphabet.Text = "_012";
            this.alphabet.TextChanged += new System.EventHandler(this.alphabet_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Алфавит :";
            // 
            // progGrid
            // 
            this.progGrid.AllowUserToAddRows = false;
            this.progGrid.AllowUserToDeleteRows = false;
            this.progGrid.AllowUserToResizeColumns = false;
            this.progGrid.AllowUserToResizeRows = false;
            this.progGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.progGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.progGrid.ColumnHeadersHeight = 40;
            this.progGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.progGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.progGrid.Location = new System.Drawing.Point(9, 184);
            this.progGrid.Margin = new System.Windows.Forms.Padding(2);
            this.progGrid.MultiSelect = false;
            this.progGrid.Name = "progGrid";
            this.progGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.progGrid.RowHeadersWidth = 50;
            this.progGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.progGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.progGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.progGrid.ShowEditingIcon = false;
            this.progGrid.Size = new System.Drawing.Size(344, 266);
            this.progGrid.TabIndex = 2;
            this.progGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.progGrid_CellValueChanged);
            this.progGrid.Resize += new System.EventHandler(this.progGrid_Resize);
            // 
            // lenta
            // 
            this.lenta.AllowUserToAddRows = false;
            this.lenta.AllowUserToDeleteRows = false;
            this.lenta.AllowUserToResizeColumns = false;
            this.lenta.AllowUserToResizeRows = false;
            this.lenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lenta.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.lenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lenta.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.lenta.Location = new System.Drawing.Point(49, 70);
            this.lenta.Margin = new System.Windows.Forms.Padding(2);
            this.lenta.MultiSelect = false;
            this.lenta.Name = "lenta";
            this.lenta.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lenta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.lenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.lenta.Size = new System.Drawing.Size(483, 78);
            this.lenta.TabIndex = 3;
            this.lenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lenta_CellValueChanged);
            this.lenta.Resize += new System.EventHandler(this.lenta_Resize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(536, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 78);
            this.button2.TabIndex = 5;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oneStep
            // 
            this.oneStep.Location = new System.Drawing.Point(9, 27);
            this.oneStep.Margin = new System.Windows.Forms.Padding(2);
            this.oneStep.Name = "oneStep";
            this.oneStep.Size = new System.Drawing.Size(67, 41);
            this.oneStep.TabIndex = 6;
            this.oneStep.Text = "1 cmd";
            this.oneStep.UseVisualStyleBackColor = true;
            this.oneStep.Click += new System.EventHandler(this.oneStep_Click);
            // 
            // allCmd
            // 
            this.allCmd.Location = new System.Drawing.Point(80, 27);
            this.allCmd.Margin = new System.Windows.Forms.Padding(2);
            this.allCmd.Name = "allCmd";
            this.allCmd.Size = new System.Drawing.Size(86, 41);
            this.allCmd.TabIndex = 7;
            this.allCmd.Text = "выполнить";
            this.allCmd.UseVisualStyleBackColor = true;
            this.allCmd.Click += new System.EventHandler(this.allCmd_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.FormattingEnabled = true;
            this.log.ItemHeight = 15;
            this.log.Location = new System.Drawing.Point(358, 156);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.log.Size = new System.Drawing.Size(215, 259);
            this.log.TabIndex = 9;
            // 
            // numCmd
            // 
            this.numCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCmd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCmd.Location = new System.Drawing.Point(385, 32);
            this.numCmd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCmd.Name = "numCmd";
            this.numCmd.Size = new System.Drawing.Size(92, 26);
            this.numCmd.TabIndex = 11;
            this.numCmd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(289, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Команда:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(483, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "/ 10 000";
            // 
            // clearLog
            // 
            this.clearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLog.Location = new System.Drawing.Point(358, 420);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(215, 29);
            this.clearLog.TabIndex = 14;
            this.clearLog.Text = "очистить";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.программыToolStripMenuItem,
            this.инструкцияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem1,
            this.очиститьLogToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Save word";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem1
            // 
            this.загрузитьToolStripMenuItem1.Name = "загрузитьToolStripMenuItem1";
            this.загрузитьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem1.Text = "Load word";
            this.загрузитьToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьToolStripMenuItem1_Click);
            // 
            // очиститьLogToolStripMenuItem
            // 
            this.очиститьLogToolStripMenuItem.Name = "очиститьLogToolStripMenuItem";
            this.очиститьLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.очиститьLogToolStripMenuItem.Text = "Очистить Log";
            this.очиститьLogToolStripMenuItem.Click += new System.EventHandler(this.очиститьLogToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветФонаToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона ...";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт ...";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // программыToolStripMenuItem
            // 
            this.программыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тест1ToolStripMenuItem,
            this.тест2ToolStripMenuItem,
            this.тест3ToolStripMenuItem,
            this.тест4ToolStripMenuItem});
            this.программыToolStripMenuItem.Name = "программыToolStripMenuItem";
            this.программыToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.программыToolStripMenuItem.Text = "Программы";
            // 
            // тест1ToolStripMenuItem
            // 
            this.тест1ToolStripMenuItem.Name = "тест1ToolStripMenuItem";
            this.тест1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.тест1ToolStripMenuItem.Text = "Тест 1";
            this.тест1ToolStripMenuItem.Click += new System.EventHandler(this.тест1ToolStripMenuItem_Click);
            // 
            // тест2ToolStripMenuItem
            // 
            this.тест2ToolStripMenuItem.Name = "тест2ToolStripMenuItem";
            this.тест2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.тест2ToolStripMenuItem.Text = "Тест 2";
            this.тест2ToolStripMenuItem.Click += new System.EventHandler(this.тест2ToolStripMenuItem_Click);
            // 
            // тест3ToolStripMenuItem
            // 
            this.тест3ToolStripMenuItem.Name = "тест3ToolStripMenuItem";
            this.тест3ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.тест3ToolStripMenuItem.Text = "Тест 3";
            this.тест3ToolStripMenuItem.Click += new System.EventHandler(this.тест3ToolStripMenuItem_Click);
            // 
            // тест4ToolStripMenuItem
            // 
            this.тест4ToolStripMenuItem.Name = "тест4ToolStripMenuItem";
            this.тест4ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.тест4ToolStripMenuItem.Text = "Тест 4";
            this.тест4ToolStripMenuItem.Click += new System.EventHandler(this.тест4ToolStripMenuItem_Click);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструкцииToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.инструкцияToolStripMenuItem.Text = "О программе";
            // 
            // инструкцииToolStripMenuItem
            // 
            this.инструкцииToolStripMenuItem.Name = "инструкцииToolStripMenuItem";
            this.инструкцииToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.инструкцииToolStripMenuItem.Text = "Инструкции";
            this.инструкцииToolStripMenuItem.Click += new System.EventHandler(this.инструкцииToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // AddQ
            // 
            this.AddQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddQ.Location = new System.Drawing.Point(271, 156);
            this.AddQ.Name = "AddQ";
            this.AddQ.Size = new System.Drawing.Size(40, 23);
            this.AddQ.TabIndex = 16;
            this.AddQ.Text = "+Q";
            this.AddQ.UseVisualStyleBackColor = true;
            this.AddQ.Click += new System.EventHandler(this.AddQ_Click);
            // 
            // SubQ
            // 
            this.SubQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubQ.Location = new System.Drawing.Point(313, 156);
            this.SubQ.Name = "SubQ";
            this.SubQ.Size = new System.Drawing.Size(40, 23);
            this.SubQ.TabIndex = 17;
            this.SubQ.Text = "-Q";
            this.SubQ.UseVisualStyleBackColor = true;
            this.SubQ.Click += new System.EventHandler(this.SubQ_Click);
            // 
            // saveWrd
            // 
            this.saveWrd.Location = new System.Drawing.Point(171, 47);
            this.saveWrd.Name = "saveWrd";
            this.saveWrd.Size = new System.Drawing.Size(106, 21);
            this.saveWrd.TabIndex = 18;
            this.saveWrd.Text = "Save word";
            this.saveWrd.UseVisualStyleBackColor = true;
            this.saveWrd.Click += new System.EventHandler(this.saveWrd_Click);
            // 
            // loadWord
            // 
            this.loadWord.Location = new System.Drawing.Point(171, 27);
            this.loadWord.Name = "loadWord";
            this.loadWord.Size = new System.Drawing.Size(106, 21);
            this.loadWord.TabIndex = 19;
            this.loadWord.Text = "Load word";
            this.loadWord.UseVisualStyleBackColor = true;
            this.loadWord.Click += new System.EventHandler(this.loadWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.loadWord);
            this.Controls.Add(this.saveWrd);
            this.Controls.Add(this.SubQ);
            this.Controls.Add(this.AddQ);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCmd);
            this.Controls.Add(this.log);
            this.Controls.Add(this.allCmd);
            this.Controls.Add(this.oneStep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lenta);
            this.Controls.Add(this.progGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alphabet);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turing machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alphabet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView progGrid;
        private System.Windows.Forms.DataGridView lenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button oneStep;
        private System.Windows.Forms.Button allCmd;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.NumericUpDown numCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тест1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тест2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тест3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тест4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button AddQ;
        private System.Windows.Forms.Button SubQ;
        private System.Windows.Forms.Button saveWrd;
        private System.Windows.Forms.Button loadWord;
    }
}

