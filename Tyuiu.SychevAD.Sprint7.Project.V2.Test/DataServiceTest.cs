using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SychevAD.Sprint7.Project.V2.Lib;
namespace Tyuiu.SychevAD.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromFileData()
        {
            string path = @"C:\Users\�������\source\repos\Tyuiu.KulakovEE.Sprint7.Project.V2\Tyuiu.KulakovEE.Sprint7.Project.V2\����.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }


}