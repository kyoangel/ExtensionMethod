using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSStringExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSStringExtension.Tests
{
    [TestClass()]
    public class TSStringExtensionTests
    {
        [TestMethod()]
        public void PhoneNumLengthNotEqualsTo10_Should_DoNotThing()
        {
            string phoneNum = "123456";
            Assert.AreEqual(phoneNum, phoneNum.MaskPhoneBySymbol(' '));
        }
    }
}