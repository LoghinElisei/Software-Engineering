using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangles;

namespace Lab_13_IP
{
    [TestClass]
    public class Triangle3UnitTests : TriangleUnitTests
    {
        [TestInitialize]
        public override void Init()
        {
            _triangle = new Triangle3();
        }
    }
}
