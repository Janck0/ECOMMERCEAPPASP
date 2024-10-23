using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL2;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	InsertCls Ins = new InsertCls();
	UpdateCls Upd = new UpdateCls();
	SelectCls Sel = new SelectCls();
	ScalarCls Scl = new ScalarCls();
	public string PaymentDone(string ID)
	{
		int I = Upd.UpdatePaySts(ID);//to update payment done
		return I.ToString();
	}
	public string InsertPayment(string FrAcc, string ToAcc, string Amt, string PySts)
	{
		int I = Ins.Payment_Insert(FrAcc, ToAcc, Amt, PySts);//insert payment req
		return "1";
	}
	public string CheckPayment(string Comp)
    {
		string Count = Scl.CheckPySts(Comp);
        if (Count != "0")
        {
			return "NOTEDONE";
        }
        else
        {
			return "DONE";
        }
    }

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
