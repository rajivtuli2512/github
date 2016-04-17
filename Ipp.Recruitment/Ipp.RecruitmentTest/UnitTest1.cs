using System;
using System.Web.Services.Protocols;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;


namespace Ipp.RecruitmentTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        [AspNetDevelopmentServer("PaymentGateway", @"D:\ippayment\Ipp.Recruitment")]

        public void WhatsYourIdTest()
        {
           
        }
    }
}
