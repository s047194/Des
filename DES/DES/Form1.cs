using DES.Classes;
using DES.CLasses;
using System.Security.Cryptography;
using System.Text;

namespace DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private byte[] initializationVector;
        Cipher cipher = new Cipher();
        Files file = new Files();
        private void UpdateIVTextBox(byte[] iv)
        {
            IVtxt.Text = BitConverter.ToString(iv).Replace("-", "");
        }
        private void Encryption()
        {
            initializationVector = IV();
            UpdateIVTextBox(initializationVector);
            string selectedMode = comboBoxMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "ECB":
                    string ECB = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.ECB);
                    txtBoxResult.Text = ECB;
                    break;
                case "CBC":
                    string CBC = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.CBC);
                    txtBoxResult.Text = CBC;
                    break;
                case "CFB":
                    string CFB = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.CFB);
                    txtBoxResult.Text = CFB;
                    break;
                default:
                    MessageBox.Show("Choose a mode");
                    break;

            }

        }
        private void Decryption(string encrypted)
        {
            string selectedMode = comboBoxMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "ECB":
                    string ECB = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.ECB);
                    txtBoxResult.Text = ECB;
                    break;
                case "CBC":
                    string CBC = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.CBC);
                    txtBoxResult.Text = CBC;
                    break;
                case "CFB":
                    string CFB = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.CFB);
                    txtBoxResult.Text = CFB;
                    break;
                default:
                    MessageBox.Show("Choose a mode");
                    break;
            }
            UpdateIVTextBox(initializationVector);
        }

        private bool chechTextBox()
        {
            if (txtBoxText.Text == "")
            {
                MessageBox.Show("Input text");
                return false;
            }
            if (txtBoxKey.Text.Length != 8)
            {
                MessageBox.Show("Input a key that is 8 symbols");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool check = chechTextBox();
            if (check)
            {
                string value = comboBox.SelectedItem.ToString();
                switch (value)
                {
                    case "Sifravimas":
                        Encryption();
                        break;
                    case "Desifravimas":
                        Decryption(txtBoxResult.Text);
                        break;
                    default:
                        MessageBox.Show("Choose Cypher/Decypher");
                        break;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            file.saveTextFile(txtBoxResult.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxText.Text = file.openTextFile();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private byte[] IV()
        {
            byte[] iv = new byte[8];
            new Random().NextBytes(iv);
            return iv;
        }
    }
}
