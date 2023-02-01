using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Codebreaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nextPin_Click(object sender, EventArgs e)
        {
            string currentCode = current_pin.Text;
            listBox.Items.Add(currentCode);
        }
    }
}