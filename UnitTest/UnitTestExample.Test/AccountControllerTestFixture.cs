using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestExample;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample;


namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        void TestValidateEmail(string email, bool expextedResult)
        {
            // Arrange
            var accountController = new UnitTestExample.AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expextedResult, actualResult);
        }

    }
}
