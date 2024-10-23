using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BLL2;

namespace ECOMMERCEAPPASP2.USERS
{
    public partial class Cart : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        UpdateCls Upd = new UpdateCls();
        DeleteClass Del = new DeleteClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            Fn_CartList();
            Total.Text = "";
            int sum = 0;
            if (Session["UID"] != null)
            {
                string ID = Session["UID"].ToString();
                SqlDataReader Dr=Sel.CartSum(ID);
                while (Dr.Read())
                {
                    int Count = Convert.ToInt32(Dr["COUNT"]);
                    int Price = Convert.ToInt32(Dr["P_PRICE"]);
                    sum =sum+Count * Price;
                }
            }
            string sum2 = sum.ToString();
            
            Total.Text = "Rs:"+sum2;
        }
        public void Fn_CartList()
        {
            if (Session["UID"] != null)
            {
                string UID = Session["UID"].ToString();
                DataTable Dt = Sel.CartAllSel(UID);//username should be added from login
                if (Dt != null)
                {
                    CartList.DataSource = Dt;
                    CartList.DataBind();
                }
                
            }
            else
            {
                Response.Write("<script>alert('User Not Loged In ')</script>");
                Response.Redirect("UserLogin.aspx");
            }
                
         
        }
        protected void PlusItem(object sender, EventArgs e)
        {
            string s = e.ToString();
            Button btn = (Button)sender;
            string value = btn.CommandArgument;


        }
        protected void CartList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

            if (e.CommandName == "Submit")
            {
                TextBox textBox = (TextBox)e.Item.FindControl("Txt1");
                string value = textBox.Text;

            }
        }

        protected void CartList_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            var Count = CartList.Items[e.ItemIndex].FindControl("Txt1") as TextBox;
            var IDLb = CartList.Items[e.ItemIndex].FindControl("Cid") as Label;
            string V = Count.Text;
            string ID = IDLb.Text;
            int i=Upd.CartUpd(ID, V);

        }
        protected void DeleteCart(object sender, EventArgs e)
        {
            string s = e.ToString();
            LinkButton btn = (LinkButton)sender;
            string ID = btn.CommandArgument;
            if (ID != null)
            {
                Del.DeleteCart(ID);
            }
            Fn_CartList();
        }
    }

}
