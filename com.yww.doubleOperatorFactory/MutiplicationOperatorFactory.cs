﻿using com.yww.doubleOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yww.doubleOperatorFactory
{
    public class MutiplicationOperatorFactory : DoubleOperatorFactory
    {
        public override DoubleOperator GetOperator()
        {
            return new MutiplicationOperator();
            throw new NotImplementedException();
        }
    }
}
