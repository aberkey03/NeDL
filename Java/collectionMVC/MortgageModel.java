public class MortgageModel implements IAccountModel{

    //private fields
    private int accountID;
    private String accountType;
    private double accountBalance;

    //default contructor
    public MortgageModel(){
        accountID = -1;
        accountType = "CHECKING";
        accountBalance = -1;
    }
    
    @Override
    public int getAccountId() {
        return accountID;
    }

    @Override
    public void setAccountID(int accountID) {
        this.accountID = accountID;
    }

    @Override
    public String getAccountType() {
        return this.accountType;
    }

    @Override
    public void setAccountType(String accountType) {
        this.accountType = accountType;
    }

    @Override
    public double getAccountBalance() {
        return this.accountBalance;
    }

    @Override
    public void setAccountBalance(double accountBalance) {
        this.accountBalance = accountBalance;
    }

    @Override
    public void Deposit(double depositAmount) {
        System.out.println("Can not make deposits to morgage account.");
    }

    @Override
    public void Withdraw(double withdrawAmount) {
        System.out.println("Can not make withdrawls from morgage account.");
    }
    
}
