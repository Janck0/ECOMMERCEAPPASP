using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BLL2;


namespace ECOMMERCEAPPASP2.ADMIN
{

    public partial class AddProduct : System.Web.UI.Page
    {
        InsertCls Obj = new InsertCls();
        SelectCls Obj2 = new SelectCls();
        DeleteClass Del = new DeleteClass();
        UpdateCls Upd = new UpdateCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewFn();
            }
           
        }
        public void GridViewFn()
        {


            DataSet dt = Obj2.GridViewSel();

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string Img = "/ADMIN/ADMINPHOTOS/Category/" + FileUpload1.FileName;
            try
            {
                FileUpload1.SaveAs(MapPath(Img));
            }
            catch (Exception E)
            {

            }
            if(TextBox1.Text!="" && TextBox2.Text != "")
            {
                int i = Obj.Category_insert(TextBox1.Text, TextBox2.Text, Img);
                if (i == 1)
                {
                    Label1.Text = "INSERTED";
                }
            }
            
            GridViewFn();
            TextBox1.Text = "";
            TextBox2.Text = "";
            Panel1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            GridView1.Visible = true;
            Panel1.Visible = false;
                
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);
            //deleting
            int j = Del.DeleteCat(getID.ToString());
            GridViewFn();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridViewFn();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridViewFn();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox TxtAdr1 = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox TxtAdr2 = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            //FileUpload File1=(FileUpload)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox TxtAdr3 = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            int j = Upd.CatUpd(getID,
                            TxtAdr1.Text,
                            TxtAdr2.Text,
                            TxtAdr3.Text);
            GridView1.EditIndex = -1;
            GridViewFn();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            GridView1.Visible = false;
        }
    }
}