﻿using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.Integer;
using Aptacode.Expressions.List.IntegerListOperators.Extensions;
using Aptacode.Expressions.List.ListOperators.Extensions;
using Aptacode.StateNet.Engine.Transitions;

namespace Aptacode.StateNet.PatternMatching.Expressions;

public record TransitionCountFromStart : UnaryExpression<int, TransitionHistory>
{
    public TransitionCountFromStart(string state, string input, int takeFirst) : base(
        new Matches(new Pattern(state, input)).TakeFirst(new ConstantInteger<TransitionHistory>(takeFirst))
            .Count())
    {
    }

    public override int Interpret(TransitionHistory context)
    {
        return Expression.Interpret(context);
    }
}