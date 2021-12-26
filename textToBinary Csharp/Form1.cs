using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace textToBinary_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             ResultBox.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getLabelText = InputText.Text;
            List<int> ascii = new List<int>();
            ascii = stringIntConvertor(getLabelText);
            for(int i=0;i<ascii.Count;i++)
            {
                ResultBox.AppendText(Convert.ToString(ascii[i], 2)+" ");
                //Console.WriteLine(i+":U+0020:"+Convert.ToString(ascii[i],2));
            }
        }
        private List<int> stringIntConvertor(string text)
        {
            List<int> list = new List<int>();
            for(int i=0;i<text.Length;i++)
            {
                list.Add((int)text[i]);
            }
            return list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }
    }
}
