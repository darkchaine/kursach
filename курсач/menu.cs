using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tt.Visible = true;
            inst.Visible = true;
            fb.Visible = true;
            number.Visible = true;
            map.Visible = true;
            aboutus.Visible = false;
            schedule.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutus.Visible = true;
            tt.Visible = false;
            inst.Visible = false;
            fb.Visible = false;
            number.Visible = false;
            map.Visible = false;
            schedule.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            schedule.SendToBack();
        }

        private void map_Click(object sender, EventArgs e)
        {
            map.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aboutus.Visible = false;
            tt.Visible = false;
            inst.Visible = false;
            fb.Visible = false;
            number.Visible = false;
            map.Visible = false;
            schedule.Visible = true;

        }
    }
}
