//using Factory_Method;

//string cardType = "MoneyBack";

//CreditCard cardDetails = null;

////Based of the CreditCard Type we are creating the
////appropriate type instance using if else condition
//if (cardType == "MoneyBack")
//{
//    cardDetails = new MoneyBack();
//}
//else if (cardType == "Titanium")
//{
//    cardDetails = new Titanium();
//}
//else if (cardType == "Platinum")
//{
//    cardDetails = new Platinum();
//}

//if (cardDetails != null)
//{
//    Console.WriteLine("CardType : " + cardDetails.GetCardType());
//    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
//    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
//}
//else
//{
//    Console.Write("Invalid Card Type");
//}

//Console.ReadLine();
//////////////////////////////////////////

//using Factory_Method;

//CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

//if (cardDetails != null)
//{
//    Console.WriteLine("CardType : " + cardDetails.GetCardType());
//    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
//    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
//}
//else
//{
//    Console.Write("Invalid Card Type");
//}

//Console.ReadLine();
////////////////////////////////////////////


using Factory_Method;

Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
string gatewayName = Console.ReadLine();

try
{
    IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
    paymentGateway.ProcessPayment(100.00M);  // Example amount
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();