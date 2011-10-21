using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace active_directory_tester
{
    [TestFixture]
    public class ActiveDirectoryTests
    {
        [Test]
        public void GetEmail_FromCurrentUser_UsingAccountManagement()
        {
            var email = System.DirectoryServices.AccountManagement.UserPrincipal.Current.EmailAddress;

            Assert.That(email, Is.Not.Null);
        }
    }
}
