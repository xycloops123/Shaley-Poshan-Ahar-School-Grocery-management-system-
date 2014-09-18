using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShaleyPoshanAhar.Reports
{
    public partial class ReportDailyEntry : Form
    {
        public ReportDailyEntry()
        {
            InitializeComponent();
        }
        string Str = Connection.GlobalConnection;
        private void ReportDailyEntry_Load(object sender, EventArgs e)
        {
            load11();
        }

        void load11()
        {
            //Sql = "select g.grname,i.itemname,m.weight,'" + GVGroup.Rows[i].Cells[4].Value + "' as student,s.stock,('" + GVGroup.Rows[i].Cells[4].Value + "' * m.weight)as capacity, (s.stock- ('" + GVGroup.Rows[i].Cells[4].Value + "' * m.weight)) as usedweight   " +
            //                    " from itemmaster i inner join masterlink m on i.itemid=m.itemid " +
            //                    " inner join itemweekday w on i.itemid=w.itemid " +
            //                    " left outer join groupmaster g on m.grid=g.grid " +
            //                    " left outer join itemstock s on i.itemid=s.itemid " +
            //                    " where w.weekday= datename(dw,getdate())" +
            //                    " group by g.grname,i.itemname,m.weight,s.stock " +
            //                    " order by g.grname,i.itemname ";
            SqlConnection con = new SqlConnection(Str);
            con.Open();
            string Sql = "SELECT        StockInfo.EntryDate, GroupMaster.GrName, ItemMaster.ItemName, ItemStock.Stock, MasterLink.Weight, StockInfo.PreStock, " +
                        "   StockInfo.UsedQuantity, StockInfo.UpdateStock, StudentInfo.AppearingStudent"+
"  FROM            ItemStock INNER JOIN"+
      "                   ItemMaster ON ItemStock.ItemId = ItemMaster.ItemID INNER JOIN"+
      "                   ItemWeekDay ON ItemMaster.ItemID = ItemWeekDay.ItemID INNER JOIN"+
       "                  MasterLink ON ItemMaster.ItemID = MasterLink.ItemID INNER JOIN"+
       "                  GroupMaster ON MasterLink.GrID = GroupMaster.GrID INNER JOIN"+
        "                 StockInfo ON ItemMaster.ItemID = StockInfo.Itemid INNER JOIN"+
        "                 StudentInfo ON StockInfo.EntryDate = StudentInfo.EntryDate"+
   " ORDER BY StockInfo.EntryDate, GroupMaster.GrName, ItemMaster.ItemName";

            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            GVDailyEntry.DataSource = r;
           // GVDailyEntry.d

        }

        private void GVDailyEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
