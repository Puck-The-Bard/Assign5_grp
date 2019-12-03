using System;
using System.Collections.Generic;

abstract class Payment
{
 double amount; // amount of this payment
string paymentDate; // date of this payment

public Payment(double a, string p)
{
    amount = a; 
    paymentDate = p;

}

public double getAmount()
{
    return amount; 

}

public string getPaymentDate()
{
    return paymentDate; 
}

public virtual bool verify()
{
    Console.WriteLine("Payment Verified...");
    return true;
}


public virtual string getPaymentType()
{
        return " ";
    }
}
