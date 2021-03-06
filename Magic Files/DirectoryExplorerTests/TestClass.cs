using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLib;


namespace DirectoryExplorerTests
{
    [TestFixture]
    public class TestClass
    {
        Mock<IDirectoryExplorer> mockDirectoryExplorer;



        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        private readonly string _file3 = "file3.txt";



        [SetUp]
        public void init()
        {
            mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
            string[] files = { _file1, _file2 };
            mockDirectoryExplorer.Setup(m => m.GetFiles(It.IsAny<string>())).Returns(files);
        }

        [TestCase("Myfilepath")]
        [TestCase("Myfilepath")]
        public void tests(string path)
        {
            var files = mockDirectoryExplorer.Object.GetFiles(path);
            Assert.IsNotNull(files);
            Assert.AreEqual(2, files.Count);
            Assert.AreEqual(true, files.Contains(_file2));
        }
    }
}