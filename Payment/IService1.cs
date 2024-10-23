using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Payment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Insert(Insertclass User);
        [OperationContract]
        string Update();
       
        
       
        
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Insertclass
    {
        string FromAcc = string.Empty;
        string ToAcc = string.Empty;
        string PayM = string.Empty;
        string PaySts = "NOT DONE";
        string ID = string.Empty;
        //string UPD = string.Empty;

        [DataMember]
        public string Fr_Acc
        {
            get { return FromAcc; }
            set { FromAcc=value; }
        }


        [DataMember]
        public string To_Acc
        {
            get { return ToAcc; }
            set { ToAcc=value; }
        }
        [DataMember]
        public string payM
        {
            get { return PayM; }
            set { PayM=value; }
        }
        [DataMember]
        public string paySts
        {
            get { return PaySts; }
            set {PaySts=value; }
        }
        [DataMember]
        public string UPID
        {
            get { return ID; }
            set { ID = value; }
        }

    }
    
}
