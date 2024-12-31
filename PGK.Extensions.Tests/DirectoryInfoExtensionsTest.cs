using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PGK.Extensions.Tests
{
	[TestClass]
    [DeploymentItem(@"FilesForTestingPurpose", @"FilesForTestingPurpose")]
    [DeploymentItem(@"FilesForTestingPurpose/Properties", @"FilesForTestingPurpose/Properties")]
    public class DirectoryInfoExtensionsTest
	{
		[TestMethod]
		public void GetFiles()
		{
			var testValue = new DirectoryInfo(@".\FilesForTestingPurpose");
			Console.WriteLine("Test dir: " + testValue.FullName);
			var results = testValue.GetFiles("*.txt", "*.suo");
			Assert.IsNotNull(results);

			if (System.Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
                //special behaviour on windows: *.sln will also match *.sln.docstates.suo because of the 8.3 filename
                Assert.AreEqual(3, results.Length);
				Assert.AreEqual(1, results.Count(fi => fi.Name == "Test.DirExtensions.txt"));
				Assert.AreEqual(1, results.Count(fi => fi.Name == "Test.DirExtensions.txt.docstates.suo"));
				Assert.AreEqual(1, results.Count(fi => fi.Name == "Test.DirExtensions.suo"));
			}
			else
			{
				Assert.AreEqual(2, results.Length);
				Assert.AreEqual(1, results.Count(fi => fi.Name == "Test.DirExtensions.txt"));
				Assert.AreEqual(1, results.Count(fi => fi.Name == "Test.DirExtensions.suo"));
			}
		}

		[TestMethod]
		public void FindFileRecursive_pattern()
		{
            var testValue = new DirectoryInfo(@".\FilesForTestingPurpose");
			Console.WriteLine("Test dir: " + testValue.FullName);
            var results = testValue.FindFileRecursive("AssemblyInfo.*");
			Assert.IsNotNull(results);
			Assert.AreEqual("AssemblyInfo.txt", results.Name);
			Assert.IsTrue(results.FullName.EndsWith(@"\Properties" + System.IO.Path.DirectorySeparatorChar + "AssemblyInfo.txt"));
		}
		[TestMethod]
		public void FindFileRecursive_Predicate()
		{
            var testValue = new DirectoryInfo(@".\FilesForTestingPurpose");
            Console.WriteLine("Test dir: " + testValue.FullName);
            var results = testValue.FindFileRecursive(fi=> fi.Name.StartsWith("AssemblyInfo"));
			Assert.IsNotNull(results);
			Assert.AreEqual("AssemblyInfo.txt", results.Name);
            Assert.IsTrue(results.FullName.EndsWith(@"\Properties" + System.IO.Path.DirectorySeparatorChar + "AssemblyInfo.txt"));
        }

        [TestMethod]
		public void FindFilesRecursive_pattern()
		{
            var testValue = new DirectoryInfo(@".\FilesForTestingPurpose");
            Console.WriteLine("Test dir: " + testValue.FullName);
            var results = testValue.FindFilesRecursive("AssemblyInfo.*");
            Assert.IsNotNull(results);
			Assert.AreEqual(1,results.Length);
			var fi = results.First();
			Assert.AreEqual("AssemblyInfo.txt", fi.Name);
            Assert.IsTrue(fi.FullName.EndsWith(@"\Properties" + System.IO.Path.DirectorySeparatorChar + "AssemblyInfo.txt"));
        }
        [TestMethod]
		public void FindFilesRecursive_Predicate()
		{
            var testValue = new DirectoryInfo(@".\FilesForTestingPurpose");
            Console.WriteLine("Test dir: " + testValue.FullName);
            var results = testValue.FindFilesRecursive(fi=> fi.Name.StartsWith("AssemblyInfo"));
			Assert.IsNotNull(results);
			Assert.AreEqual(1,results.Length);
			var f1 = results.First();
			Assert.AreEqual("AssemblyInfo.txt", f1.Name);
            Assert.IsTrue(f1.FullName.EndsWith(@"\Properties" + System.IO.Path.DirectorySeparatorChar + "AssemblyInfo.txt"));
        }

    }
}
