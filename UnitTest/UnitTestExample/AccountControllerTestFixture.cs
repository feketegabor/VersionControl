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
using UnitTestExample.Abstractions;
using UnitTestExample.Entities;
using UnitTestExample.Services;


namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test]
        void TestValidateEmail(string email, bool expextedResult)
        {
            // Arrange
            var accountController = new UnitTestExample.AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
    }
}
