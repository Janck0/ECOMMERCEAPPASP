using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL2;
using ECOMMERCEAPPASP2.BalanceCheck;







namespace ECOMMERCEAPPASP2.BankPages
{
    public partial class BankHome : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        ScalarCls Sc = new ScalarCls();
        UpdateCls Upd = new UpdateCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["BnkID"] != null)
            {
                string UID = Session["BnkID"].ToString();
                SqlDataReader Dr=Sel.BankUserInfo(UID);
                while (Dr.Read())
                {
                    Lbl1.Text = Dr["Acc_Name"].ToString();
                    Lbl2.Text = Dr["Acc_no"].ToString();
                    Lbl4.Text = Dr["Acc_Balance"].ToString();
                }
                Lbl3.Text = Sc.PaymentCheck(UID);
            }
           
        }

        protected void PayReq_Click(object sender, EventArgs e)
        {
            string UID = "";
            if (Session["BnkID"] != null)
            {
                UID = Session["BnkID"].ToString();
            }
            PayReqPanel.Visible = true;
            List1.DataSource = Sel.PaymentDetails(UID);
            List1.DataBind();
            
        }
        protected void PayNow(object sender, EventArgs e)
        {

            BalanceCheck.ServiceClient Obj = new BalanceCheck.ServiceClient();//wcf

            string s = e.ToString();
            LinkButton btn = (LinkButton)sender;
            string ID = btn.CommandArgument;
            string i=Obj.PaymentDone(ID);//wcf
            if (i == "1")
            {
                string Balance = Sel.BalanceAmt(Session["BnkID"].ToString());
                int BalInt = Convert.ToInt32(Balance);
                int PayAmt = Sel.PayAmt(ID);
                int newAmt = BalInt - PayAmt;
                Upd.UpdateBalanceAmt(Session["BnkID"].ToString(), newAmt);
                btn.Text = "Payment Done";
                btn.Enabled = false;
                Session["Pysts"] = "DONE";
            }
           

            //Client.Update(Upd);


        }

    }
}