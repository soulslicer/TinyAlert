using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyAlertExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TinyAlertView.SetUI(this);
            TinyAlertView.SetTiming(5);

        }

        private void UI_Move(object sender, EventArgs e)
        {
            TinyAlertView.SetLocation();
        }

        private void UI_Resize(object sender, EventArgs e)
        {
            TinyAlertView.SetLocation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TinyAlertView.Show(TinyAlertView.StateTinyAlert.SUCCESS, "AA");
        }
    }
}
