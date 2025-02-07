﻿using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List.IntegerListOperators.Extensions;
using Aptacode.Expressions.List.ListOperators.Extensions;
using Aptacode.StateNet.Engine.Transitions;

namespace Aptacode.StateNet.PatternMatching.Expressions;

public record TransitionCountFromEnd : UnaryExpression<int, TransitionHistory>
{
    public TransitionCountFromEnd(string state, string input, int takeLast) : base(
        new Matches(new Pattern(state, input)).TakeLast(new ConstantInteger<TransitionHistory>(takeLast))
            .Count())
    {
    }

    public override int Interpret(TransitionHistory context)
    {
        return Expression.Interpret(context);
    }
}