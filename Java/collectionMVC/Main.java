public class Main {
    public static void main(String[] args) {

        //default model constructor, should start with default values
        AccountModel testAccount = new AccountModel();

        //view (no contructor), will use to display the values of the account properties
        AccountView accountView = new AccountView();

        //controller to interact with the account model and view
        AccountControler accountControler = new AccountControler(testAccount, accountView);

        //print default values
        accountControler.updateAccountView();

        //use controler to update values
        accountControler.setAccountType("Checking");
        accountControler.setAccountID(111);
        accountControler.setAccountBalance(1000.0);

        //print updated values
        accountControler.updateAccountView();

        //make a transaction (deposit or withdraw) using the controller
        accountControler.makeTransaction();

        //print updated values
        accountControler.updateAccountView();
    }
  }