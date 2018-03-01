
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Unit.Test
{
    [TestFixture()]
    [Author("Gruppe 35")]
    public class Class1
    {
        private SimpleTestClass _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new SimpleTestClass();
        }

        [TestCase(2, 5, 7)]
        [TestCase(4, 0, 4)]
        public void Add_AddNumber1AndNumber2(int a, int b, int c)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(c));
        }
    }
}
