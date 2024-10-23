using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using System.Data.SqlClient;
using System.Data;


namespace BLL2
{
    public class DeleteClass
    {
        ConClass Obj = new ConClass();
        public int DeleteCat(string ID)
        {
            string q = "delete from TABLE_CATEGORY where CAT_ID=" + ID + "";
            int i = Obj.fn_NonQUerrys(q);
            return i;
        }
        public int DeletProd(string ID)
        {
            string q = "delete from TABLE_PRODUCT where P_ID=" + ID + "";
            int i = Obj.fn_NonQUerrys(q);
            return i;
        }
        public int DeleteCart(string ID)
        {
            string q = "delete from TABLE_CART where C_ID=" + ID + "";
            int i = Obj.fn_NonQUerrys(q);
            return i;
        }
        public int ClearCart(string UID)
        {
            string q = "delete from TABLE_CART where USER_ID='" + UID + "'";
            int i = Obj.fn_NonQUerrys(q);
            return i;
        }
    }
}
