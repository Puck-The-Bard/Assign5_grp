using System;
using System.Collections.Generic;


class Billing{
string billDate;
string description ;
double amount; // bill total amount

List<Payment> BillPayments = new List<Payment>();

public Billing(string b, string d, double a)
{
    this.billDate = b; 
    this.description = d; 
    this.amount = a; 
}

public string getBillInfo()
{
    double RemBal = amount;
    Console.WriteLine($"Bill Date: {billDate}\nBill Description: {description}\nAmount Due:" + "$" + $"{amount}");
    
    foreach(Payment p in BillPayments)
    {
        Console.WriteLine($"{p.getPaymentDate()} Payment with {p.getPaymentType()} to the Amount of {p.getAmount()} was processed");
        RemBal = RemBal - p.getAmount();
        //Console.WriteLine("\n The Remaining Balance is " + RemBal + " now ");
        //Console.WriteLine("\n The getAmount is " + p.getAmount() + " now ");
    }

    return $"Remaining Balance: {RemBal}";

}

public double getBalance()
 {
    return (amount);
 }

public bool addPayment(Payment p)
{
     if(p.verify() == true)
     {
         BillPayments.Add(p);
         return true; 
     }
     else
     {
         return false;
     }


}

}