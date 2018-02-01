using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopReporting
{
    public partial class Form1 : Form
    {
        MemoryStream ms;
        DataSet dataset;
        DataTable screenshots;
        DataColumn idCol;
        DataColumn imageCol;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            initializeDataSet();
        }


        public void initializeDataSet()
        {
            dataset = new DataSet();
            screenshots = new DataTable();
            screenshots.TableName = "screenshots";
            idCol = new DataColumn();
            idCol.ColumnName = "No.";
            idCol.DataType = Type.GetType("System.Int32");
            imageCol = new DataColumn();
            imageCol.ColumnName = "Image";
            imageCol.DataType = typeof(byte[]);

            screenshots.Columns.Add(idCol);
            screenshots.Columns.Add(imageCol);
            dataset.Tables.Add(screenshots);
            FileInfo i = new FileInfo("a.txt");
            DriveInfo d = new DriveInfo("C:");
            


        }




        byte[] photo;
        private void takeScreenShot()
        {
            //Create a new bitmap.
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);
            ms = new MemoryStream();
            
            bmpScreenshot.Save(ms,ImageFormat.Png);
            photo = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo, 0, photo.Length);

            insertIntoDataset(photo);


        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }

        public void insertIntoDataset(byte[] photo)
        {
            DataRow record = screenshots.NewRow();
            record[0] = count;
            count++;
            record[1] = photo;
            screenshots.Rows.Add(record);
        }

        


        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            takeScreenShot();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image =  byteArrayToImage((byte[]) dataset.Tables["ScreenShots"].Rows[count][1]);
        }


        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
