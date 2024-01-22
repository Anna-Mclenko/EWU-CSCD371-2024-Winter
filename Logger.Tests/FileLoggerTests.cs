﻿using System;
using System.IO;

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    private FileLogger? _fileLogger;
    private readonly string _filePath = "text.txt";
    [TestInitialize]
    public void Constructor()
    {
        _fileLogger = new(_filePath);
    }

    [TestMethod]
    public void FileLogger_FilePathCheck_Success()
    {
        Assert.AreEqual(_filePath, _fileLogger!.GetPathName());
    }

    [TestMethod]
    public void FileLogger_FilePathCheck_Fail()
    {
        Assert.AreNotEqual("notText.txt", _fileLogger!.GetPathName());
    }

    [TestMethod]
    public void Log_WriteToAFile_Success()
    {
        string FilePath = "C:\\CSCD371\\EWU-CSCD371-2024-Winter\\Text.txt";
        string Message = "Here is my message, please don't yeal at me";

        if(File.Exists(FilePath))
        {
            File.Delete(FilePath);
        }

        _fileLogger!.ClassName = "FileLogger";
        _fileLogger!.Log(LogLevel.Error, Message);

        StreamReader StreamReader = new(FilePath);
        string MessageFromStreamReader = StreamReader.ReadLine() ?? string.Empty;
        StreamReader.Close();

        DateTime DateTime = DateTime.Now;
        string MessageToAppend = $"{DateTime} FileLogger Error : {Message}";

        Assert.AreEqual(MessageToAppend, MessageFromStreamReader);

    }

}
