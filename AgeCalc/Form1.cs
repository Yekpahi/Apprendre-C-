namespace AgeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yearID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 uyd;

            Int32.TryParse(this.yearID.Text, out uyd);

            Int32 age;
            Int32 current_year;
            current_year = DateTime.Now.Year;
            age = current_year - uyd;
            if (age==1)
            {

                this.lb1.Text = age.ToString() + " an";
            } else
            {
                this.lb1.Text = age.ToString() + " ans";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }
    }
}