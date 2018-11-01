using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Created by yww
 */
namespace com.yww.doubleOperator
{
    //乘法
    public class MutiplicationOperator : DoubleOperator
    {
        public override double operate(double x, double y)
        {
            var result = x * y;
            return result;
            throw new NotImplementedException();
        }
    }
}
