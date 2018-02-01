using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LocalDatabaseApp
{
    public partial class Form1 : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;


        public Form1()
        {
            InitializeComponent();
        }

        public void connectDB()
        {
            con = new SqlConnection();
        }
    }
}
