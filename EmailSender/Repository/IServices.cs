using EmailSender.Models;

namespace EmailSender.Repository
{
    public interface IServices
    {
        Task<bool> SendTextService(TextRequestModel emailModel);
    }
}
