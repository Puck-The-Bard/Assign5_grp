class CreditCard : Payment
{

string CCNum; // credit card number
string expDate; // expiration date
string CHolderName;// card holder name
string CType; // Visa, MasterCard

public CreditCard( double amount, string CCNum, string cType, string CHolderName, string expDate,  string paymentDate) :base (amount, paymentDate)
{
    this.CCNum = CCNum; 
    this.expDate = expDate; 
    this.CHolderName = CHolderName; 
    this.CType = cType; 
}


public override bool verify()
{
   // Console.WriteLine("Credit Card Verified");
    return true; 

}

public override string getPaymentType()
{
    return "Credit Card";
}


}