//model
public class Tip {
    
    //private fields
    private double amount;
    private double tipPercent;

    //constructors
    public Tip()
    {
        amount = 0;
        tipPercent = 0;
    }
    public Tip(double amount, double tipPercent)
    {
        this.amount = amount;
        this.tipPercent = tipPercent;
    }

    //public setter for amount
    public void setAmount(double amount) 
    {
        this.amount = amount;
    }
    //public getter for amount
    public double getAmount()
    {
        return this.amount;
    }
    //public setter for tipPercent
    public void setTipPercent(double tipPercent) 
    {
        if(tipPercent < 1)
        {
            tipPercent /= 100;
        }
        this.tipPercent = tipPercent;
    }
    //public getter for tipPercent
    public double getTipPercent()
    {
        return tipPercent;
    }
    //methods
    public double CalculateTip()
    {
        return amount * tipPercent;
    }
    public double CalculateTotal()
    {
        return CalculateTip() + amount;
    }
}
