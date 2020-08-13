using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebDataAccessConnected
{
  

    public partial class ConnectedObjects : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5M9C2IVC;Initial Catalog=JulyDonetBatch2020;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataReader dr;

        public void ShowGrid()
        {
            conn.Open();

            cmd = new SqlCommand("select * from EmployeeTb1", conn);

             dr = cmd.ExecuteReader();

            //SqlDataAdapter adt = new SqlDataAdapter(cmd);
           dt = new DataTable();

            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGrid();
            }
            Label1.Visible = false;
            //adt.Fill(dt);
            //DropDownList1.DataSource = dt;
            //DropDownList1.DataBind();
            //DropDownList1.DataTextField = "empName";
            //DropDownList1.DataValueField = "empId";
            //DropDownList1.DataBind();

            //while (dr.Read
            //    ())
            //{
            //      GridView1.DataSource = dr;
                
            //    //DropDownList1.DataSource = dr[1];

            //    //DropDownList1.SelectedItem= dr[1].ToString();

            //    /*DropDownList1.DataBind()*/;
            //    GridView1.DataBind();

            //}
            
            

        }

        protected void BtnInsertemo_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("Insert into EmployeeTb1 (empName,empSal) values('" + Txtename.Text+"',"+Txtesal.Text+")", conn);

            int x = cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();
        }

        protected void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            //to avoid connecton injection attack
            conn.Open();
            cmd = new SqlCommand("update EmployeeTb1 set empName=@empname,empSal=@empsal where empid=@empid", conn);//parameters
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(TxteId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = Txtename.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(Txtesal.Text);

            if(cmd.ExecuteNonQuery()>0)
            {
                Response.Write("alert(one row updated)");
            }
            conn.Close();
            ShowGrid();

        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_DeleteEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(TxteId.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_searchEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(TxteId.Text);
           dr= cmd.ExecuteReader();
            if(dr.Read())
            {
                Txtename.Text = dr["empName"].ToString();
                Txtesal.Text = dr["empSal"].ToString();
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Please enter correct employee Id";
                //Txtename.Text = "EMP NOT EXISTS";
                Txtesal.Visible = false;
            }
            dr.Close();
            conn.Close();
           

        }

        protected void BtnDisconnected_Click(object sender, EventArgs e)
        {

        }

        protected void BtninsertP_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into EmployeeTb1 (empName,empId) values (@empname,@empsal)", conn);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = Txtename.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(Txtesal.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();

        }

        protected void BtnInsertSP_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_insertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = Txtename.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(Txtesal.Text);
            //cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(TxteId.Text);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("alert(one row inserted)");
            }
            conn.Close();
            ShowGrid();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("update EmployeeTb1 set empName=('" + Txtename.Text + "'),empSal =(" + Txtesal.Text + ") where empId=("+TxteId.Text+")", conn);

            int x = cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();
           
        }

        protected void BtnUpdateSP_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_updateEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(TxteId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = Txtename.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(Txtesal.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("alert(one row updated)");
            }
            conn.Close();
            ShowGrid();

        }

        protected void btndeleteemp_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmployeeTb1 where empid=("+TxteId.Text+")", conn);
           
            cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmployeeTb1 where empid=@empid", conn);
          
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(TxteId.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            ShowGrid();

        }
    }
}
