using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;

namespace FacebookLogin
{
    public partial class Form1 : Form
    {
        private const string AppId = "1401984336535007";
        private Uri _loginUri;
        private const string _ExtendedPermissions = "user_about_me,publish_actions";
        FacebookClient fbClient = new FacebookClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = AppId;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";

            parameters.response_type = "token";

            parameters.display = "popup";

            if (!string.IsNullOrWhiteSpace(_ExtendedPermissions))
            {
                parameters.scope = _ExtendedPermissions;

                var fb = new FacebookClient();
                _loginUri = fb.GetLoginUrl(parameters);

                webBrowser.Navigate(_loginUri.AbsoluteUri);
            } 
        }
    }
}
