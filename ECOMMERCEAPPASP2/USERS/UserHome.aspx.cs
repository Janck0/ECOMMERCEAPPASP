using BLL2;
using System;
using System.Data;

namespace ECOMMERCEAPPASP2
{
    public partial class Index : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable Dt = Sel.CatAllSel();
            ListView1.DataSource = Dt;
            ListView1.DataBind();

        }

    }
}