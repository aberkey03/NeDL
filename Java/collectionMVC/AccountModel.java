import javax.management.Descriptor;

public class AccountModel { //main Model
    //private fields
    private int accountID;
    private String accountType;
    private double accountBalance;
    private double depositAmount;
    private double withdrawAmount;

    //default contructor
    public AccountModel(){
        accountID = -1;
        accountType = "undefined account type";
        accountBalance = -1;
    }
    public AccountModel(int accountID, String accountType, double accountBalance){
        this.accountID = accountID;
        this.accountType = accountType;
        this.accountBalance = accountBalance;
    }

    //gets and sets
    public int getAccountId(){
        return accountID;
    }
    public void setAccountID(int accountID){
        this.accountID = accountID;
    }
    public String getAccountType(){
        return accountType;
    }
    public void setAccountType(String accountType){
        this.accountType = accountType;
    }
    public double getAccountBalance(){
        return accountBalance;
    }
    public void setAccountBalance(double accountBalance){
        this.accountBalance = accountBalance;
    }
    public void setDepositAmount(double depositAmount){
        this.depositAmount = depositAmount;
    }
    public void setWithdrawAmount(double withdrawAmount){
        this.withdrawAmount = withdrawAmount;
    }

    //methods
    
    //deposit
    public void Deposit(double depositAmount){
        accountBalance = accountBalance + depositAmount;
    }
    //withdraw
    public void Withdraw(double withdrawAmount){
        accountBalance = accountBalance - withdrawAmount;
    }
}
