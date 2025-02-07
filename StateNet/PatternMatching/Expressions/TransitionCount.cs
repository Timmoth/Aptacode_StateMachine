﻿using Aptacode.Expressions.GenericExpressions;
using Aptacode.Expressions.List.IntegerListOperators.Extensions;
using Aptacode.StateNet.Engine.Transitions;

namespace Aptacode.StateNet.PatternMatching.Expressions;

public record TransitionCount : UnaryExpression<int, TransitionHistory>
{
    public TransitionCount(string state, string input) : base(new Matches(new Pattern(state, input)).Count())
    {
    }

    public override int Interpret(TransitionHistory context)
    {
        return Expression.Interpret(context);
    }
}