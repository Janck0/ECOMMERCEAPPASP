using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL2;


namespace Payment
{
    
    public class Service1 : IService1
    {
        InsertCls Ins = new InsertCls();
        UpdateCls Upd = new UpdateCls();
        public string Insert(Insertclass user)
        {
            int I=Ins.Payment_Insert(user.To_Acc, user.Fr_Acc, user.payM, user.paySts);
            return I.ToString();
        }
        //public string UpdateSts(Insertclass Py)
        //{
        //    int i = Upd.UpdatePaySts(Py.UPID);
        //    if (i == 1)
        //    {
        //        return "done";
        //    }
        //    else
        //    {
        //        return "not done";
        //    }
        //}


    }
}
