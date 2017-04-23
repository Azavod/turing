namespace turing
{
    partial class Instructions
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
            this.instruct = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // instruct
            // 
            this.instruct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instruct.FormattingEnabled = true;
            this.instruct.ItemHeight = 15;
            this.instruct.Items.AddRange(new object[] {
            " ● На вход подается лента (слово).  ",
            "",
            " ● Потенциально лента бесконечна.",
            "",
            " ● Изначально машина находится в начальном состоянии q1, ",
            " обозревает некоторый символ, на который указывает головка. ",
            "",
            " ● Программа машины задается в виде матрицы. ",
            "",
            " ● Программа завершается при переходе в состояние q0.",
            " ",
            " ● Формат команды :",
            "\t1) Cостояние, в которое нужно перейти ",
            "\t\t● [Q<номер>]",
            "\t\t● [q<номер>]",
            "\t2) Замена на символ [любой символ из алфавита]",
            "\t3) Как нужно изменить положение головки :",
            "\t\t● [R, r, >] - передвинуть вправо",
            "\t\t● [L, l, <] - передвинуть влево",
            "\t\t● [С, с, .] - не передвигать",
            " Примеры можно уведеть в пункте меню \"Программы\"",
            "",
            " ● При вводе программы и значений ячеек ленты, ",
            " они сразу проверяются на корректность. Поэтому, ",
            " если вам не удается изменить значение, значит вы ",
            " делаете что-то не правильно. "});
            this.instruct.Location = new System.Drawing.Point(13, 14);
            this.instruct.Name = "instruct";
            this.instruct.Size = new System.Drawing.Size(428, 304);
            this.instruct.TabIndex = 0;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.instruct);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox instruct;
    }
}