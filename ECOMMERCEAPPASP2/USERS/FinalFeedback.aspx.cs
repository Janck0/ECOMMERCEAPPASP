using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL2;
using System.Data;
using System.Data.SqlClient;


namespace ECOMMERCEAPPASP2.USERS
{
    public partial class FinalFeedback : System.Web.UI.Page
    {
        string UID = "USER0";
        InsertCls Ins = new InsertCls();
        SelectCls Sel = new SelectCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderDet.DataSource = Sel.FinalOrderList(Session["ORKEY"].ToString());
            OrderDet.DataBind();
            //Session["ORKEY"];
            SqlDataReader Pd=Sel.UserInfo(UID);
            while (Pd.Read())
            {
                //NAMEFD.Text = Pd["C_NAME"].ToString();
                Address.Text = Pd["C_NAME"].ToString()+","+Pd["C_ADDRESS"].ToString() + "," + Pd["C_DISTRICT"].ToString() + "," + Pd["C_STATE"].ToString() + "," + "<br>PIN:" + Pd["C_PINCODE"].ToString();
            }
            Ttl.Text=Sel.BillTotGet(Session["BILLID"].ToString());

        }

        protected void SNDFD_Click(object sender, EventArgs e)
        {
            string Na=NAMEFD.Text;
            string Msg = MSGFD.Text;
            Ins.Feedback_Insert(UID, Msg);
            

        }

        
    }
}