namespace ForLoopApp
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
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(335, 106);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(121, 23);
            this.cbx1.TabIndex = 0;
            // 
            // add
            // 
            this.add.AllowDrop = true;
            this.add.Location = new System.Drawing.Point(335, 247);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(121, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add item\r\n";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbx1;
        private Button add;
    }
}