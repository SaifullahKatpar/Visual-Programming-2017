using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {

        int winCount = 0;
        int count = 3;   // number of matched images
        int[] nums;      // random list   
        static Button[] buttons;
        string solution;
        //        Dictionary<Button, Image> mapping = new Dictionary<Button, Image>();
        Dictionary<Button, string> mapping = new Dictionary<Button, string>();

        string[] pictures = new string[14];
        string winImage;
        string path = @"..\..\..\puzzlePicDirectory\";
        string pic;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            // initialize array buttons[]
            this.btnPlay.ForeColor = Color.YellowGreen;
            this.btnPlay.Font = new Font(Font.FontFamily,15);
            this.btnSolution.ForeColor = Color.YellowGreen;
            this.btnSolution.Font = new Font(Font.FontFamily, 15);
            this.btnInfo.ForeColor = Color.YellowGreen;
            this.btnInfo.Font = new Font(Font.FontFamily, 15);

            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15,button16};
            setImages();    

        }

        // ref: deleteImage(), setWinnerButtons()
        public void setImages()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Image = null;
            }
            this.btnSolution.Text = "Show Solution";
            // default text for lblInfo
            this.btnInfo.Text = "Attempts Allowed  = 3 \n Remaining = " + count;
            mapping = new Dictionary<Button, string>();
            pictures = new string[14]
                {
                        "candy1.jpg",
                        "candy2.jpg",
                        "candy3.jpg",
                        "candy4.jpg",
                        "candy5.jpg",
                        "candy6.jpg",
                        "candy7.jpg",
                        "candy8.jpg",
                        "candy9.jpg",
                        "candy10.jpg",
                        "candy11.jpg",
                        "candy12.jpg",
                        "candy13.jpg",
                        "candy14.jpg",
                };
            int length = 14;
            int winImageIndex = rand.Next(0, length-1);
            winImage = pictures[winImageIndex];
            deleteImage(winImageIndex, length);
            this.btnPic.Image = Image.FromFile(path + winImage);
            setWinnerButtons(winImage);
            string otherImage = null;
            for (int i = 3; i < buttons.Length; i++)
            {
                otherImage = pictures[rand.Next(0, length-1)];
                mapping.Add(buttons[nums[i]], otherImage);
            }

        }
        public void randomize()
        {
            nums = Enumerable.Range(0, 16).ToArray();
            var rnd = new Random();
            // Shuffle the array
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }
        }
        // ref: randomize()
        public void setWinnerButtons(string winImage)
        {
            randomize();
            for (int i = 0; i < 3; i++)
            {
                solution += " " + (nums[i] + 1);
                mapping.Add(buttons[nums[i]], winImage);
            }
        }
        public void deleteImage(int index,int length)
        {
            int i;
            for (i = index; i <length-1 ; i++)
            {
                pictures[i] = pictures[i + 1];
            }
            pictures[i] = null;
        }
        //ref: setButtons(true)
        public void reset() {
            this.btnInfo.BackColor = Color.White;
            this.btnInfo.Font = new Font(Font.FontFamily,10);
            solution = "";
            winCount = 0;   // number of matched images
            count = 3;      // number of allowed attempts
            setImages();
            setButtons(true);
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic = mapping[button1];
            this.button1.Image = Image.FromFile(path + pic);
            checkWin(pic,button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button2];
            this.button2.Image = Image.FromFile(path + pic);
            checkWin(pic, button2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button3];
            this.button3.Image = Image.FromFile(path + pic);
            checkWin(pic, button3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button4];
            this.button4.Image = Image.FromFile(path + pic);
            checkWin(pic, button4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button5];
            this.button5.Image = Image.FromFile(path + pic);
            checkWin(pic, button5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button6];
            this.button6.Image = Image.FromFile(path + pic);
            checkWin(pic, button6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button7];
            this.button7.Image = Image.FromFile(path + pic);
            checkWin(pic, button7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button8];
            this.button8.Image = Image.FromFile(path + pic);
            checkWin(pic, button8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button9];
            this.button9.Image = Image.FromFile(path + pic);
            checkWin(pic, button9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button10];
            this.button10.Image = Image.FromFile(path + pic);
            checkWin(pic, button10);

        }
        private void button11_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button11];
            this.button11.Image = Image.FromFile(path + pic);
            checkWin(pic, button11);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button12];
            this.button12.Image = Image.FromFile(path + pic);
            checkWin(pic, button12);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button13];
            this.button13.Image = Image.FromFile(path + pic);
            checkWin(pic, button13);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button14];
            this.button14.Image = Image.FromFile(path + pic);
            checkWin(pic, button14);

        }
        private void button15_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button15];
            this.button15.Image = Image.FromFile(path + pic);
            checkWin(pic, button15);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            pic = mapping[this.button16];
            this.button16.Image = Image.FromFile(path + pic);
            checkWin(pic, button16);

        }
        // checks the win of the user 
        public void checkWin(string image, Button btn)             
        {
            count--;         // attempt decrements on each click
            this.btnInfo.Text = "Attempts Allowed  = 3 \n Remaining = " + count;
            if ( image == winImage)
            {
                winCount++;
                if (winCount == 3)
                {
                    this.btnInfo.BackColor = Color.SlateBlue;
                    this.btnInfo.Font = new Font(Font.FontFamily,20);
                    this.btnInfo.Text = "You Win!";

                    setButtons(false);
                }
                else if (count <= 0)
                {
                    this.btnInfo.Text = "You Lose!";
                    setButtons(false);
                }
                return;

            }
            if (count <=0)
            {
                this.btnInfo.Text = "You Lose!";
                setButtons(false);
                return;
            }

        }

        // this method will disable all the 16 buttons so that user cannot click them
        public void setButtons(bool con)
        {
            for (int i = 0; i < 16; i++)

            {
                buttons[i].Enabled = con;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnSolution_Click(object sender, EventArgs e)
        {
            this.btnSolution.Text = solution;
        }



    }
}
