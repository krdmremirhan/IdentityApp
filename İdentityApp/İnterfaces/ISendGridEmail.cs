namespace İdentityAp.İnterfaces;

public interface ISendGridEmail
{
    public Task SendEmailAsync(string toEmail, string subject, string message);
}