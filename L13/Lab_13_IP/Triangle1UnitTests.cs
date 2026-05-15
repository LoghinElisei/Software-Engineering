using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangles;

namespace Lab_13_IP
{
    [TestClass]
    public class Triangle1UnitTests : TriangleUnitTests
    {
        [TestInitialize]
        public override void Init()
        {
            _triangle = new Triangle1();     
        }

        
        

    }
}
