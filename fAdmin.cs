using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;
using QuanLyQuanCafe.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            
        }
        #region methods

        void LoadListBillByDate(DateTime checkIn, DateTime checOut)
        {
           dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checOut);
        }

        #endregion

        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkFromDate.Value);
        }
        #endregion

    }
}
