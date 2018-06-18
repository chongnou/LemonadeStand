using System;
using Lemonadestand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Wallet_CheckIfBankrupt_ExpectTrue()
        {
            // Arrange
            Wallet wallet = new Wallet();
            wallet.money = 10;
            wallet.amount = 100000;
            bool expectedResult = true;

            // Act
            // call method
            bool actualResult = wallet.CheckIfBankrupt();

            // Assert
            // expect results
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Wallet_CheckIfBankrupt_ExpectFalse()
        {
            // Arrange
            Wallet wallet = new Wallet();
            wallet.money = 10;
            wallet.amount = 1;
            bool expectedResult = false;
            // Act
            bool actualResult = wallet.CheckIfBankrupt();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

//public bool CheckIfBankrupt()
//{

//    if (money < amount)
//    {
//        bankrupt = true;
//        Console.WriteLine("You don't have enough money. Try again.");
//    }
//    return bankrupt;
//}
