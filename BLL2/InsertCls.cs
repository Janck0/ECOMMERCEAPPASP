using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace BLL2
{
    public class InsertCls
    {

        ConClass obj = new ConClass();
        SelectCls Sel = new SelectCls();
            public int user_insert(string UID, string name, string EMAIL, string AGE, string PHNO, string ADDRESS, string DIST, string STATE, string PIN, string STATUS)
            {
                string q = "insert into TABLE_CUSTOMERS values('" + UID + "','" + name + "','" + EMAIL + "'," + AGE + "," + PHNO + ",'" + ADDRESS + "','" + DIST + "','" + STATE + "'," + PIN + ",'" + STATUS + "')";
                int i = obj.fn_NonQUerrys(q);
                return i;
            }
            public int admin_insert(string UID, string name, string EMAIL, string PHNO, string STATUS)
            {
                string q = "insert into TABLE_ADMIN values('" + UID + "','" + name + "','" + EMAIL + "'," + PHNO + ",'" + STATUS + "')";
                int i = obj.fn_NonQUerrys(q);
                return i;
            }
            public int login_insert(string UID, string UNAME, string PWD, string UTYP, string sts)
            {
                string q = "insert into TABLE_LOGIN values('" + UID + "','" + UNAME + "','" + PWD + "','" + UTYP + "','" + sts + "')";
                int i = obj.fn_NonQUerrys(q);
                return i;
            }
            public int Category_insert(string c_name, string c_des,string c_img)
            {
            string q = "insert into TABLE_CATEGORY values('" + c_name + "','" + c_des + "','" + c_img + "')";
            int i = obj.fn_NonQUerrys(q);
            return i;
            }
        public int Product_insert(string c_name, string cat_id, string p_desc,string p_img, string p_price,string p_stock)
        {
            string q = "insert into TABLE_PRODUCT values('" + c_name + "',"+cat_id+",'" + p_desc + "','"+p_img+"',"+p_price+","+p_stock+")";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int AddCart(string UID, string PID)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string q = "insert into TABLE_CART values('"+UID+"',"+PID+",'"+ dateTime.ToString("yyyy/MM/dd") + "',1)";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int Order_Insert(string UID,string P_ID,string Nos,string Total,string ORKEY)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime dateTime2 = dateTime.AddDays(2);
            string q = "insert into TABLE_ORDERS values('"+UID+"','"+P_ID+"',"+Nos+",'"+dateTime.ToString("yyyy/MM/dd") +"',"+Total+",'DONE','NOT DELIVERD','"+dateTime2.ToString("yyyy/MM/dd")+"','"+ORKEY+"')";//STS=NOTDONE,COD,DONE
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int Payment_Insert(string From, string To, string Amt, string Sts)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime dateTime2 = dateTime.AddDays(2);
            string q = "insert into TABLE_PAYMENT values('"+From+"','"+To+"',"+Amt+",'"+Sts+"','"+dateTime.ToString("yyyy/MM/dd")+"')";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int Bill_Insert(string O_ID,string P_ID, string NOS,string UID,string TOTAL,string BILLID)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            
            string q = "insert into TABLE_BILL values('" + O_ID + "','" + P_ID + "'," + NOS + ",'"+UID+"','" + dateTime.ToString("yyyy/MM/dd") + "'," + TOTAL + ",'"+BILLID+"')";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public int Feedback_Insert(string UID,string MSG)
        {
            SqlDataReader Dr = Sel.UserInfo(UID);
            string Email="";
            string Name="";
            while (Dr.Read())
            {
                Email=Dr["C_EMAIL"].ToString();
                Name = Dr["C_Name"].ToString();

            }

            string q = "insert into TABLE_FEEDBACK values('"+Name+"','"+UID+"','"+Email+"','"+MSG+"','NOT REPLIED')";
            int i = obj.fn_NonQUerrys(q);
            return i;
        }
        public string InsertBillTotal(string ID,string Total)
        {
            string q = "insert into TABLE_BILLTOTAL values('" + ID + "','" + Total + "')";
            int i = obj.fn_NonQUerrys(q);
            return "o";
        }
    }
}
