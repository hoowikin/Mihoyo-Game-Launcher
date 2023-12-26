using System.Diagnostics;
using System.Security.Principal;

namespace Mihoyo启动器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForAdmin();
        }

        private void CheckForAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("请以管理员身份运行此应用程序", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "原神")
            {
                label1.Text = "原神";
                string selectedImage = listBox1.SelectedItem.ToString();
                pictureBox1.Image = Image.FromFile(@"C:\Users\h\OneDrive\图片\d48345-64-318297-0.png");
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (listBox1.SelectedItem.ToString() == "崩坏3")
            {
                label1.Text = "崩坏3";
                pictureBox1.Image = Image.FromFile(@"C:\Users\h\OneDrive\图片\9aec73742bef35b9d89a18d21ba203cd_5392792453291537305.png");
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            if (listBox1.SelectedItem.ToString() == "崩坏——星穹铁道")
            {
                label1.Text = "崩坏——星穹铁道";
                pictureBox1.Image = Image.FromFile(@"C:\Users\h\OneDrive\图片\b2002846258747f29e6e28f569f66803_8575910149826187250.png");
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立一个变量，用于存储在ListBox中选中的项目
            string selectedItem;
            if (listBox1.SelectedItem == null)
            {
                selectedItem = "1";
            }
            else
            {
                selectedItem = listBox1.SelectedItem.ToString();
            }
            //根据selectedItem的内容执行不同的操作
            switch (selectedItem)
            {
                case "原神":
                    //定义一个变量startInfo
                    var startInfoGenshin = new ProcessStartInfo(@"C:\Program Files\Genshin Impact\Genshin Impact Game\YuanShen.exe")
                    {
                        Verb = "runas"
                    };
                    Process.Start(startInfoGenshin);
                    break;
                case "崩坏3":
                    var startInfoHonkai3 = new ProcessStartInfo(@"C:\Program Files\Honkai Impact 3\Games\BH3.exe")
                    {
                        Verb = "runas"
                    };
                    Process.Start(startInfoHonkai3);
                    break;
                case "崩坏——星穹铁道":
                    var startInfoHonkaiStarRail = new ProcessStartInfo(@"C:\Program Files\Star Rail\Game\StarRail.exe")
                    {
                        Verb = "runas"
                    };
                    Process.Start(startInfoHonkaiStarRail);
                    break;
                default:
                    MessageBox.Show("请选择您要游玩的游戏", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
