using System.IO;
using System.Collections.Generic;
using XReader.Domain;
// <copyright file="ReaderTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XReader.IO;

namespace XReader.IO.Tests
{
    [TestClass]
    [PexClass(typeof(Reader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ReaderTest
    {

        [PexMethod]
        [PexAllowedException(typeof(FileNotFoundException))]
        [PexAllowedException(typeof(ArgumentException))]
        public List<Record> ReadAll([PexAssumeUnderTest]Reader target, string file)
        {
            List<Record> result = target.ReadAll(file);
            return result;
            // TODO: add assertions to method ReaderTest.ReadAll(Reader, String)
        }
    }
}
