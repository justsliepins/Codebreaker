using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Codebreaker
{
    public partial class Form1 : Form
    {
        private List<string> pinCodes;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            LoadPinCodes();
        }

        private void LoadPinCodes()
        {
            using (StreamReader r = new StreamReader("C:/Users/justs/OneDrive/Documents/projects/Codebreaker/Codebreaker/pin_codes.json"))
            {
                string json = r.ReadToEnd();
                var pinCodesData = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
                pinCodes = pinCodesData["PinCodes"];
                
            }
        }

        private void nextPin_Click(object sender, EventArgs e)
        {
            string currentCode = currentPin.Text;
            currentCode = pinCodes[currentIndex];
            currentPin.Text = pinCodes[currentIndex];
            listBox.Items.Add(currentCode);
            currentIndex++;
        }
    }
}