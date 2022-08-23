using Music_Player.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Music_Player
{
    public partial class Form1 : Form
    {
        Music[] songs = new Music[] { new Pop(), new Rock() };
        SoundPlayer foo;
        static int count=0;
        string preText;
        public Form1()
        {
            preText = " ";
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            string url;
            
            if(!(preText.Equals(Search.Text)))
            {
                preText = Search.Text;
                count = 0;
            }
            if (preText == "Pop" && count==0)
            {
                url = songs[0].UrlSong();
                foo= new SoundPlayer(@url);
                foo.SoundLocation = url;
                foo.Play();
                url = songs[0].UrlPic();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Load(url);
            }
            if(preText=="Rock" && count==0)
            {
                url = songs[1].UrlSong();
                foo = new SoundPlayer(@url);
                foo.SoundLocation = url;
                foo.Play();
                url = songs[1].UrlPic();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Load(url);
            }
            count = 0;
        }
        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(' ') && count!=1)// ' '== space
            {
                count=1;
                if (Search.Text == "Pop")
                {
                    foo.Stop();
                    return;
                }
                if(Search.Text=="Rock")
                {
                    foo.Stop();
                    return;
                }
            }
            else
            {
                count = 0;
                foo.Play();
            }
        }

       
    }
}
