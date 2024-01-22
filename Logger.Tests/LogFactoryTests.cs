﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckClassName_Success()
    {
        LogFactory LogFactory = new();
        BaseLogger FileLogger = LogFactory.CreateLogger("FileLogger")!;
        Assert.AreEqual("FileLogger", FileLogger.ClassName);
    }

    [TestMethod]
    public void CreateLogger_CheckClassName_Fail()
    {
        LogFactory LogFactory = new();
        BaseLogger FileLogger = LogFactory.CreateLogger("FileLogger")!;
        Assert.AreNotEqual("FileNotLogger", FileLogger.ClassName);
    }

    [TestMethod]
    public void ConfigureFileLogger_CorrectPathName_Success()
    {
        LogFactory LogFactory = new();
        string PathName = LogFactory.ConfigureFileLogger("text.txt");
        Assert.AreEqual("text.txt", PathName);
    }

    [TestMethod]
    public void CreateLogger_InvalidClassName_Fail()
    {
        LogFactory LogFactory = new();
        Assert.AreEqual(null, LogFactory.CreateLogger("InvalidClaseName"));

    }
}
