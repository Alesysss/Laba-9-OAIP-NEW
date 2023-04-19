using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9_OAIP_NEW
{
    public class OperatorMethod//Эльдар Рафаилович, я вас люблю <3, ВЫ - МИЛАШ
    {
        public delegate void EmptyOperatorMethod();
        public delegate void UnaryOperatorMethod(object operand);
        public delegate void BinaryOperatorMethod(object operand1, object operand2);
        public delegate void TrinaryOperatorMethod(object operand1, object operand2, object operand3);
    } 
}
