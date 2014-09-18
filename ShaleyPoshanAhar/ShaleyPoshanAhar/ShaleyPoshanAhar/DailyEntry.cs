using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShaleyPoshanAhar
{
    public partial class DailyEntry : Form
    {
       public string Sql;
       public SqlCommand cmd;

        public DailyEntry()
        {
            InitializeComponent();
        }
        string Str = Connection.GlobalConnection;
        int id;
        int GrId1, Itid;
        private void DailyEntry_Load(object sender, EventArgs e)
        {
            DateT();
            Group();

        }

        void Group()
        {
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("GroupId", typeof(int));
            dtTemp.Columns.Add("GroupName", typeof(string));
            dtTemp.Columns.Add("TotalStudent", typeof(int));
            dtTemp.Columns.Add("PresentStudent", typeof(int));
            dtTemp.Columns.Add("AppearingStudent", typeof(int));

            SqlConnection con = new SqlConnection(Str);
            con.Open();
            string Sql = "Select grid,GrName,StudentTotal from GroupMaster";
            SqlCommand cmd = new SqlCommand(Sql, con);
            con.Close();
            con.Open();
            SqlDataReader r;
            r = cmd.ExecuteReader();
            while (r.Read())
            {

                //DataRow dr;



                DataRow drNewRow = dtTemp.NewRow();
                drNewRow["GroupId"] = Convert.ToInt16(r["grid"].ToString());
                drNewRow["GroupName"] = Convert.ToString(r["GrName"].ToString());
                drNewRow["TotalStudent"] = Convert.ToString(r["StudentTotal"].ToString());
                dtTemp.Rows.Add(drNewRow);

            }

            GVGroup.DataSource = dtTemp;


            con.Close();

        }

        void DateT()
        {
            SqlConnection con = new SqlConnection(Str);
            con.Open();
            string Sql = "Select datename(dw,getdate())as Weekday  ";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            WD.Text = r["Weekday"].ToString();
            con.Close();
        }

        void Details()
        {
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("GroupName", typeof(string));
            dtTemp.Columns.Add("ItemName", typeof(string));
           // dtTemp.Columns.Add("GroupName", typeof(string));
            dtTemp.Columns.Add("Weight", typeof(decimal));
            dtTemp.Columns.Add("AppearingStudent", typeof(int));
            dtTemp.Columns.Add("PreviousStock", typeof(decimal));
            dtTemp.Columns.Add("UsedWeight", typeof(decimal));
            dtTemp.Columns.Add("UpdatedStock", typeof(decimal));


            SqlConnection con = new SqlConnection(Str);
        
            
                con.Open();
                for (int i = 0; i < GVGroup.Rows.Count - 1; i++)
                {

                    Sql = "select g.grname,i.itemname,m.weight,'" + GVGroup.Rows[i].Cells[4].Value + "' as student,s.stock,('" + GVGroup.Rows[i].Cells[4].Value + "' * m.weight)as capacity, (s.stock- ('" + GVGroup.Rows[i].Cells[4].Value + "' * m.weight)) as usedweight   " +
                                 " from itemmaster i inner join masterlink m on i.itemid=m.itemid " +
                                 " inner join itemweekday w on i.itemid=w.itemid " +
                                 " left outer join groupmaster g on m.grid=g.grid " +
                                 " left outer join itemstock s on i.itemid=s.itemid " +
                                 " where w.weekday= datename(dw,getdate())" +
                                 " group by g.grname,i.itemname,m.weight,s.stock " +
                                 " order by g.grname,i.itemname ";


                    cmd = new SqlCommand(Sql, con);
                    con.Close();



                    con.Open();

                    SqlDataReader r;
                    r = cmd.ExecuteReader();

                    while (r.Read())
                    {


                        DataRow drNewRow = dtTemp.NewRow();
                        drNewRow["GroupName"] = Convert.ToString(r["grname"].ToString());
                        drNewRow["ItemName"] = Convert.ToString(r["itemname"].ToString());
                        drNewRow["Weight"] = Convert.ToDecimal(r["weight"].ToString());
                        drNewRow["AppearingStudent"] = Convert.ToInt32(r["student"].ToString());
                        drNewRow["PreviousStock"] = Convert.ToDecimal(r["stock"].ToString());
                        drNewRow["UsedWeight"] = Convert.ToDecimal(r["capacity"].ToString());
                        drNewRow["UpdatedStock"] = Convert.ToDecimal(r["usedweight"].ToString());
                        dtTemp.Rows.Add(drNewRow);

                    } //r.NextResult();


                    GVDetail.DataSource = dtTemp;
                    con.Close();
                }

        }

        private void Find_Click(object sender, EventArgs e)
        {
            Details();
        }

        private void Modify1_Click(object sender, EventArgs e)
        {

        }

        void MaxItemId()
        {

            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "select isnull(max(EntryId),0)+1 as Id from StudentInfo";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();

            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                id =Convert.ToInt16( r["id"].ToString());
            }
            con.Close();
        }


        void ItemId()
        {

            SqlConnection con = new SqlConnection(Str);
            
        }

        private void Save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Str);
            for (int j = 0; j < GVGroup.Rows.Count - 1; j++)
            {
                MaxItemId();
                con.Open();
                String Sql = " insert into StudentInfo (Entryid,EntryDate,TotalStudent,PresentStudent,AppearingStudent) values('" + id + "','" + dateTimePicker1.Value + "','" + GVGroup.Rows[j].Cells[2].Value + "','" + GVGroup.Rows[j].Cells[3].Value + "','" + GVGroup.Rows[j].Cells[4].Value + "') ";
                SqlCommand cmd = new SqlCommand(Sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }

          

            for (int j = 0; j < GVDetail.Rows.Count-1 ; j++)
            {
                SqlConnection con1 = new SqlConnection(Str);

                con1.Open();

                String Sql2 = "select i.itemid,g.GrId From MasterLink m inner join itemmaster i on i.itemid=m.itemid inner join groupmaster g on g.GrId=m.GrId where i.itemName='" + GVDetail.Rows[j].Cells[1].Value + "' and g.GrName='" + GVDetail.Rows[j].Cells[0].Value + "' ";
                SqlCommand cmd2 = new SqlCommand(Sql2, con1);
                cmd2.ExecuteNonQuery();
             

                SqlDataReader r = cmd2.ExecuteReader();
                r.Read();









                    con.Open();
                    String Sql12 = " insert into StockInfo (itemid,GrId,PreStock,UsedQuantity,UpdateStock,EntryDate) values('" + Convert.ToInt16(r["itemid"].ToString()) + "','" + Convert.ToInt16(r["GrId"].ToString()) + "','" + GVDetail.Rows[j].Cells[4].Value + "','" + GVDetail.Rows[j].Cells[5].Value + "','" + GVDetail.Rows[j].Cells[6].Value + "','" + dateTimePicker1.Value + "') ";
                    SqlCommand cmd12 = new SqlCommand(Sql12, con);
                    cmd12.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    String Sql123 = " update itemStock set stock='" + GVDetail.Rows[j].Cells[6].Value + "' where itemid='" + Convert.ToInt16(r["itemid"].ToString()) + "'  ";
                    SqlCommand cmd123 = new SqlCommand(Sql123, con);
                    cmd123.ExecuteNonQuery();
                    con.Close();

                con1.Close();
                  
                   
               

            }



            MessageBox.Show("Item Add");
           // Load11();
            con.Close();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
