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
    public partial class GroupMaster : Form
    {
        public GroupMaster()
        {
            InitializeComponent();
        }
        string Str = Connection.GlobalConnection;
        private void Save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "insert into GroupMaster (grid,GrName,StudentTotal) values('" + txtGroupId.Text + "','" + txtGroupName.Text + "','" + txtStudent.Text + "')";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();
            Load11();
            con.Close();
            MessageBox.Show("Group Insert");
        }

        void Load11()
        {
            string sql = " select GrId as [Group Id],GrName as[Group Name],StudentTotal from GroupMaster ";

            SqlDataAdapter da = new SqlDataAdapter(sql, Str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Name = "GrId";

        }

        void MaxID()
        {
            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "select isnull(max(grid),0)+1 as GroupId from groupmaster";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();

            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                txtGroupId.Text = r["GroupId"].ToString();
            }
            con.Close();
        }
        private void GroupMaster_Load(object sender, EventArgs e)
        {
            Load11();
            MaxID();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "update groupmaster set GrId='" + txtGroupId.Text + "',GrName='" + txtGroupName.Text + "',StudentTotal='" + txtStudent.Text + "' where GrId='" + txtGroupId.Text + "' ";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();
            Load11();
            con.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Str);
            con.Open();

            String Sql = "delete from groupmaster where GrId='" + txtGroupId.Text + "' ";
            SqlCommand cmd = new SqlCommand(Sql, con);
            cmd.ExecuteNonQuery();
            Load11();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.SelectedRows[0];

            txtGroupId.Text = (currentRow.Cells[0].Value).ToString();
            txtGroupName.Text = (currentRow.Cells[1].Value).ToString();
            txtStudent.Text = (currentRow.Cells[2].Value).ToString();
          
        }
    }
}
