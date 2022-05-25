public interface IAccountModel{
    
    //gets and sets
    public int getAccountId();

    public void setAccountID(int accountID);

    public String getAccountType();

    public void setAccountType(String accountType);

    public double getAccountBalance();

    public void setAccountBalance(double accountBalance);
    
    //methods
    
    //deposit
    public void Deposit(double depositAmount);
    //withdraw
    public void Withdraw(double withdrawAmount);
}
