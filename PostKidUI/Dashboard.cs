namespace PostKidUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            // validate API URL


            try
            {
                systemStatus.Text = "Processing...";

                // simulate a call delay
                await Task.Delay(2000);

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {

                resultsText.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultsText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
