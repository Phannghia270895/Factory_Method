using Real_Time_Examples;

var notificationSystem = new NotificationSystem();

// For a user who prefers email notifications:
notificationSystem.NotifyUser(new EmailNotifierFactory(), "This is an email notification!");

// For a user who prefers SMS notifications:
notificationSystem.NotifyUser(new SMSNotifierFactory(), "This is an SMS notification!");

// For a user who prefers push notifications:
notificationSystem.NotifyUser(new PushNotifierFactory(), "This is a push notification!");

Console.ReadKey();