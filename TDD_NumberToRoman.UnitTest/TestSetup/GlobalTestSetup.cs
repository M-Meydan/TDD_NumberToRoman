using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_NumberToRoman.UnitTest.TestSetup
{
    [TestFixture]
    public class GlobalTestSetup
    {
        [OneTimeSetUp]
        public void Init()
        {
            //UnityConfig.RegisterTypes(); 
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
        }
    }
}
