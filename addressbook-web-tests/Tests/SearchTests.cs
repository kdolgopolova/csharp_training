﻿using NUnit.Framework;
using System.Collections.Generic;

namespace Addressbook_web_tests
{
    [TestFixture]
    public class SearchTests : AuthTestBase
    {
        [Test]
        public void TestSearch()
        {
            System.Console.Out.Write(app.Contacts.GetNumberOfResults());
        }
    }
}
