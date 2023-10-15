
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        #region debit tests (12_6,12_13,12_1)

        [TestMethod]
        public void Depit_Name_BryanWalton_Balance_12_Amount_6_Result_6()
        {
            //arrange
            double amount = 8;
            double EResult = 8;
            BankAccount DebitObject = new BankAccount("AccTest", 16);
            //act
            DebitObject.Debit(amount);
            double AResult = DebitObject.Balance;
            //assert
            Assert.AreEqual(AResult, EResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Depit_Name_BryanWalton_Balance_12_Amount_13_Result_Exception()
        {
            //arrange
            double amount = 19;
            double EResult = 0;
            BankAccount DebitObject = new BankAccount("AccTest", 16);
            //act
            DebitObject.Debit(amount);
            double AResult = DebitObject.Balance;
            //assert
            Assert.AreEqual(AResult, EResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Depit_Name_BryanWalton_Balance_12_Amount_1_Result_Exception()
        {
            //arrange
            double amount = -4;
            double EResult = 0;
            BankAccount DebitObject = new BankAccount("AccTest", 16);
            //act
            DebitObject.Debit(amount);
            double AResult = DebitObject.Balance;
            //assert
            Assert.AreEqual(AResult, EResult);
        }
        #endregion

        #region credit tests (12_6,12_13,12_1)

        [TestMethod]
        public void Credit_Name_BryanWalton_Balance_12_Amount_6_Result_6()
        {
            //arrange
            double amount = 8;
            double EResult = 8;
            BankAccount DebitObject = new BankAccount("AccTest", 16);
            //act
            DebitObject.Credit(amount);
            double AResult = DebitObject.Balance;
            //assert
            Assert.AreEqual(AResult, EResult);
        }

        [TestMethod]
        public void Credit_Name_BryanWalton_Balance_12_Amount_13_Result_Negative()
        {
            //arrange
            double amount = 21;
            double EResult = -3;
            BankAccount DebitObject = new BankAccount("AccTest", 16);
            //act
            DebitObject.Credit(amount);
            double AResult = DebitObject.Balance;
            //assert
            Assert.AreEqual(AResult, EResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_Name_BryanWalton_Balance_12_Amount_1_Result_Exception()
        {
            //arrange
            double amount = -5;
            double EResult = 0;
            BankAccount DebitObject = new BankAccount("AccTest", 16);
            //act
            DebitObject.Credit(amount);
            double AResult = DebitObject.Balance;
            //assert
            Assert.AreEqual(AResult, EResult);
        } 
        #endregion

    }
}