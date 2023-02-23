namespace AgeCalc
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
            this.yearID = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearID
            // 
            this.yearID.Location = new System.Drawing.Point(246, 138);
            this.yearID.Name = "yearID";
            this.yearID.Size = new System.Drawing.Size(237, 23);
            this.yearID.TabIndex = 0;
            this.yearID.TextChanged += new System.EventHandler(this.yearID_TextChanged);
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(246, 167);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(237, 23);
            this.valider.TabIndex = 1;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(101, 21);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(635, 66);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Votre âge s\'affichera ici";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.yearID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox yearID;
        private Button valider;
        private Label lb1;
    }
}