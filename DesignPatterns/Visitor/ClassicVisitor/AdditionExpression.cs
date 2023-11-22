﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ClassicVisitor
{
    public class AdditionExpression : Expression
    {
        public Expression Left;
        public Expression Right;

        public AdditionExpression(Expression left, Expression right)
        {
            Left = left ?? throw new ArgumentNullException(paramName: nameof(left));
            Right = right ?? throw new ArgumentNullException(paramName: nameof(right));
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
