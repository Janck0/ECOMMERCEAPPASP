using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using System.Data;
using System.Data.SqlClient;

namespace BLL2
{
    public class UpdateCls
    {
        ConClass obj = new ConClass();
        SelectCls sel = new SelectCls();
        public int CatUpd(int id,string v1, string v2, string v3)
        {
            string q = "update TABLE_CATEGORY set C_NAME='" + v1 + "',C_DESCRIPTION='" + v2 + "',C_IMAGE='" + v3 + "' where CAT_ID=" + id + "";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int ProdUpd(int id, string v1, string v2, string v3,string v4, string v5)
        {
            string q = "update TABLE_PRODUCT set P_NAME='" + v1 + "',P_DESCRIPTION='" + v2 + "',P_IMAGE='" + v3 + "',P_PRICE="+v4+",P_STOCK="+v5+" where P_ID=" + id + "";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int CartUpd(string id,string c)
        {
            string q = "update TABLE_CART set COUNT="+c+" where C_ID="+id+"" ;
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int UpdatePaySts(string ID)
        {
            string q = "update TABLE_PAYMENT set Pay_Status='DONE' where PAY_ID=" + ID + "";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int UpdateBalanceAmt(string ID, int Bal)
        {
            string q = "update TABLE_BANKACC set Acc_Balance=" + Bal + " where BankID='" + ID + "'";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int UpdateStock(string ID,string Count)
        {
            SqlDataReader Dr = sel.ProductStock(ID);
            int i = 0;
            string Cnt="0";
            int newst = 0;
            int GetSt = Convert.ToInt32(Count);
            while (Dr.Read())
            {
                Cnt=Dr["P_STOCK"].ToString();
            }
            int OldSt = Convert.ToInt32(Cnt);
            if (OldSt != 0)
            {
                newst = OldSt - GetSt;
                string q = "update TABLE_PRODUCT set P_STOCK=" + newst + " where P_ID=" + ID + " ";
                i=obj.fn_NonQUerrys(q);
            }
            return i;
            
        }
        public int FeedUpdate(string id)
        {
            string q = "update TABLE_FEEDBACK set STATUS='REPLIED' where ID=" + id + " ";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
    }
}
