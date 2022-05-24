import java.io.Console;
import java.rmi.server.RemoteRef;
import java.util.Scanner;

public class Display {
    /// scanner object needed to read user input
    Scanner inputScanner = new Scanner(System.in);

    /// this is the Display class. Its purpose is
    /// to gather the input and display the output
    /// Unlike our usual display I have made the 
    /// variables Class level fields. This is so
    /// the Controller can have access to the fields
    /// through the properties. The Display class
    /// is totally unaware of the Tip class (the model)
    /// or the controller
    /// 

    private double percent;
    private double amt;
    private double total;
    private double tipAmount;

    //constructor
    public Display()
    {
        percent = 0;
        amt = 0;
        total = 0;
        tipAmount = 0;
        GetValues();
    }

    //setter for percent 
    public void setPercent(double percent)
    {
        this.percent = percent;
    }
    //getter for percent
    public double getPercent()
    {
        return this.percent;
    }
    //public setter for amt
    public void setAmt(double amt) 
    {
        this.amt = amt;
    }
    //public getter for amt
    public double getAmt()
    {
        return this.amt;
    }
    //setter for total
    public void setTotal(double total)
    {
        this.total = total;
    }
    //getter for total
    public double getTotal()
    {
        return this.total;
    }
    //setter for tipAmount
    public void setTipAmount(double tipAmount)
    {
        this.tipAmount = tipAmount;
    }
    //getter for tipAmount
    public double getTipAmount()
    {
        return this.tipAmount;
    }

    //private method for getting input
    //it is called in the constructor
    private void GetValues()
    {
        System.out.println("Enter the Amount of the meal");
        setTotal(inputScanner.nextDouble());

        System.out.println("Enter the percent you want to tip");
        setPercent(inputScanner.nextDouble());
    }

    //public method to show output
    //public so I can access it from the controller
    public void ShowTipAndTotal()
    {
        System.out.println("Your tip is" + tipAmount);
        System.out.println("Your total is " + total);
        inputScanner.nextLine();
    }
}
