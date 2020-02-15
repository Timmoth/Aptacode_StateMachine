﻿using NUnit.Framework;


namespace Aptacode.StateNet.Tests
{
    public class NodeChooserTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void SetWeightTests()
        {
            var nodeChooser = new NodeChooser();

            Assert.AreEqual(0, nodeChooser.TotalWeight);

            var d1 = new Node("D1");
            var d2 = new Node("D2");

            nodeChooser.UpdateWeight(d1, 1);
            nodeChooser.UpdateWeight(d2, 2);

            Assert.AreEqual(3, nodeChooser.TotalWeight);
            Assert.AreEqual(1, nodeChooser.GetWeight(d1));
            Assert.AreEqual(2, nodeChooser.GetWeight(d2));

            nodeChooser.UpdateWeight(d1, 2);
            nodeChooser.UpdateWeight(d2, 0);

            Assert.AreEqual(2, nodeChooser.TotalWeight);
            Assert.AreEqual(2, nodeChooser.GetWeight(d1));
            Assert.AreEqual(0, nodeChooser.GetWeight(d2));
        }

        //TODO
        // ToString Test
        // GetNext probability distrobution Tests
        // SetWeight new format
        // SetWeight Fluent API?
    }
}