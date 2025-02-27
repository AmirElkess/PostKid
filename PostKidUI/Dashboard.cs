using System.ComponentModel.Design;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PostKidLibrary;

namespace PostKidUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();
            httpVerbSelection.SelectedIndex = 0;
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
            if (!api.isValidUrl(apiText.Text))
            {
                systemStatus.Text = "Invalid URL";
                resultsText.Text = "";
                return;
            }

            HttpAction action;
            if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
            {
                systemStatus.Text = "Invalid HTTP Action";
                return;
            }


            try
            {
                systemStatus.Text = "Calling API...";

                // setting a beautified JSON to the text box
                string response = await api.callApiAsync(apiText.Text, bodyText.Text, action);
                JToken parsedJson = JToken.Parse(response);
                var beautified = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
                resultsText.Text = beautified;

                callData.SelectedTab = outputTab;
                outputTab.Focus();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
