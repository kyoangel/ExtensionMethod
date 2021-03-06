﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(phoneNum, phoneNum.MaskPhoneBySymbol('*'));
        }

        [TestMethod()]
        public void PhoneNumNotAllDigital_Should_DoNotThing()
        {
            string phoneNum = "0950rteas8";
            Assert.AreEqual(phoneNum, phoneNum.MaskPhoneBySymbol('*'));
        }


        [TestMethod()]
        public void PhoneNumWithSymbol_Should_ReturnMaskPhoneNumString()
        {
            string phoneNum = "0987654321";
            Assert.AreEqual("0987***321", phoneNum.MaskPhoneBySymbol('*'));

            Assert.AreEqual("0987---321", phoneNum.MaskPhoneBySymbol('-'));

            Assert.AreEqual("0987$$$321", phoneNum.MaskPhoneBySymbol('$'));

            Assert.AreEqual("0987   321", phoneNum.MaskPhoneBySymbol(' '));
        }
    }
}