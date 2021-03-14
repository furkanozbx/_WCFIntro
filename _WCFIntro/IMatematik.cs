using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace _WCFIntro
{
    [ServiceContract]
    public interface IMatematik
    {
        [OperationContract]
        int Topla(int a, int b);
        [OperationContract]
        int Carp(int a, int b);
        [OperationContract]
        int Bol(int a, int b);
        [OperationContract]
        int Cikar(int a, int b);
    }
}
