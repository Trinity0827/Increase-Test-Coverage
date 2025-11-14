namespace AtmServices.Test;
using AtmServices;
public class AtmTests
{
    Atm testAtm;
    int initialBalance = 100;
    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }
 
    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);
        Assert.Equal(75, testAtm.getBalance());
    }

    [Fact]
        public void Withdraw_Fails_When_Not_Enough()
        {
            Atm atm = new Atm(100);

            bool result = atm.withdraw(200);

            Assert.False(result);
            Assert.Equal(100, atm.getBalance());
        }

        [Fact]
        public void Deposit_Works_With_Positive_Number()
        {
            Atm atm = new Atm(100);

            bool result = atm.deposit(50);

            Assert.True(result);
            Assert.Equal(150, atm.getBalance());
        }

        [Fact]
        public void Deposit_Fails_With_Negative_Number()
        {
            Atm atm = new Atm(100);

            bool result = atm.deposit(-10);

            Assert.False(result);
            Assert.Equal(100, atm.getBalance());
        }

        [Fact]
        public void GetBalance_Returns_Current_Balance()
        {
            Atm atm = new Atm(100);

            Assert.Equal(100, atm.getBalance());
        }
}