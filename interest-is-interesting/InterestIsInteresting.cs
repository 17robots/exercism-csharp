static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance < 0 ? 3.213f : balance < 1000 ? .5f : balance < 5000 ? 1.621f : 2.475f;
    public static decimal Interest(decimal balance) => balance * (decimal)SavingsAccount.InterestRate(balance) / 100;
    public static decimal AnnualBalanceUpdate(decimal balance) => balance + SavingsAccount.Interest(balance);
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        do
        {
            years++;
            balance = AnnualBalanceUpdate(balance);
        } while (balance < targetBalance);
        return years;
    }
}
