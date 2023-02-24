namespace ForLoopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Int32 i;
            for (i = 1; i < 101; i++)
            {
 
                this.cbx1.Items.Add("Item : " + i.ToString());
            }

          
        }
    }
}