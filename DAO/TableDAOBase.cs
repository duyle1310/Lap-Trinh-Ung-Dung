using QuanLyQuanCafe.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAOBase
    {
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