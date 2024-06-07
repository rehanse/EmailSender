namespace EmailSender.Models
{
    public class TextRequestModel
    {
        public string? To { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public string? Mobile { get; set; }
    }
}
