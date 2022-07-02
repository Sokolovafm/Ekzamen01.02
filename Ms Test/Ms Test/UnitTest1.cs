using ClassLibraryPassword;

namespace Ms_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            //Arrange
            string password = "QW1ertyas$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "qwer$";
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_30Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "QWERR$$ASDFG$$ZXCVB%%YHNBGTRFV";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            //Arrange
            string password = "ujmyhnip123A$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            //Arrange
            string password = "rfvedcsdfD()";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "ae#!@zxdsD3#";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "asdfghjkl";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "LKJHgfds1$";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "lkjhgfdf";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "QWERasdf5%";
            bool expected = true;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "QWERTGFD";
            bool expected = false;
            //Act
            bool actual = PasswordChecker.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

