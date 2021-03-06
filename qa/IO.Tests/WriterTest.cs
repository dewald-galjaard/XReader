using System.Linq;
using System.Collections.Generic;
// <copyright file="WriterTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XReader.IO;

namespace XReader.IO.Tests
{
    [TestClass]
    [PexClass(typeof(Writer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class WriterTest
    {

        [PexMethod]
        public void WriteAll(
            [PexAssumeUnderTest]Writer target,
            string file,
            IOrderedEnumerable<KeyValuePair<string, string>> records
        )
        {
            target.WriteAll(file, records);
            // TODO: add assertions to method WriterTest.WriteAll(Writer, String, IOrderedEnumerable`1<KeyValuePair`2<String,String>>)
        }
    }
}
