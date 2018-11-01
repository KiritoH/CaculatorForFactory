using com.yww.singleOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Created by yww
 */
namespace com.yww.singleOperatorFactory
{
    public class TakeReciprocalOperatorFactory : SingleOperatorFactory
    {
        public override SingleOperator GetOperator()
        {
            return new TakeReciprocalOperator();
            throw new NotImplementedException();
        }
    }
}
