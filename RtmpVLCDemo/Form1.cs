using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RtmpVLCDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // install-package LibVLCSharp.WinForms
        // install-package VideoLAN.LibVLC.Windows

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            LibVLCSharp.Shared.Core.Initialize();
            var libvlc = new LibVLCSharp.Shared.LibVLC();
            videoView1.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(libvlc);
            var media = new LibVLCSharp.Shared.Media(libvlc, new Uri("rtmp://58.200.131.2:1935/livetv/hunantv"));
            videoView1.MediaPlayer.Play(media);
        }
    }
}
