﻿using Aptacode.Expressions;
using Aptacode.Expressions.Integer;
using Aptacode.StateNet.Engine.Transitions;
using Aptacode.StateNet.PatternMatching.Expressions;
using System;
using System.Collections.Generic;
using System.Text;
using Aptacode.Expressions.List.Extensions;
using Aptacode.Expressions.Numeric;

namespace Aptacode.StateNet.PatternMatching.Expressions
{
    public class TransitionCount : UnaryNumericExpression<int, TransitionHistory>
    {
        public TransitionCount(string state, string input) : base(new Matches(new Pattern(state, input)).Count()) { }

        public override int Interpret(TransitionHistory context)
        {
            return Expression.Interpret(context);
        }
    }
}