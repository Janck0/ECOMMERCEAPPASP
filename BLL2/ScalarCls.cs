using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL2
{
    public class ScalarCls
    {
        ConClass obj = new ConClass();
        public string check_reg()
        {
            string q = "select max(USER_ID) from TABLE_LOGIN";
            string Reg_id = obj.fn_ScalarQUerrys(q).ToString();

            return Reg_id;
        }
        public string check_count()
        {
            string q = "select count(USER_ID) from TABLE_LOGIN";
            string Count = obj.fn_ScalarQUerrys(q).ToString();

            return Count;
        }
        public string check_user(string Un)
        {
            string q = "select count(USER_ID) from TABLE_LOGIN where USERNAME='" + Un + "' ";
            string Count = obj.fn_ScalarQUerrys(q).ToString();
            return Count;
        }
        public string SelCatName(string id)
        {
            string q = "select C_NAME from TABLE_CATEGORY where CAT_ID=" + id + "";
            string catname = obj.fn_ScalarQUerrys(q);
            return catname;
        }
        public string Cart_Check(string UID, string value)
        {
            string q = "select count(C_ID) from TABLE_CART where P_ID=" + value + " and USER_ID='" + UID + "'";
            string check = obj.fn_ScalarQUerrys(q);
            return check;
        }
        public string Cart_Count(string UID)
        {
            string q = "select count(C_ID) from TABLE_CART where USER_ID='" + UID + "'";
            string check = obj.fn_ScalarQUerrys(q);
            return check;
        }
        public string Order_Count(string UID, string PID,string ORDKY)
        {
            string q = "select count(P_ID) from TABLE_ORDERS where USER_ID='" + UID + "' and P_ID='" + PID + "' and O_ORDERKEY='"+ORDKY+"'";
            string check = obj.fn_ScalarQUerrys(q);
            return check;
        }
        public string BankUsr_Count(string ID)
        {
            string q = "select count(ID) from TABLE_BANKACC where BankID='" + ID + "'";
            string check = obj.fn_ScalarQUerrys(q);
            return check;
        }
        public string PaymentCheck(string UID)
        {
            string q = "select count(*) from TABLE_PAYMENT where From_Acc='" + UID + "' and Pay_Status='NOT DONE'";
            string check = obj.fn_ScalarQUerrys(q);
            return check;
        }
        public string CheckPySts(string CID)
        {
            string q = "select count(PAY_ID) from TABLE_PAYMENT where To_Acc='" + CID + "' and Pay_Status='NOT DONE'";
            string Count = obj.fn_ScalarQUerrys(q);
            return Count;
        }
        public string Bill_Count(string UID, string OID)
        {
            string q = "select count(P_ID) from TABLE_BILL where USER_ID='" + UID + "' and O_ID='" + OID + "'";
            string check = obj.fn_ScalarQUerrys(q);
            return check;
        }
    }
}
