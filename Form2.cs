using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Appli
{
    public partial class Form2 : Form
    {
        string current_dir;
        string setting_dir;
        string setting_file;
        StreamReader sr;
        StreamWriter sw;
        string temp_str1;
        string temp_str2;

        public Form2()
        {
            InitializeComponent();
            current_dir = Directory.GetCurrentDirectory();
            setting_dir = current_dir + "\\setting";
            setting_file = "setting.csv";
            if (!Directory.Exists(setting_dir))
                Directory.CreateDirectory(setting_dir);
            temp_str1 = "";
            temp_str2 = "";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            read_file();
        }

        private void decision_button_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            // 設定ファイルに保存
            update_file();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Trace.WriteLine("str1: " + temp_str1);
            //System.Diagnostics.Trace.WriteLine("str2: " + temp_str2);
            //System.Diagnostics.Trace.WriteLine("textbox1: " + textBox1.Text);
            //System.Diagnostics.Trace.WriteLine("textbox2: " + textBox2.Text);

            if(textBox1.ReadOnly && textBox2.ReadOnly)
            {
                this.Hide();
            }
            else
            {
                if (temp_str1 != textBox1.Text && temp_str2 != textBox2.Text)
                {
                    DialogResult result = MessageBox.Show("更新されています。保存しますか？",
                        "Appli",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        textBox1.ReadOnly = true;
                        textBox2.ReadOnly = true;
                        // 設定ファイルに保存
                        update_file();
                        this.Hide();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Hide();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // キャンセル
                    }

                }
                else
                {
                    this.Hide();
                }
    
            }

        }

        private void reference_button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定
            ofd.Filter = "すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する(デフォルト:true)
            //ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する(デフォルト:true)
            //ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox1.ReadOnly = false;
            }
        }

        private void reference_button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定
            ofd.Filter = "すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する(デフォルト:true)
            //ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する(デフォルト:true)
            //ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
                textBox2.ReadOnly = false;
            }            
        }

        private void read_file()
        {
            // ファイルが存在すれば読み込み
            if (File.Exists(setting_dir + "\\" + setting_file))
            {
                // 読み込み
                sr = new StreamReader(setting_dir + "\\" + "setting.csv", Encoding.GetEncoding("Shift_JIS"));
                // Setting_fileの内容
                // 1行目：ファイルパス、 2行目：APLパス
                temp_str1 = sr.ReadLine();
                temp_str2 = sr.ReadLine();

                if (temp_str1 != "")
                {
                    textBox1.Text = temp_str1;
                    textBox1.ReadOnly = true;
                }

                if (temp_str2 != "")
                {
                    textBox2.Text = temp_str2;
                    textBox2.ReadOnly = true;
                }                

                //System.Diagnostics.Trace.WriteLine("str1: " + temp_str1);
                //System.Diagnostics.Trace.WriteLine("str2: " + temp_str2);

                sr.Close();
            }

        }

        private void update_file()
        {
            // 設定ファイルが存在すれば一旦削除
            if (File.Exists(setting_dir + "\\" + setting_file))
            {
                File.Delete(setting_dir + "\\" + setting_file);
            }
            
            sw = new StreamWriter(setting_dir + "\\" + setting_file, false, Encoding.GetEncoding("Shift_JIS"));
            
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.Close();
            read_file();
        }

        private void cancel()
        {
            textBox1.Text = temp_str1;
            textBox2.Text = temp_str2;
        }
    }
}
