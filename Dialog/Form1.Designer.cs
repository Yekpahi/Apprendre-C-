namespace Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butt1 = new System.Windows.Forms.Button();
            this.colorDiaCID = new System.Windows.Forms.ColorDialog();
            this.folder1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.chemin = new System.Windows.Forms.Label();
            this.font1 = new System.Windows.Forms.FontDialog();
            this.textSample = new System.Windows.Forms.Label();
            this.myfont = new System.Windows.Forms.Button();
            this.mytext = new System.Windows.Forms.Label();
            this.fontcolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontcolorID = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img = new System.Windows.Forms.PictureBox();
            this.imgCharge = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.saveAs = new System.Windows.Forms.SaveFileDialog();
            this.chemin2 = new System.Windows.Forms.Label();
            this.savebutt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // butt1
            // 
            this.butt1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butt1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt1.Location = new System.Drawing.Point(267, 12);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(176, 23);
            this.butt1.TabIndex = 0;
            this.butt1.Text = "Change background color";
            this.butt1.UseVisualStyleBackColor = false;
            this.butt1.Click += new System.EventHandler(this.butt1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Charger un fichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chemin
            // 
            this.chemin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chemin.Location = new System.Drawing.Point(230, 265);
            this.chemin.Name = "chemin";
            this.chemin.Padding = new System.Windows.Forms.Padding(5);
            this.chemin.Size = new System.Drawing.Size(307, 33);
            this.chemin.TabIndex = 2;
            this.chemin.Text = "Chemin :";
            // 
            // textSample
            // 
            this.textSample.AutoSize = true;
            this.textSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSample.Location = new System.Drawing.Point(361, 156);
            this.textSample.Name = "textSample";
            this.textSample.Padding = new System.Windows.Forms.Padding(5);
            this.textSample.Size = new System.Drawing.Size(82, 27);
            this.textSample.TabIndex = 4;
            this.textSample.Text = "Sample Text";
            this.textSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myfont
            // 
            this.myfont.Location = new System.Drawing.Point(219, 157);
            this.myfont.Name = "myfont";
            this.myfont.Size = new System.Drawing.Size(136, 23);
            this.myfont.TabIndex = 3;
            this.myfont.Text = "Fonts";
            this.myfont.UseVisualStyleBackColor = true;
            this.myfont.Click += new System.EventHandler(this.myfont_Click);
            // 
            // mytext
            // 
            this.mytext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mytext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mytext.Location = new System.Drawing.Point(12, 21);
            this.mytext.Name = "mytext";
            this.mytext.Padding = new System.Windows.Forms.Padding(5);
            this.mytext.Size = new System.Drawing.Size(419, 94);
            this.mytext.TabIndex = 5;
            this.mytext.Text = resources.GetString("mytext.Text");
            this.mytext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mytext.Click += new System.EventHandler(this.label2_Click);
            // 
            // fontcolor
            // 
            this.fontcolor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fontcolor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.fontcolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fontcolor.Location = new System.Drawing.Point(12, 157);
            this.fontcolor.Name = "fontcolor";
            this.fontcolor.Size = new System.Drawing.Size(136, 23);
            this.fontcolor.TabIndex = 6;
            this.fontcolor.Text = "Changer la couleur";
            this.fontcolor.UseVisualStyleBackColor = false;
            this.fontcolor.Click += new System.EventHandler(this.fontcolor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mytext);
            this.panel1.Controls.Add(this.textSample);
            this.panel1.Controls.Add(this.fontcolor);
            this.panel1.Controls.Add(this.myfont);
            this.panel1.Location = new System.Drawing.Point(88, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 209);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.imgCharge);
            this.panel2.Controls.Add(this.img);
            this.panel2.Location = new System.Drawing.Point(567, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 242);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(6, 6);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(514, 236);
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // imgCharge
            // 
            this.imgCharge.Location = new System.Drawing.Point(184, 202);
            this.imgCharge.Name = "imgCharge";
            this.imgCharge.Size = new System.Drawing.Size(136, 31);
            this.imgCharge.TabIndex = 9;
            this.imgCharge.Text = "Charger l\'image";
            this.imgCharge.UseVisualStyleBackColor = true;
            this.imgCharge.Click += new System.EventHandler(this.imgCharge_Click);
            // 
            // file
            // 
            this.file.FileName = "openFileDialog1";
            this.file.Filter = "All Images |*.jpg;*.BMP;*.ico|JPG Files|*.jpg|PNF Files|*.png|Icon Files|*.ico|Al" +
    "l File|*.*";
            // 
            // saveAs
            // 
            this.saveAs.Filter = "Txt File|*.txt";
            this.saveAs.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // chemin2
            // 
            this.chemin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chemin2.Location = new System.Drawing.Point(824, 479);
            this.chemin2.Name = "chemin2";
            this.chemin2.Padding = new System.Windows.Forms.Padding(5);
            this.chemin2.Size = new System.Drawing.Size(263, 31);
            this.chemin2.TabIndex = 10;
            // 
            // savebutt
            // 
            this.savebutt.Location = new System.Drawing.Point(669, 479);
            this.savebutt.Name = "savebutt";
            this.savebutt.Size = new System.Drawing.Size(136, 31);
            this.savebutt.TabIndex = 11;
            this.savebutt.Text = "Save as";
            this.savebutt.UseVisualStyleBackColor = true;
            this.savebutt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 519);
            this.Controls.Add(this.savebutt);
            this.Controls.Add(this.chemin2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chemin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button butt1;
        private ColorDialog colorDiaCID;
        private FolderBrowserDialog folder1;
        private Button button1;
        private Label chemin;
        private FontDialog font1;
        private Label textSample;
        private Button myfont;
        private Label mytext;
        private Button fontcolor;
        private Panel panel1;
        private ColorDialog fontcolorID;
        private Panel panel2;
        private Button imgCharge;
        private PictureBox img;
        private OpenFileDialog file;
        private SaveFileDialog saveAs;
        private Label chemin2;
        private Button savebutt;
    }
}