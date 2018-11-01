using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Created by yww
 */
namespace com.yww.singleOperator
{
    //取倒数
    public class TakeReciprocalOperator : SingleOperator
    {
        public override double operate(double x)
        {
            var result = 1 / x;
            return result;
            throw new NotImplementedException();
        }
    }
}
