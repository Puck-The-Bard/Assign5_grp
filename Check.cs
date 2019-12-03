using System;
using System.Collections.Generic;

class Check : Payment
{
string Bank; // bank name
string custName; // customer/client name
string accNum; // account number


public Check( double amount, string Bank, string custName, string accNum, string paymentDate) : base(amount, paymentDate)
{
this.accNum = accNum;
this.Bank = Bank;
this.custName = custName; 

}
public override bool verify()
{
    Console.WriteLine("Signature and account Balance verified");
    return true; 

}
    public override string getPaymentType()
{
    return "Check";
}


}