namespace turing
{
    partial class Author
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
            this.myname = new System.Windows.Forms.Label();
            this.mymail = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // myname
            // 
            this.myname.AutoSize = true;
            this.myname.Location = new System.Drawing.Point(8, 23);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(370, 24);
            this.myname.TabIndex = 0;
            this.myname.Text = "Автор: Заводов Андрей Павлович";
            // 
            // mymail
            // 
            this.mymail.AutoSize = true;
            this.mymail.Location = new System.Drawing.Point(40, 66);
            this.mymail.Name = "mymail";
            this.mymail.Size = new System.Drawing.Size(298, 24);
            this.mymail.TabIndex = 1;
            this.mymail.Text = "@ - andrey0398@gmail.com";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(53, 107);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(274, 24);
            this.link.TabIndex = 2;
            this.link.TabStop = true;
            this.link.Text = "https://vk.com/zavodov";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.link);
            this.Controls.Add(this.mymail);
            this.Controls.Add(this.myname);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myname;
        private System.Windows.Forms.Label mymail;
        private System.Windows.Forms.LinkLabel link;
    }
}