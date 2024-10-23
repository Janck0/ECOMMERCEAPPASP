using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL2;

namespace ECOMMERCEAPPASP2
{
    public partial class UserRegn : System.Web.UI.Page
    {
        InsertCls Obj = new InsertCls();
        ScalarCls Obj2 = new ScalarCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string regid = Obj2.check_reg().ToString();
            string nregid = "";
            string u=Obj2.check_user(TextBox9.Text);
            if (u == "0")
            {
                if (regid == "")
                {
                    nregid = "USER" + 1.ToString();
                }
                else
                {
                    string c = Obj2.check_count();
                    nregid = "USER" + c.ToString();

                }
                int i = Obj.user_insert(nregid,
                                        TextBox1.Text, TextBox2.Text,
                                        TextBox3.Text, TextBox4.Text, TextBox5.Text,
                                        TextBox6.Text, TextBox7.Text, TextBox8.Text, "ACTIVE");
                if (i == 1)
                {
                    int j = Obj.login_insert(nregid, TextBox9.Text, TextBox10.Text, "USER", "ACTIVE");
                    Label1.Text = "REGISTRATION SUCCESS";

                }
            }
            else
            {
                Label1.Text = "USERNAME ALREADY EXIST";
            }
            

        }
    }
}