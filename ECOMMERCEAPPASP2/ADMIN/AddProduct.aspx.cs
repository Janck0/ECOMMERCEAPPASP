using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL2;

namespace ECOMMERCEAPPASP2.ADMIN
{
    public partial class AddCategory : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        InsertCls Ins = new InsertCls();
        DeleteClass Del = new DeleteClass();
        UpdateCls Upd = new UpdateCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable Ds = Sel.CatSel();
                DropDownList2.DataSource = Ds;
                DropDownList2.DataBind();
                DropDownList2.DataTextField = "C_NAME";
                DropDownList2.DataValueField = "CAT_ID";
                DropDownList2.DataBind();
            }



        }
        public void GridVFn(string id)
        {
           
             
         DataSet dt = Sel.ProdGrid(id);
             
         GridView1.DataSource = dt;
         GridView1.DataBind();

  
             
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = "1";
            Id = DropDownList2.SelectedValue;
            
                try{ Session["PID"] = Id; } catch { }
           
            
            GridVFn(Id);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            GridView1.Visible = false;
            DataTable Ds = Sel.CatSel();
            DropDownList1.DataSource = Ds;
            // DropDownList1.DataBind();
            DropDownList1.DataTextField = "C_NAME";
            DropDownList1.DataValueField = "CAT_ID";
            DropDownList1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            

            string Img = "/ADMIN/ADMINPHOTOS/Products/" + FileUpload1.FileName;
            try
            {
                FileUpload1.SaveAs(MapPath(Img));
            }
            catch(Exception E)
            {
                Label1.Text = "ERROR";
            }
            if(TextBox1.Text!="" && TextBox3.Text!="" && TextBox4.Text!=""&& TextBox5.Text != "")
            {
                int i = Ins.Product_insert(TextBox1.Text,
                                           DropDownList1.SelectedValue,
                                           TextBox3.Text,
                                           Img, TextBox4.Text, TextBox5.Text);
                if (i == 1)
                {
                    Response.Write("<script>alert('Data inserted successfully!!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Something Wrong')</script>"); ;
                }
            }
            try
            {
                 GridVFn(Session["PID"].ToString());
            }
            catch(Exception E)
            {
                Response.Write("<script>alert('Something Wrong!!')</script>");
            }
            Panel1.Visible = false;

            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

        }

        protected void GridView1_SelectedIndexChanging1(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);
            int j = Del.DeletProd(getID.ToString());
            if (j == 1)
            {
                Response.Write("<script>alert('Item Deleted!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Something Wrong!')</script>");
            }
            GridVFn(Session["PID"].ToString());
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridVFn(Session["PID"].ToString());
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
                int i = e.RowIndex;
                int getID = Convert.ToInt32(GridView1.DataKeys[i].Value);
                TextBox TxtAdr1 = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
                TextBox TxtAdr2 = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
                //FileUpload File1=(FileUpload)GridView1.Rows[i].Cells[6].Controls[0];
                TextBox TxtAdr3 = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
                TextBox TxtAdr4 = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
                TextBox TxtAdr5 = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];

                int j = Upd.ProdUpd(getID,
                                            TxtAdr1.Text,
                                            TxtAdr2.Text,
                                            TxtAdr3.Text,
                                            TxtAdr4.Text,
                                            TxtAdr5.Text);
                
            
            GridView1.EditIndex = -1;
            GridVFn(Session["PID"].ToString());
            





        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridVFn(Session["PID"].ToString());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            GridView1.Visible = true;
            
        }
    }
}