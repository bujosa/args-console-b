using CodeKatas;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void EmtyString()
        {
            var scheme = new string[0];
            var args = "";
            var control = new ArgsClass();
            var expected = new Exception("No scheme");
            var actual = control.Args(scheme, args);

        
        }
        [Test]
        public void OneScheme()
        {
            var scheme = new string[1];
            scheme[0] = "-p";
            var control = new ArgsClass();
            var expected = new Dictionary<string, bool>();
            expected.Add(scheme[0], false);

            var actual = control.Args(scheme, null);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwoScheme()
        {
            var scheme = new string[2];
            scheme[0] = "-p";
            scheme[1] = "-x";
            var control = new ArgsClass();
            var expected = new Dictionary<string, bool>();
            expected.Add(scheme[0], false);
            expected.Add(scheme[1], false);

            var actual = control.Args(scheme, null);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidScheme()
        {
            var scheme = new string[2];
            scheme[0] = "-px";
            scheme[1] = "-x";
            var control = new ArgsClass();
            var expected = new Dictionary<string, bool>();
            expected.Add(scheme[0], false);
            expected.Add(scheme[1], false);

            Assert.Throws<InvalidSchemeException>(() => control.Args(scheme, null));
        }

    }
}
