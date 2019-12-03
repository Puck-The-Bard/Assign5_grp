using System;
using System.Collections.Generic;

class Cash : Payment
{
double tenderedCash; // cash provided by customer, e.g. $200
double change;

double amount;

public Cash(double tenderdCash, string paymentDate, double amount) : base (amount, paymentDate)
{
this.tenderedCash = tenderdCash; 
 
this.amount = amount;
}

 public double calcChange()
 {
    change = tenderedCash - amount;
    return change;
 }

    public override string getPaymentType()
{
    return "Cash";
}



}