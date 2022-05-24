import java.util.Scanner;  // Import the Scanner class



public class AccountView {

    Scanner inputScan = new Scanner(System.in);

    public void printAccountDetails(int accountID, String accountType, double accountBalance){
        System.out.println("Account: " + accountID);
        System.out.println("Type: " + accountType);
        System.out.println("Balance: " + accountBalance);
    }

    public int determineTransactionType(){
        boolean validTransactioType = false;
        int transactionType = -1;
        while(!validTransactioType){
            System.out.println("What kind of transaction would you like to make? \n1: Deposit \n2: Withdrawl");
            transactionType = inputScan.nextInt();
            if(transactionType != 1 && transactionType != 2 && transactionType != 3){
                System.out.println(transactionType + " is not valid. Try again.");
            }
            else {
                validTransactioType =  true;
            }      
        }
        return transactionType; 
    }

    public double getDepositAmount(){
        System.out.println("How much would you like to deposit?");
        double depositAmount = inputScan.nextDouble();
        return depositAmount;
    }

    public double getWithdrawAmount(){
        System.out.println("How much would you like to withdraw?");
        double withdrawAmount = inputScan.nextDouble();
        return withdrawAmount;
    }
}
