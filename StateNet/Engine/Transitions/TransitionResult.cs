﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aptacode.StateNet.Engine.Transitions
{
    public class TransitionResult
    {
        public static TransitionResult Fail(string message) => new TransitionResult(message, false, null);
        public static TransitionResult Ok(Transition transition, string message) => new TransitionResult(message, true, transition);

        private TransitionResult(string message, bool success, Transition? transition)
        {
            Message = message;
            Success = success;
            Transition = transition;
        }

        public string Message { get; }
        public bool Success { get; }
        public Transition? Transition { get; }
    }
}