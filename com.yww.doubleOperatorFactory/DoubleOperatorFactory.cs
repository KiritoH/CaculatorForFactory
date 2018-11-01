using com.yww.doubleOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.yww.doubleOperatorFactory
{
    public abstract class DoubleOperatorFactory 
    {
        public abstract DoubleOperator GetOperator();
    }
}
