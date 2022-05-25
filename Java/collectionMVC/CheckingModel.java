

public class CheckingModel implements IAccountModel{ //main Model
    //private fields
    private int accountID;
    private String accountType;
    private double accountBalance;

    //default contructor
    public CheckingModel(){
        accountID = -1;
        accountType = "CHECKING";
        accountBalance = -1;
    }
    public CheckingModel(int accountID, String accountType, double accountBalance){
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

    //methods
    
    //deposit
    public void Deposit(double depositAmount){
        accountBalance = accountBalance + depositAmount;
    }
    //withdraw
    public void Withdraw(double withdrawAmount){
        if(accountBalance - withdrawAmount < 0){

        }
    }
}
