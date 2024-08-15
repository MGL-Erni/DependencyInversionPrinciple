namespace DependencyInversionPrinciple
{
    // High-level module depends on the abstraction (IEmailService) instead of the concrete class (EmailService)
    public class Notification
    {
        private readonly IEmailService _emailService;

        // Constructor injection to inject the dependency
        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void PromotionalNotification(string content)
        {
            _emailService.SendEmail(content);
        }
    }
}
