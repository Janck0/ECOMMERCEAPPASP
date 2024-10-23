using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL2;


namespace ECOMMERCEAPPASP2.USERS
{
    public partial class ProductPage : System.Web.UI.Page
    {
        ScalarCls Sc = new ScalarCls();
        SelectCls Sel = new SelectCls();
        InsertCls Ins = new InsertCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["cid"];
                try
                {
                    Label1.Text = Sc.SelCatName(id);
                }
                catch
                {
                    Label1.Text = "INVALID";
                }
                DataTable Dt = Sel.ProdAllSel(id);//querry
                ListView1.DataSource = Dt;
                ListView1.DataBind();
            }
        }
        protected void AddCart(object sender, EventArgs e)
        {
            if (Session["UID"] != null)
            {
                string UID = Session["UID"].ToString();
                string s = e.ToString();
                Button btn = (Button)sender;
                string value = btn.CommandArgument;
                string check = Sc.Cart_Check(UID, value);
                int C = Convert.ToInt32(check);

                if (C == 0)
                {
                    int j = Ins.AddCart(UID, value);
                    if (j == 1)
                    {
                        btn.Text = "Added";
                    }
                    else
                    {
                        btn.Text = "NO ADDED";
                    }
                }
                else if (C == 1)
                {
                    btn.Text = "Already Added"; ;
                }
            }
                
        }
        protected void BuyNow(object sender, EventArgs e)
        {
            string s = e.ToString();
            Button btn = (Button)sender;
            string value = btn.CommandArgument;

            Response.Write("<script>alert('" + value + "')</script>");
        }
    }
}