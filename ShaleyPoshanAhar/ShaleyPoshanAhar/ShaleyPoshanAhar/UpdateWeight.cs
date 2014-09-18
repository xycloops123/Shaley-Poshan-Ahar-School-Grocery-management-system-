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
    public partial class UpdateWeight : Form
    {
        public UpdateWeight()
        {
            InitializeComponent();
        }
        string Str = Connection.GlobalConnection;
        private void button1_Click(object sender, EventArgs e)
        {

         //   DataGridViewRow currentRow = dataGridView1.SelectedRows[0];

            SqlConnection con = new SqlConnection(Str);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                SqlConnection con1 = new SqlConnection(Str);

                con1.Open();

                String Sql2 = "select i.itemid From MasterLink m inner join itemmaster i on i.itemid=m.itemid  where i.itemName='" + dataGridView1.Rows[i].Cells[0].Value + "' ";
                SqlCommand cmd2 = new SqlCommand(Sql2, con1);
                cmd2.ExecuteNonQuery();


                SqlDataReader r = cmd2.ExecuteReader();
                r.Read();
                con.Open();
                //string stock1 = "+dataGridView1.Rows[i].Cells[2].Value+";
                //string stock2 = "+dataGridView1.Rows[i].Cells[1].Value +";
                String Sql = "update itemstock set stock=(" + dataGridView1.Rows[i].Cells[2].Value + " + " + dataGridView1.Rows[i].Cells[1].Value + ") where itemid= '" + Convert.ToInt16(r["itemid"].ToString()) + "'  ";
                SqlCommand cmd = new SqlCommand(Sql, con);
                cmd.ExecuteNonQuery();
                Load11();

                con.Close();
                con1.Close();
            }
        }

        
  void Load11()
        {
            string sql = " select i.itemname,s.stock  "+
                         " from itemstock  s inner join itemmaster i on i.itemid=s.itemid"+

                         " group by i.itemname,s.stock  " +
                         " order by i.itemname";

            SqlDataAdapter da = new SqlDataAdapter(sql, Str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Name = "GrId";
        }

  void Group2()
  {
      DataTable dtTemp = new DataTable();
      dtTemp.Columns.Add("ItemName", typeof(string));
     
      dtTemp.Columns.Add("Quntity", typeof(decimal));

      SqlConnection con = new SqlConnection(Str);
      con.Open();
      string Sql = "Select ItemName from itemmaster";
      SqlCommand cmd = new SqlCommand(Sql, con);
      SqlDataReader r;
      r = cmd.ExecuteReader();
      while (r.Read())
      {

          //DataRow dr;



          DataRow drNewRow = dtTemp.NewRow();
          drNewRow["ItemName"] = Convert.ToString(r["ItemName"].ToString());
          
          dtTemp.Rows.Add(drNewRow);

      }
      dataGridView2.DataSource = dtTemp;

      con.Close();
     

  }

  void Group1()
  {
      DataTable dtTemp = new DataTable();
      dtTemp.Columns.Add("ItemName", typeof(string));
      dtTemp.Columns.Add("Stock", typeof(decimal));
      dtTemp.Columns.Add("Quntity", typeof(decimal));

      SqlConnection con = new SqlConnection(Str);
      con.Open();
      string sql = " select i.itemname,s.stock  " +
                         " from itemstock  s inner join itemmaster i on i.itemid=s.itemid" +

                         " group by i.itemname,s.stock  " +
                         " order by i.itemname";
      SqlCommand cmd = new SqlCommand(sql, con);
      SqlDataReader r;
      r = cmd.ExecuteReader();
      while (r.Read())
      {

          //DataRow dr;



          DataRow drNewRow = dtTemp.NewRow();
          drNewRow["ItemName"] = Convert.ToString(r["itemname"].ToString());
          drNewRow["Stock"] = Convert.ToString(r["stock"].ToString());

          dtTemp.Rows.Add(drNewRow);

      }
      dataGridView1.DataSource = dtTemp;

      con.Close();


  }
  private void UpdateWeight_Load(object sender, EventArgs e)
  {
     // Load11();
      Group1();
      Group2();
  }
        
    }
}
