using CAFE.DAO;
using CAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CAFE
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method

        void LoadTable()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {

                    // use constant for this, example: String EMPTY = "Trống".
                    // It means you only need to make one fix if your data changes. Many other places will change accordingly
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIDByTableID(id));
        }
        #endregion


        #region Events

        private void Btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }

        //naming : wrong. you must use words without accents for naming.
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        #endregion

    }
}
