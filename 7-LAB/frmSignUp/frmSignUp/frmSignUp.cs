using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSignUp
{
    public partial class frmSignUp : Form
    {
        string message = "";

        private string username = "";
        private string password = "";
        private bool passwordIsCorrect = false;
        private bool usernameIsCorrect = false;
        private bool usernameIsInFile = false;
        private bool passwordIsInFile = false;
        public frmSignUp()
        {
            InitializeComponent();
          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            bool isLegal = this.isLegal(@"..\..\..\frmSignUp\Resources\users.txt");

            if ( isLegal)// if it is valid & in file
                message = "Login Successful!";
            MessageBox.Show(message);


        }



        private bool validate()
        {
            username = this.txtUsername.Text.Trim();
            password = this.txtPassword.Text.Trim();

            usernameIsCorrect = validate(username, true);
            passwordIsCorrect = validate(password);

            bool correct = usernameIsCorrect && passwordIsCorrect;
            if (!correct)
                message = "Invalid username or password!";
            return correct;
        }
        private bool validate(string text,bool isUsername=false)
        {
            //6 to 20 characters string with at least one digit, 
            //one upper case letter, one lower case letter and one special symbol(“@#$%”). 
            //This regular expression pattern is very useful to implement a strong and complex password.
            string pattern = isUsername ? "([a-zA-Z|\\s]).{8,100}" : "((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(text);
        }


        private bool isLegal(string path)
        {


            bool isCorrect = validate();
            usernameIsInFile = isInFile(username, path, true);
            passwordIsInFile = isInFile(password, path);

            if (!isCorrect || !(usernameIsInFile && passwordIsInFile && isCorrect))
            {
                message = "Wrong username or password!";
                return false;
            }
            else if (!usernameIsInFile)
            {
                message = "Unregistered User!\nGet registered!";
                return false;
            }


            return usernameIsInFile && passwordIsInFile && isCorrect;
        }

        private bool isInFile(string word,string path ,bool isUsername = false)
        {

            // if it is username it is on the index 0
            // if it is passwod it is on the index 1
            int i = isUsername ? 0 : 1;
            string[] lines = File.ReadAllLines(path);
            foreach (string item in lines)
            {

                if(item != String.Empty && item.Trim().Split(':')[i].Trim() == word) {
                    return true;
                }

            }

            
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            registerEntry(@"..\..\..\frmSignUp\Resources\users.txt");
            MessageBox.Show(message);
        }


        private bool registerEntry(string path)
        {
            bool isCorrect = validate();
            usernameIsInFile = isInFile(username, path, true);

            StreamWriter sw = null;
            if (isCorrect && !usernameIsInFile)
            {
                sw = File.AppendText(path);
                sw.WriteLine("\n{0}:{1}", username, password);
                sw.Close();
                message = "Registered";
                return true;
            }
            else if (isCorrect && usernameIsInFile)
            {
                message = "Already Registered";
            }
            else
            {
                message = "Wrong username or password!";
            }
            return false;
        }




        //--------------------------------------------
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";

            this.txtUsername.Focus();

        }
    }
}
