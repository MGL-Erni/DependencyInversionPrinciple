namespace DependencyInversionPrinciple
{
    // Implement the abstraction in the EmailService class
    public class EmailService : IEmailService
    {
        public void SendEmail(string emailContent)
        {
            // Code to send email
            Console.WriteLine($"Sent email with body: \"{emailContent}\"");
        }
    }
}
