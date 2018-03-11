namespace CleanCode.SwitchStatementsCorrect
{
    public abstract class Customer
    {
        public abstract MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage);
    }
}
