using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class formTicTacToe : Form
    {



        int length = 3;
        bool init = true;
        bool end = false;
        int count = 0;
        char[,] location = new char[,]
        {
            {'#','#','#'}, {'#','#','#' }, { '#','#','#' }
        };


        clsTicTacToe obj = new clsTicTacToe();

        Button[,] buttons;

        public formTicTacToe()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.handler(this.button1,2,2);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.handler(this.button9,0,0);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.handler(this.button8,0,1);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.handler(this.button7,0,2);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.handler(this.button6,1,0);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.handler(this.button5,1,1);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.handler(this.button4,1,2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.handler(this.button3,2,0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.handler(this.button2,2,1);

        }




        //helper methods

        private void handler(Button btn,int x, int y)
        {


            if (init)
            {
                buttons = new Button[,]
               {
                    {button9,button8,button7 },
                    {button6,button5,button4 },
                    {button3,button2,button1 }
               };

                init = false;
            }

            if (obj.getToggleValue())
            {
                btn.Text = obj.getUserOne();

            }
            else
            {
               btn.Text = obj.getUserTwo();
            }
            location[x,y] = Convert.ToChar(btn.Text);

            obj.setToggleValue();

            btn.Enabled = false;


            //if (++count > 4)
            //    checkForWinner(location[x,y]);

            if (++count > 4)
                checkForWinner();

        }

        private void checkForWinner() {

            if (button9.Text == "O" && button8.Text == "O" && button7.Text == "O") {
                this.lblInfo.Text = "User one wins";
            }

            if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
            {
                this.lblInfo.Text = "User Two wins";
            }

            if (button6.Text == "O" && button5.Text == "O" && button4.Text == "O")
            {
                this.lblInfo.Text = "User one wins";
            }

            if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
            {
                this.lblInfo.Text = "User Two wins";
            }


            if (button3.Text == "O" && button2.Text == "O" && button1.Text == "O")
            {
                this.lblInfo.Text = "User one wins";
            }

            if (button3.Text == "X" && button2.Text == "X" && button1.Text == "X")
            {
                this.lblInfo.Text = "User Two wins";
            }

            ///////////////////////////////////////
            if (button9.Text == "O" && button6.Text == "O" && button3.Text == "O")
            {
                this.lblInfo.Text = "User one wins";
            }

            if (button9.Text == "X" && button6.Text == "X" && button3.Text == "X")
            {
                this.lblInfo.Text = "User Two wins";
            }

            if (button8.Text == "O" && button5.Text == "O" && button2.Text == "O")
            {
                this.lblInfo.Text = "User one wins";
            }

            if (button8.Text == "X" && button5.Text == "X" && button2.Text == "X")
            {
                this.lblInfo.Text = "User Two wins";
            }


            if (button7.Text == "O" && button4.Text == "O" && button1.Text == "O")
            {
                this.lblInfo.Text = "User one wins";
            }

            if (button7.Text == "X" && button4.Text == "X" && button1.Text == "X")
            {
                this.lblInfo.Text = "User Two wins";
            }

            ///////////////////////////////////////////////////////////////////////

            if (button9.Text == "O" && button5.Text == "O" && button1.Text == "O")
            {
                this.lblInfo.Text = "User Two wins";
            }

            if (button9.Text == "X" && button5.Text == "X" && button1.Text == "X")
            {
                this.lblInfo.Text = "User one wins";
            }

            if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                this.lblInfo.Text = "User Two wins";
            }

            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                this.lblInfo.Text = "User one wins";
            }



        }


        public bool CheckForRows(char text)
        {

            for (int i = 0; i < length; i++)
            {
                bool test = true;
                for (int j  = 0; j  < length; j ++)
                {

                    if (location[i, j] == text)
                        test = test && true;
                    else
                        break;
                }

                if (test)
                    return true;
            }

            return false;
        }

        public bool CheckForColumns(char text)
        {
            for (int i = 0; i < length; i++)
            {
                bool test = true;
                for (int j = 0; j < length; j++)
                {

                    if (location[j, i] == text)
                        test = test && true;
                    else
                        break;
                }

                if (test)
                    return true;
            }
            return false;
        }
       

        public bool CheckForDiagonals(char text)
        {
            //bool testD1 = true,testD2 = true;
            //for (int i = 0,j=2; i < length && j>=0 ; i++,j--)
            //{
            //    if (location[i, i] == text)
            //        testD1 = testD1 && true;
            //    else
            //        testD1 = false;


            //    if (location[i, j] == text)
            //        testD2 = testD2 && true;
            //    else
            //        testD2 = false;

            //    if ((!testD1 && !testD2))
            //        break;

            //}

            //if (testD1 || testD2)
            //    return true;
            //return false;

            return false;
        }



        public void checkForWinner(char text)
        {
            char winner = ' ';
            if ( CheckForRows(text) || CheckForColumns(text)  )
                winner = text;

            


            if (winner == 'O')
            {
                this.lblInfo.Text = "Winner is: User One";
                end = true;
            }
            else if (winner == 'X')
            {
                this.lblInfo.Text = "Winner is: User Two";
                end = true;
            }
            else
//                this.lblInfo.Text = "Winner is: User Two";





            if (end || count>= 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j  = 0; j  < 3 ; j ++)
                    {
                        buttons[i, j].Enabled = false;
                    }
                }
                end = false;
            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {


            count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j  = 0; j  < 3 ; j ++)
                {
                    buttons[i, j].Text = "";
                    buttons[i,j].Enabled = true;
                    obj.toggleValue = true;
                    lblInfo.Text = "Winner is: Still Playing"; 
                     
                }
            }

        }
    }
}
