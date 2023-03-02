namespace Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            this.colorDiaCID.ShowDialog();
            this.BackColor = this.colorDiaCID.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.folder1.ShowDialog();
            String fn;
            fn = this.folder1.SelectedPath;
             if (fn == "")
            {
                this.chemin.Text = "Aucun fichier n'a été selectionné";

                MessageBox.Show("Aucun fichier n'a été selectionné");
            } else
            {
                this.chemin.Text = "Chemin : " + fn;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void myfont_Click(object sender, EventArgs e)
        {
            this.font1.ShowDialog();
            this.mytext.Font = this.font1.Font;
            this.textSample.Font = this.font1.Font;
        }

        //Change font color
        private void fontcolor_Click(object sender, EventArgs e)
        {
            this.fontcolorID.ShowDialog();
            this.mytext.ForeColor = this.fontcolorID.Color;
        }
    }
}