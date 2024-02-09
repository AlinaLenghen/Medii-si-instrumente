// BankTest.cs
using System;
using Bank;
using NUnit.Framework;

namespace BankTest
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            decimal initialBalance = 100;
            decimal debitAmount = 50;
            BankAccount account = new BankAccount("John Doe", initialBalance);

            account.Debit(debitAmount);

            decimal expectedBalance = initialBalance - debitAmount;
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [Test]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            decimal initialBalance = 100;
            BankAccount account = new BankAccount("John Doe", initialBalance);

            Assert.Throws<ArgumentException>(() => account.Debit(-1));
        }

        [Test]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowInvalidOperationException()
        {
            decimal initialBalance = 100;
            BankAccount account = new BankAccount("John Doe", initialBalance);

            Assert.Throws<InvalidOperationException>(() => account.Debit(200));
        }

        [Test]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            decimal initialBalance = 100;
            decimal creditAmount = 50;
            BankAccount account = new BankAccount("John Doe", initialBalance);

            account.Credit(creditAmount);

            decimal expectedBalance = initialBalance + creditAmount;
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [Test]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            decimal initialBalance = 100;
            BankAccount account = new BankAccount("John Doe", initialBalance);

            Assert.Throws<ArgumentException>(() => account.Credit(-1));
        }
    }
}
