using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Appli
{
    public partial class Appli : Form
    {
        Form2 setting_form;
        string file_path;

        public Appli()
        {
            InitializeComponent();
            setting_form = new Form2();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            setting_form.Show();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                file_path = setting_form.textBox1.Text;
                //System.Diagnostics.Trace.WriteLine("path: " + file_path);

                File.WriteAllText(file_path, Clipboard.GetText());
                ProcessStartInfo psInfo = new ProcessStartInfo();
                Process.Start(setting_form.textBox2.Text, file_path);
            }
            else
            {
                MessageBox.Show("ERROR：クリップボードが空のようです");
            }

        }
    }
}
