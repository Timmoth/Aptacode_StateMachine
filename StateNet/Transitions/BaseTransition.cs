﻿using System;
using System.Linq;

namespace Aptacode.StateNet.Transitions
{
    public abstract class BaseTransition
    {
        protected BaseTransition(string origin, string input, string message)
        {
            Origin = origin;
            Input = input;
            Message = message;
        }

        public abstract string Apply();

        public abstract override string ToString();

        /// <summary>
        /// The Input which when applied to the 'State' causes the transition
        /// </summary>
        public string Input { get; }

        /// <summary>
        /// A message describing the transition
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The starting state which the transition is relating to
        /// </summary>
        public string Origin { get; }
    }
}