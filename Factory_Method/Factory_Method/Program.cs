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


//using Factory_Method;

//Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
//string gatewayName = Console.ReadLine();

//try
//{
//    IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
//    paymentGateway.ProcessPayment(100.00M);  // Example amount
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Console.ReadKey();


// Testing the Factory Design Pattern


//using Factory_Method;

//Console.WriteLine("Enter the content to convert:");
//string content = Console.ReadLine();

//Console.WriteLine("Select the target format (DOCX, PDF, TXT):");
//string format = Console.ReadLine();

//try
//{
//    IDocumentConverter converter = DocumentConverterFactory.CreateDocumentConverter(format);
//    string convertedContent = converter.Convert(content);
//    Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Console.ReadKey();

// Testing the Factory Design Pattern

using Factory_Method;

INotificationSender notificationSender;

notificationSender = NotificationFactory.CreateNotificationSender("email");
notificationSender.SendNotification("This is an email notification!");

notificationSender = NotificationFactory.CreateNotificationSender("sms");
notificationSender.SendNotification("This is an SMS notification!");

notificationSender = NotificationFactory.CreateNotificationSender("push");
notificationSender.SendNotification("This is a push notification!");

// As with other factory examples, adding new notification methods 
// would only require extending the factory, without altering the client code.

Console.ReadKey();
