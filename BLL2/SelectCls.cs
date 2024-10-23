using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DLL;

namespace BLL2
{
    
    public class SelectCls
    {
        ConClass obj = new ConClass();
        public SqlDataReader Login_User(string Un,string Pwd)
        {
            string q = "select USER_ID from TABLE_LOGIN where USERNAME='"+Un+"' and PASSWORD='"+Pwd+"' and USERTYPE='USER'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
            
        }
        public SqlDataReader Login_Admin(string Un, string Pwd)
        {
            string q = "select USER_ID from TABLE_LOGIN where USERNAME='" + Un + "' and PASSWORD='" + Pwd + "' and USERTYPE='ADMIN'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public DataSet GridViewSel()
        {
            string q = "select * from TABLE_CATEGORY";
            DataSet Ds= obj.fn_Dataset(q);
            return Ds;
        }
        public DataTable CatSel()
        {
            string q = "select CAT_ID,C_NAME from TABLE_CATEGORY";
            DataTable Ds = obj.fn_DataTable(q);
            return Ds;
        }
        public DataSet FeedSel()
        {
            string q = "select * from TABLE_FEEDBACK";
            DataSet Ds = obj.fn_Dataset(q);
            return Ds;
        }

        public DataSet ProdGrid(string id)
        {
            string q = "select P_ID,P_NAME,P_DESCRIPTION,P_IMAGE,P_PRICE,P_STOCK from TABLE_PRODUCT where CAT_ID="+id+"";
            DataSet Ds = obj.fn_Dataset(q);
            return Ds;
        }
        //CATEGIRY SEL
        public DataTable CatAllSel()
        {
            string q = "select * from TABLE_CATEGORY";
            DataTable Dt = obj.fn_DataTable(q);
            return Dt;
        }
        //PRODUCT SEL
        public DataTable ProdAllSel(string Id)
        {
            string q = "select * from TABLE_PRODUCT where CAT_ID="+Id+"";
            DataTable Dt = obj.fn_DataTable(q);
            return Dt;
        }
       //CART SELECT
        public DataTable CartAllSel(string ID)
        {
            string q = "select TABLE_PRODUCT.P_NAME,TABLE_PRODUCT.P_IMAGE, TABLE_PRODUCT.P_PRICE, TABLE_CATEGORY.C_NAME,TABLE_CART.C_ID, TABLE_CART.COUNT FROM TABLE_PRODUCT JOIN TABLE_CATEGORY ON TABLE_PRODUCT.CAT_ID=TABLE_CATEGORY.CAT_ID JOIN TABLE_CART ON TABLE_PRODUCT.P_ID=TABLE_CART.P_ID where TABLE_PRODUCT.P_ID in (SELECT P_ID FROM TABLE_CART where USER_ID='"+ID+"')";
            DataTable Dt = obj.fn_DataTable(q);
            return Dt;
        }
        public DataTable SingProdSel(string ID)
        {
            string q = "select * from TABLE_PRODUCT where P_ID=" + ID + "";
            DataTable Dt = obj.fn_DataTable(q);
            return Dt;
        }
        public SqlDataReader CartSum(string ID)
        {
            string q = "select TABLE_PRODUCT.P_PRICE, TABLE_CART.COUNT FROM TABLE_PRODUCT JOIN TABLE_CART ON TABLE_PRODUCT.P_ID=TABLE_CART.P_ID where TABLE_CART.USER_ID='"+ID+"';  ";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public SqlDataReader UserInfo(string ID)
        {
            string q = "select * from TABLE_CUSTOMERS where USER_ID='"+ID+"'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }

        public DataTable CheckOut(string Id)
        {
            string q = "SELECT TABLE_CART.P_ID,TABLE_CART.C_ID, TABLE_PRODUCT.P_NAME, TABLE_PRODUCT.P_PRICE, TABLE_PRODUCT.CAT_ID, TABLE_CART.COUNT,TABLE_PRODUCT.P_PRICE * TABLE_CART.COUNT as SUB_TOTAL from TABLE_CART INNER JOIN TABLE_PRODUCT ON TABLE_CART.P_ID = TABLE_PRODUCT.P_ID WHERE TABLE_CART.USER_ID = '"+Id+"'";
            DataTable Dt = obj.fn_DataTable(q);
            return Dt;
        }
        public SqlDataReader Bank_Login(string Un, string Pwd)
        {
            string q = "select BankID from TABLE_BANKACC where BankID='" + Un + "' and Password='" + Pwd + "'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public SqlDataReader BankUserInfo(string ID)
        {
            string q = "select * from TABLE_BANKACC where BankID='"+ID+"'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public SqlDataReader PaymentDetails(string ID)
        {
            string q = "select * from TABLE_PAYMENT where From_Acc='" + ID + "' and Pay_Status='NOT DONE'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public SqlDataReader PaymentDoneChk(string Fr, string To,string Amt)
        {
            string q = "select Pay_Status from TABLE_PAYMENT where From_Acc='"+Fr+"' and To_Acc='"+To+"' and Pay_Amt='"+Amt+"' ORDER BY PAY_ID DESC"; 
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public string BalanceAmt(string ID)
        {
            string q = "select Acc_Balance from TABLE_BANKACC where BankID='" + ID + "'";
            SqlDataReader Dr = obj.fn_Reader(q);
            string Bl = "";
            while (Dr.Read())
            {
                Bl=Dr["Acc_Balance"].ToString();
            }
            return Bl;

        }
        public int PayAmt(string ID)
        {
            string q = "select Pay_Amt from TABLE_PAYMENT where PAY_ID=" + ID + " and Pay_Status='DONE'";
            SqlDataReader Dr = obj.fn_Reader(q);
            string Bl = "";
            while (Dr.Read())
            {
                Bl = Dr["Pay_Amt"].ToString();
            }
            int BN = Convert.ToInt32(Bl);
            return BN;

        }
        public DataTable OrderGet(string Id)
        {
            string q = "select * from TABLE_ORDERS where USER_ID='"+Id+"'";
            DataTable Dt = obj.fn_DataTable(q);
            return Dt;
        }
        public SqlDataReader ProductStock(string PID)
        {
            string q = "select P_STOCK from TABLE_PRODUCT where P_ID=" + PID + "";
            SqlDataReader Count = obj.fn_Reader(q);
            return Count;
        }
        public string FeedBackGet(string id)
        {
            string Em = "";
            string q = "select EMAIL from TABLE_FEEDBACK where ID="+id+"";
            SqlDataReader Ds = obj.fn_Reader(q);
            while (Ds.Read())
            {
                Em=Ds["EMAIL"].ToString();

            }
            return Em;
        }
        public SqlDataReader FinalOrderList(string ID)
        {
            string q = "select TABLE_ORDERS.O_NOOFITEMS,TABLE_ORDERS.O_TOTALPRICE,TABLE_PRODUCT.P_NAME from TABLE_ORDERS inner join TABLE_PRODUCT on TABLE_PRODUCT.P_ID=TABLE_ORDERS.P_ID where TABLE_ORDERS.O_ORDERKEY='"+ID+"'";
            SqlDataReader Dr = obj.fn_Reader(q);
            return Dr;
        }
        public string BillTotGet(string ID)
        {
            string Total = "";
            string q = "select TOTALAMT from TABLE_BILLTOTAL where BILL_KEY='" + ID + "'";
            SqlDataReader Dr = obj.fn_Reader(q);
            while (Dr.Read())
            {
                Total = Dr["TOTALAMT"].ToString();
            }
            return Total;

        }

    }
}
 