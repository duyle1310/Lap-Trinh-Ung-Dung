using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableHeight { get; internal set; }

        public static int TableWidth = 90;
        public static int TabLeHeight = 90;
        private TableDAO(){ }
        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }    
            return tablelist;
        }
    }
}
