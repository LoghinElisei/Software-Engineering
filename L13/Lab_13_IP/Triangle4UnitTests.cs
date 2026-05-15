using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangles;

namespace Lab_13_IP
{
    [TestClass]
    public class Triangle4UnitTests : TriangleUnitTests
    {
        [TestInitialize]
        public override void Init()
        {
            _triangle = new Triangle4();
        }
    }
}
