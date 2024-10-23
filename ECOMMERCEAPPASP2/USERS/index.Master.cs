using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BLL2;


namespace ECOMMERCEAPPASP2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        ScalarCls Sec = new ScalarCls();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UID"] != null)
            {
                string UID = Session["UID"].ToString();
                string C=Sec.Cart_Count(UID);
                CartCou.Text = C;
            }



        }


    }
}