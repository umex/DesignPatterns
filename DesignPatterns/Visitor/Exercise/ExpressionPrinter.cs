﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Exercise
{
    public class ExpressionPrinter : ExpressionVisitor
    {
        private StringBuilder sb = new StringBuilder();

        public override void Visit(Value value)
        {
            sb.Append(value.TheValue);
        }

        public override void Visit(AdditionExpression ae)
        {
            sb.Append("(");
            ae.LHS.Accept(this);
            sb.Append("+");
            ae.RHS.Accept(this);
            sb.Append(")");
        }

        public override void Visit(MultiplicationExpression me)
        {
            me.LHS.Accept(this);
            sb.Append("*");
            me.RHS.Accept(this);
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }

}
