using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL2;
using System.Data.SqlClient;

namespace ECOMMERCEAPPASP2.ADMIN
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        ScalarCls Obj = new ScalarCls();
        SelectCls Obj2 = new SelectCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UID = "";
            string Un = TextBox1.Text;
            string Pwd = TextBox2.Text;
            string C = Obj.check_user(Un);
            if (C == "1")
            {
                SqlDataReader Dr = Obj2.Login_Admin(Un, Pwd);

                while (Dr.Read())
                {
                    UID = Dr["USER_ID"].ToString();
                }
                if (UID == "")
                {
                    Label1.Visible = true;
                    Label1.Text = "PASSWORD INCORRECT";
                    //Label1.Visible = false;
                }
                else
                {
                    Session["UID"] = UID;
                    Response.Redirect("AdminHome.aspx");
                }
            }
            else
            {
                Label1.Text = "USER DOESN'T EXISTS";
            }
        }
    }
}