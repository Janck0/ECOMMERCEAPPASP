using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL2;

namespace ECOMMERCEAPPASP2.ADMIN
{
    public partial class AdminRegi : System.Web.UI.Page
    {
        InsertCls obj = new InsertCls();
        ScalarCls obj2 = new ScalarCls();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string regid = obj2.check_reg().ToString();//returns count of the logids
            string nregid = "";
            string u = obj2.check_user(TextBox4.Text);//CHECK USERNAME EXISTS OR NOT

            if (u == "0")
            {
                if (regid == "")
                {
                    nregid = "ADMIN" + 1.ToString();
                }
                else
                {
                    string c = obj2.check_count();//returns count of rows in Login Table
                    nregid = "ADMIN" + c.ToString();
                    int i = obj.admin_insert(nregid,
                                        TextBox1.Text, TextBox2.Text,
                                        TextBox3.Text, "ACTIVE");
                    if (i == 1)
                    {
                        int j = obj.login_insert(nregid, TextBox4.Text, TextBox5.Text, "ADMIN", "ACTIVE");
                        Label1.Text = "REGISTRATION SUCCESS";
                    }
                    else
                    {
                        Label1.Text = "INVALID";
                    }
                }
               
            }
            else
            {
                Label1.Text = "username already exists";
            }

        }
    }
}