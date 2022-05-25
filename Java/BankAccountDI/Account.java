import javax.swing.Icon;

public class Account implements IAccountInfo, ICheckingAccount, IMortgageAccount, ISavingsAccount {
    
    
    private AccountInfo theAccount;

    public Account(int id, double balance, String customerName){
        theAccount = new AccountInfo(id, balance, customerName);
    }

    public void IMortgageAccount.PrintAccountDetails(){
        System.out.println("Mortgage Account Balance: " + theAccount.getBalance());
    }
    
    
}
