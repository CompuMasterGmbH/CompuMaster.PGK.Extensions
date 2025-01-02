using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace PGK.Extensions.Tests
{
	[TestClass]
    [DeploymentItem(@"FilesForTestingPurpose", @"FilesForTestingPurpose")]
    public class TextReaderExtensionsTest
	{

		TextReader reader;

		[TestInitialize]
		public void Initialize()
		{
            reader = File.OpenText(@"./FilesForTestingPurpose/Used_for_testing.dat");
        }

        [TestCleanup]
		public void Shutdown()
		{
			reader.Close();
			reader.Dispose();
		}

		[TestMethod]
		public void IterateLines_strings()
		{
			var iter = reader.IterateLines().GetEnumerator();
			iter.MoveNext();
			iter.MoveNext();
			Assert.AreEqual("123456789a123456789b123456789c12", iter.Current);
			iter.MoveNext();
			Assert.IsTrue(iter.Current.StartsWith("Each line"));
		}

		[TestMethod]
		public void IterateLines_Action()
		{
			var sb = new StringBuilder();
			int c = 0;
			reader.IterateLines(lin => { ++c;  sb.Append(lin + "\r\n"); }); // CRLF for all platforms since text file is already created with CRLF line encoding
            Assert.AreEqual(136, sb.Length);		// 136 = (32 line  + CRLF)*4 
			Assert.AreEqual(4, c);
			
		}
	}
}
