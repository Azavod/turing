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
            this.alphabet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progGrid = new System.Windows.Forms.DataGridView();
            this.lenta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oneStep = new System.Windows.Forms.Button();
            this.allCmd = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numCmd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.progGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // alphabet
            // 
            this.alphabet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphabet.Location = new System.Drawing.Point(86, 144);
            this.alphabet.Name = "alphabet";
            this.alphabet.Size = new System.Drawing.Size(438, 23);
            this.alphabet.TabIndex = 0;
            this.alphabet.Text = "_012";
            this.alphabet.TextChanged += new System.EventHandler(this.alphabet_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 144);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.progGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.progGrid.ColumnHeadersHeight = 25;
            this.progGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.progGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.progGrid.Location = new System.Drawing.Point(9, 172);
            this.progGrid.Margin = new System.Windows.Forms.Padding(2);
            this.progGrid.MultiSelect = false;
            this.progGrid.Name = "progGrid";
            this.progGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.progGrid.RowHeadersWidth = 25;
            this.progGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.progGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.progGrid.Size = new System.Drawing.Size(296, 229);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.lenta.Location = new System.Drawing.Point(36, 61);
            this.lenta.Margin = new System.Windows.Forms.Padding(2);
            this.lenta.MultiSelect = false;
            this.lenta.Name = "lenta";
            this.lenta.RowHeadersVisible = false;
            this.lenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.lenta.Size = new System.Drawing.Size(462, 78);
            this.lenta.TabIndex = 3;
            this.lenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lenta_CellValueChanged);
            this.lenta.Resize += new System.EventHandler(this.lenta_Resize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 61);
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
            this.button2.Location = new System.Drawing.Point(501, 61);
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
            this.oneStep.Location = new System.Drawing.Point(9, 11);
            this.oneStep.Margin = new System.Windows.Forms.Padding(2);
            this.oneStep.Name = "oneStep";
            this.oneStep.Size = new System.Drawing.Size(71, 31);
            this.oneStep.TabIndex = 6;
            this.oneStep.Text = "1 cmd";
            this.oneStep.UseVisualStyleBackColor = true;
            this.oneStep.Click += new System.EventHandler(this.oneStep_Click);
            // 
            // allCmd
            // 
            this.allCmd.Location = new System.Drawing.Point(86, 11);
            this.allCmd.Margin = new System.Windows.Forms.Padding(2);
            this.allCmd.Name = "allCmd";
            this.allCmd.Size = new System.Drawing.Size(141, 31);
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
            this.log.Location = new System.Drawing.Point(309, 201);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.log.Size = new System.Drawing.Size(215, 169);
            this.log.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(396, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Log";
            // 
            // numCmd
            // 
            this.numCmd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCmd.Location = new System.Drawing.Point(332, 11);
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
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(236, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Команда:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(432, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "/ 10 000";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(536, 408);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.allCmd);
            this.Controls.Add(this.oneStep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lenta);
            this.Controls.Add(this.progGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alphabet);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(552, 447);
            this.Name = "Form1";
            this.Text = "Turing by Zavodov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmd)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

