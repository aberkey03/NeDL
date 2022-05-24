public class Main {
    public static void main(String[] args) {

        //default model constructor, should start with default values
        AccountModel testAccount1 = new AccountModel();

        //view (no contructor), will use to display the values of the account properties
        AccountView accountView = new AccountView();

        //controller to interact with the account model and view
        AccountControler accountControler1 = new AccountControler(testAccount1, accountView);

        //print default values
        accountControler1.updateAccountView();

        //use controler to update values
        accountControler1.setAccountType("Checking");
        accountControler1.setAccountID(111);
        accountControler1.setAccountBalance(1000.0);

        //print updated values
        accountControler1.updateAccountView();

        //make a deposit using the controller
        accountControler1.makeTransaction();

        //print updated values
        accountControler1.updateAccountView();
    }
  }