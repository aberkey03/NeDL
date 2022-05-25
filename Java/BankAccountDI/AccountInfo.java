public class AccountInfo {
    
    //private fields
    private int id;
    private double balance;
    private String customerName;

    //contructor
    public AccountInfo(int id, double balance, String customerName) {
        this.id = id;
        this.balance = balance;
        this.customerName = customerName;
    }

    //gets and sets
    public int getID(){
        return this.id;
    }
    public void setID(int id){
        this.id = id;
    }
    public double getBalance(){
        return this.balance;
    }
    public void setBalance(double balance){
        this.balance = balance;
    }
    public String getCustomerName(){
        return this.customerName;
    }
    public void setCustomerName(String customerName){
        this.customerName = customerName;
    }

    //methods
    public String toString(){
        return "ID: " + this.id + " Balance: " + this.balance + " Customer Name: " + this.customerName;
    }
}
