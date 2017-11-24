using OriMultiplayerPatcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace OriMultiplayerPatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ori_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            d1.Filter = "Assembly-CSharp (*.dll)|Assembly-CSharp.dll";
            if (d1.ShowDialog() == DialogResult.OK)
            {
                string Filename = d1.FileName;
                if (File.Exists(Path.Combine(Path.GetDirectoryName(Filename), Path.GetFileNameWithoutExtension(Filename) + ".bak")))
                {
                    File.Delete(Path.Combine(Path.GetDirectoryName(Filename), Path.GetFileNameWithoutExtension(Filename) + ".bak"));
                }
                File.Copy(Filename, Path.Combine(Path.GetDirectoryName(Filename), Path.GetFileNameWithoutExtension(Filename) + ".bak"));
                File.WriteAllBytes(Filename, Resources.Ori);
                File.WriteAllBytes(Path.GetDirectoryName(Filename) + "OriMultiplayer.dll", Resources.OriMultiplayer);
                MessageBox.Show("Patched...");
            }
        }

        private void Ori_de_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            d1.Filter = "Assembly-CSharp (*.dll)|Assembly-CSharp.dll";
            if (d1.ShowDialog() == DialogResult.OK)
            {
                string Filename = d1.FileName;
                if (File.Exists(Path.Combine(Path.GetDirectoryName(Filename), Path.GetFileNameWithoutExtension(Filename) + ".bak")))
                {
                    File.Delete(Path.Combine(Path.GetDirectoryName(Filename), Path.GetFileNameWithoutExtension(Filename) + ".bak"));
                }
                File.Copy(Filename, Path.Combine(Path.GetDirectoryName(Filename), Path.GetFileNameWithoutExtension(Filename) + ".bak"));
                File.WriteAllBytes(Filename, Resources.OriDE);
                File.WriteAllBytes(Path.GetDirectoryName(Filename) + "OriMultiplayer.dll", Resources.OriMultiplayer);
                MessageBox.Show("Patched...");
            }
        }
    }
}
