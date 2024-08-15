namespace DependencyInversionPrinciple
{
    // Usage example
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the concrete EmailService
            IEmailService emailService = new EmailService();

            // Inject the EmailService instance into the Notification class
            Notification notification = new Notification(emailService);

            // send a promo notif
            notification.PromotionalNotification("I HAVE DRUGS!!!!!!!!!!!!!!!!!");
        }
    }
}
