﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Created by yww
 */
namespace com.yww.singleOperator
{
    //取相反数
    public class TakeOppositeNumberOperator : SingleOperator
    {
        public override double operate(double x)
        {
            var result = 0 - x;
            return result;
            throw new NotImplementedException();
        }
    }
}
