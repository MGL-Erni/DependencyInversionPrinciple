namespace DependencyInversionPrinciple
{
    // Define an abstraction for the email service
    public interface IEmailService
    {
        void SendEmail(string emailContent);
    }
}
