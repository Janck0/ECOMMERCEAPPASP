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
    public partial class UserLogin : System.Web.UI.Page
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
                SqlDataReader Dr = Obj2.Login_User(Un, Pwd);
               
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
                   Response.Redirect("UserHome.aspx");
                }
            }
            else
            {
                Label1.Text = "USER DOESN'T EXISTS";
            }

        }
    }
}