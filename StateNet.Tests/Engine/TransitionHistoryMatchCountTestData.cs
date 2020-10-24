﻿using System.Collections;
using System.Collections.Generic;

namespace StateNet.Tests.Engine {
    public class TransitionHistoryMatchCountTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { "a", new List<(string, string)>{ ("1", "b"), }, "a:1", 1},
            new object[] { "a", new List<(string, string)>{ ("1", "b"), ("2", "a") }, "b:2", 1},
            new object[] { "a", new List<(string, string)>{ ("2", "b"), ("1", "a"), ("1", "a") }, "1:a", 2},
            new object[] { "a", new List<(string, string)>{ ("1", "b"), ("1", "c"), ("1", "a") }, "1", 3},
            new object[] { "a", new List<(string, string)>{ ("1", "b"), ("1", "c"), ("1", "a") }, "1", 3},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}