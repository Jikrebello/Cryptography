using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string alphabet =  @"aAbBcC3dDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsSt0uUvVwWxXyYzZ1234567890";
        readonly string code =      @"ZzYyXxWwVvUu0tSsRrQqPpOoNnMmLlKkJjIiHhGgFfEeDd3CcBbAa0987654321";

        // Encodes the message
        private void button1_Click(object sender, EventArgs e)
        {
            string encodedMessage = "";
            string message = Interaction.InputBox("Enter the message you'd like to encode.", "", "");

            for (int i = 0; i < message.Length; i++)
            {
                string letter = message.Substring(i, 1);
                int letterPosition = alphabet.IndexOf(letter);

                if (letterPosition == -1)
                    encodedMessage += message.Substring(i, 1); // cant find a valid letter to shit in the code, then just add it as is to the message (for stuff like numbers and " " etc.)
                else
                    encodedMessage += code.Substring(letterPosition, 1);

            }
            TxtDisplay.Text += "Your encoded message is: " + encodedMessage + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            string encodedMessage = Interaction.InputBox("Enter the message you'd like to encode.", "", "");

            for (int i = 0; i < encodedMessage.Length; i++)
            {
                string letter = encodedMessage.Substring(i, 1);
                int letterPosition = alphabet.IndexOf(letter);

                if (letterPosition == -1)
                    message += encodedMessage.Substring(i, 1); // cant find a valid letter to shit in the code, then just add it as is to the message (for stuff like numbers and " " etc.)
                else
                    message += code.Substring(letterPosition, 1);

            }
            TxtDisplay.Text += "Your decoded message is: " + message + Environment.NewLine;
        }


    }
}
