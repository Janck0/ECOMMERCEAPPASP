using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL2;

namespace ECOMMERCEAPPASP2.BankPages
{
    public partial class UserLogin : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        ScalarCls Sc = new ScalarCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BnkLogin_Click(object sender, EventArgs e)
        {
            string c=Sc.BankUsr_Count(BnkUsrNm.Text);
            if (c == "1")
            {
                string UID = "";
               SqlDataReader Dr= Sel.Bank_Login(BnkUsrNm.Text, BnkPwd.Text);
                while (Dr.Read())
                {
                    UID = Dr["BankID"].ToString();
                }
                if (UID == "")
                {
                    Lbl1.Visible = true;
                    Lbl1.Text = "password is incorrect";

                }
                else
                {
                    Lbl1.Visible = false;
                    Session["BnkID"] = UID;
                    Response.Redirect("BankHome.aspx");
                }
            }
            else
            {
                Lbl1.Visible = true;
                Lbl1.Text = "user doesnt exists";

            }
        }
    }
}