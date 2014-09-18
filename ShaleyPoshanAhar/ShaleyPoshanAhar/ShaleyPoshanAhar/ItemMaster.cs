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
    public partial class ItemMaster : Form
    {
        public ItemMaster()
        {
            InitializeComponent();
        }
        String Str = Connection.GlobalConnection;
        int recordid;
        private void Save_Click(object sender, EventArgs e)
        {
            int k,j;
          
            SqlConnection con = new SqlConnection(Str);
            con.Open();


            String Sql2 = "insert ItemMaster (ItemId,ItemName) values('" + txtItemId.Text + "','" + txtItemName.Text + "')";
            SqlCommand cmd2 = new SqlCommand(Sql2, con);
            cmd2.ExecuteNonQuery();

            for (k=0; k < CLWeekDay.CheckedItems.Count; k++)
            {
                MaxRecId();
                String Sql1 = "insert ItemWeekDay (recid,ItemId,weekDay) values('"+ recordid +"','" + txtItemId.Text + "','" + CLWeekDay.CheckedItems[k].ToString() + "')";
                SqlCommand cmd1 = new SqlCommand(Sql1, con);
                cmd1.ExecuteNonQuery();

            }


            for (j = 0; j < GMGroup.Rows.Count-1; j++)
            {
                   String Sql = "insert MasterLink (ItemId,GrId,weight) values('" + txtItemId.Text + "','" + GMGroup.Rows[j].Cells[0].Value + "','" + GMGroup.Rows[j].Cells[2].Value + "')";
                    SqlCommand cmd = new SqlCommand(Sql, con);
                    cmd.ExecuteNonQuery();
                
            }

            MessageBox.Show("Item Add");
            Load11();
            con.Close();
            clear();
            MaxItemId();
        }

        void clear()
        {
            txtItemId.Text = "";
            txtItemName.Text = "";
          
        }

        void Load11()
        {
            string sql = " select i.itemid,i.itemname,g.GrId ,g.GrName ,m.weight  "+
                         " from itemmaster i inner join masterlink m on i.itemid=m.itemid"+
                         " left outer join groupmaster g on g.grid=m.grid "+
                         " group by i.itemid,i.itemname,g.GrId ,g.GrName ,m.weight "+
                         " order by i.itemid,g.GrId";

            SqlDataAdapter da = new SqlDataAdapter(sql, Str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ItemGroup.DataSource = dt;
            ItemGroup.Name = "GrId";
        }

        void Group()
        {
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("GroupId", typeof(int));
            dtTemp.Columns.Add("GroupName", typeof(string));
            dtTemp.Columns.Add("Weight", typeof(decimal));

            SqlConnection con = new SqlConnection(Str);
            con.Open();
            string Sql = "Select grId,GrName from GroupMaster";
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader r;
            r = cmd.ExecuteReader();
            while (r.Read())
            {

                //DataRow dr;



                DataRow drNewRow = dtTemp.NewRow();
                drNewRow["GroupId"] = Convert.ToInt16(r["grId"].ToString());
                drNewRow["GroupName"] = Convert.ToString(r["GrName"].ToString());
                dtTemp.Rows.Add(drNewRow);

            }
            GMGroup.DataSource = dtTemp;


            con.Close();

        }

        void MaxRecId()
        {
            
            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "select isnull(max(recid),0)+1 as RecordId from Itemweekday";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();

            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                recordid = Convert.ToInt16(r["RecordId"].ToString());
            }
            con.Close();
        }


        void MaxItemId()
        {

            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "select isnull(max(ItemId),0)+1 as ItemId from ItemMaster";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();

            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                txtItemId.Text = r["ItemId"].ToString();
            }
            con.Close();
        }

        private void ItemMaster_Load(object sender, EventArgs e)
        {
            Group();
            MaxItemId();
            Load11();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = ItemGroup.SelectedRows[0];

            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "delete from itemMaster where ItemId='" + (currentRow.Cells[0].Value).ToString() + "' ";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();
            Load11();
            con.Close();
        }

        private void ItemGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = ItemGroup.SelectedRows[0];

            //txt.Text = (currentRow.Cells[0].Value).ToString();
            //txtGroupName.Text = (currentRow.Cells[1].Value).ToString();
            //txtStudent.Text = (currentRow.Cells[2].Value).ToString();


            string sql = "select weekday from itemweekday where itemid='"+ (currentRow.Cells[0].Value).ToString() +"'  ";

            SqlDataAdapter da = new SqlDataAdapter(sql, Str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvWeekday.DataSource = dt;
            gvWeekday.Name = "GrId";
        }

        private void Modify1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Str);
            //con.Open();

            //String Sql = "update groupmaster set GrId='" + txtGroupId.Text + "',GrName='" + txtGroupName.Text + "',StudentTotal='" + txtStudent.Text + "' where GrId='" + txtGroupId.Text + "' ";
            //SqlCommand cmd = new SqlCommand(Sql, con);
            //cmd.ExecuteNonQuery();
            //Load11();
            //con.Close();
        }



    }
}
