using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flew.Util.ComHelper;
using System.Diagnostics;

namespace Flew.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var IpAddress = IPAddress.GetIp();
            Trace.WriteLine(string.Format("输出：{0}", IpAddress));
        }
    }
}


