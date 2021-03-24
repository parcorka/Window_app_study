using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Практика_8
{
    public partial class Ввод : Form
    {
        public Ввод()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MyRactangle ract = new MyRactangle(int.Parse(textBoxLength.Text), int.Parse(textBoxHight.Text), int.Parse(textBoxX.Text), int.Parse(textBoxY.Text));
            BinaryFormatter formater = new BinaryFormatter();
            //StreamWriter file = new StreamWriter(@"1", false, Encoding.Unicode);
            FileStream file = new FileStream("1", FileMode.OpenOrCreate, FileAccess.Write);
            formater.Serialize(file, ract);
            file.Close();
        }

        private void Ввод_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Opened = false;
        }
    }
}
