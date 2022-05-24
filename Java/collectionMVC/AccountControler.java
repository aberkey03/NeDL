import javax.print.DocFlavor.CHAR_ARRAY;

public class AccountControler {
    //create model and view objects
    private AccountModel accountModel;
    private AccountView accountView;

    //contructor, includes view and model objects
    public AccountControler(AccountModel accountModel, AccountView accountView){
        this.accountModel = accountModel;
        this.accountView = accountView;
    }

    //gets and sets
    public void setAccountID(int accountID){
        accountModel.setAccountID(accountID);
    }
    public int getAccountId(){
        return accountModel.getAccountId();
    }
    public void setAccountType(String accountType){
        accountModel.setAccountType(accountType);
    }
    public String getAccountType(){
        return accountModel.getAccountType();
    }
    public void setAccountBalance(double accountBalance){
        accountModel.setAccountBalance(accountBalance);
    }
    public double getAccountBalance(){
        return accountModel.getAccountBalance();
    }

    //methods
    public void updateAccountView(){
        accountView.printAccountDetails(accountModel.getAccountId(), accountModel.getAccountType(), accountModel.getAccountBalance());
    }

    public void makeTransaction(){
        int transactionType =  accountView.determineTransactionType();
        if(transactionType == 1){
            accountModel.Deposit(accountView.getDepositAmount());
        }
        else if (transactionType == 2){
            accountModel.Withdraw(accountView.getWithdrawAmount());
        }
    }
}
