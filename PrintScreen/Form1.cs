using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using System.IO;
//using System.Drawing;
//using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintscreenDLL.Printscreen.TakeAShot();
            //Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, 
            //    Screen.PrimaryScreen.Bounds.Height);
            //Graphics graphics = Graphics.FromImage(printscreen as Image);
            //graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            //saveFileDialog1.Title = "Image Capture: Image Name, File Format and Destination";
            //saveFileDialog1.FileName = "Screenshot";
            //saveFileDialog1.InitialDirectory=@"c:\";
            //saveFileDialog1.DefaultExt = "jpg";
            //saveFileDialog1.AddExtension = true;
            //saveFileDialog1.Filter = "Jpeg Image (JPG)|*.jpg|PNG Image|*.png|GIF Image (GIF)|*.gifBitmap (BMP)|*.bmp|EWM Image|*.emf|TIFF Image|*.tiff|Windows Metafile (WMF)|*.wmf|Exchangable image file|*.exif";
            //saveFileDialog1.FilterIndex = 1;
            //if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            //{
            //    ImageFormat fmtStyle;
            //    switch(saveFileDialog1.FilterIndex)
            //    {
            //        case 2:fmtStyle=ImageFormat.Jpeg;break;
            //        case 3:fmtStyle=ImageFormat.Gif;break;
            //        case 4: fmtStyle = ImageFormat.Bmp; break;
            //        case 5: fmtStyle = ImageFormat.Emf; break;
            //        case 6: fmtStyle = ImageFormat.Tiff; break;
            //        case 7: fmtStyle = ImageFormat.Wmf; break;
            //        case 8: fmtStyle = ImageFormat.Exif; break;
            //        default: fmtStyle=ImageFormat.Png;break;
            //    }
            //    printscreen.Save(saveFileDialog1.FileName,fmtStyle);
        }
    }
}
