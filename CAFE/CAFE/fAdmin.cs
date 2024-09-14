using CAFE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            dtgvAccount.DataSource = DataProvider.Instance.ExcuteQuery("exec USP_GetListAccountByUserName @username", new object[] { "'' or 1=1-- " });
        }
    }
}
