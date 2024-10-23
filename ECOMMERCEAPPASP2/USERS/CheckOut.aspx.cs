using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL2;
using System.Data.SqlClient;
using System.Data;
using ECOMMERCEAPPASP2.ServiceReference4;
using ECOMMERCEAPPASP2.ServiceReference1;

namespace ECOMMERCEAPPASP2.USERS
{
    public partial class CheckOut : System.Web.UI.Page
    {
        SelectCls Sel = new SelectCls();
        InsertCls Ins = new InsertCls();
        ScalarCls Scl = new ScalarCls();
        DeleteClass Del = new DeleteClass();
        UpdateCls Upd = new UpdateCls();
        DataTable Dt = new DataTable();
        DataTable Bt = new DataTable();
        string To;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] != null)
            {
                string UID = Session["UID"].ToString();
                
                SqlDataReader Dr = Sel.UserInfo(UID);
                while (Dr.Read())
                {
                    fName.Text = Dr["C_NAME"].ToString();
                    StreetAddress.Text = Dr["C_ADDRESS"].ToString();
                    PostCode.Text = Dr["C_PINCODE"].ToString();
                    District.Text = Dr["C_DISTRICT"].ToString();
                    State.Text = Dr["C_STATE"].ToString();
                    PhoneNo.Text = Dr["C_PHNO"].ToString();
                    Email.Text = Dr["C_EMAIL"].ToString();

                }
                Dt = Sel.CheckOut(UID);
                int Sum = Convert.ToInt32(Dt.Compute("SUM(SUB_TOTAL)",String.Empty));
                //Session["FINALSUM"] = Sum;
                To = Sum.ToString();
                if (Sum!=0)
                {
                    Session["TotalAmt"] = Sum.ToString();
                    
                }
                ChkLbl.Text = Sum.ToString();
                TotalAmt.Text = Sum.ToString();
                PayBank.Text = "Pay ₹" + Sum + "";
                Session["TOTALAMT"] = Sum.ToString();
                Session["Pysts"] = "NOT DONE";
                PlaceOrdr.Enabled = false;
                string PyC = Scl.CheckPySts("EssenseStore");
                if (PyC == "0")
                {
                    PlaceOrdr.Enabled = true;
                }
                    CheckOutList.DataSource = Dt;
                CheckOutList.DataBind();
                string Chk = "";
                if (Session["BankID"] != null)
                {
                    SqlDataReader Dr2 = Sel.PaymentDoneChk(Session["BankID"].ToString(), "EssenseStore", Sum.ToString());
                    while (Dr2.Read())
                    {
                        Chk = Dr2["Pay_Status"].ToString();
                    }
                    if (Chk == "DONE")
                    {

                        PyChk.Visible = false ;
                    }
                }
                
            }
        }
        //public void OrderDataTable(DataTable Dt)
        //{
        //    if (Session["UID"] != null)
        //    {
        //        string UID = Session["UID"].ToString();
        //        foreach (DataRow row in Dt.Rows)
        //        {
        //            string Chk = Scl.Order_Count(UID, row["P_ID"].ToString());
        //            if (Chk == "0")
        //            {
        //                Ins.Order_Insert(UID, row["P_ID"].ToString(), row["COUNT"].ToString(), row["SUB_TOTAL"].ToString());
        //            }

        //        }
        //    }
        //}

        protected void PlaceOrdr_Click(object sender, EventArgs e)
        {
            string PyC= Scl.CheckPySts("EssenseStore");
            if (PyC == "0")
            {
                
                
                PlaceOrdr.Enabled = true;
                if (Session["UID"] != null)
                {
                    string UID = Session["UID"].ToString();
                    string ORKy = UID + DateTime.Now.ToString("yyyyMMddHHmmssffff");
                    Session["ORKEY"] = ORKy;
                    foreach (DataRow row in Dt.Rows)
                    {
                        string Chk = Scl.Order_Count(UID, row["P_ID"].ToString(),ORKy);
                        if (Chk == "0")
                        {
                            Ins.Order_Insert(UID, row["P_ID"].ToString(), row["COUNT"].ToString(), row["SUB_TOTAL"].ToString(),ORKy);
                        }

                    }
                    Bt = Sel.OrderGet(UID);
                    if (Bt != null)
                    {
                        string BLid = UID + DateTime.Now.ToString("yyyyMMddHHmmssffff");
                        Session["BILLID"] = BLid;
                        foreach (DataRow row in Bt.Rows)
                        {
                            string Chk = Scl.Bill_Count(UID, row["ORD_ID"].ToString());
                            if (Chk == "0")
                            {
                                int i=Ins.Bill_Insert(row["ORD_ID"].ToString(), row["P_ID"].ToString(), row["O_NOOFITEMS"].ToString(), UID, row["O_TOTALPRICE"].ToString(),BLid);
                              
                                Upd.UpdateStock(row["P_ID"].ToString(), row["O_NOOFITEMS"].ToString());
                                
                                
                            }
                        }
                        //string Total = Session["FINALTOTAL"].ToString();
                        Ins.InsertBillTotal(BLid, To);
                        Del.ClearCart(UID);
                    }
                    Response.Redirect("FinalFeedback.aspx");
                    
                }
                //display check out page note

            }
            else
            {

                Response.Write("<script>alert('Payment Not Done')</script>");
            }
             
    
            
        }
        protected void PayBank_Click(object sender, EventArgs e)
        {
            ServiceReference4.ServiceClient Obj = new ServiceReference4.ServiceClient();//wcf object creation wcf

            Session["BankID"] = BankID.Text;
            string Fr = BankID.Text;
            string To = "EssenseStore";
            string Amt = "";
            
            if (Session["TOTALAMT"] != null)
            {
                  Amt= Session["TOTALAMT"].ToString();
            }
            string Sts = "NOT DONE";
            string i = Obj.InsertPayment(Fr,To,Amt,Sts);//wcf insert payment req
            
            Response.Redirect("~/BankPages/BankLogin.aspx");
        }
    }
}