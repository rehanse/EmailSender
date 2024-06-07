namespace EmailSender.Models
{
    public class EmailHost
    {
        public string FromEmail { get; set; }
        public string FromPassword { get; set;}
        public int Port { get; set;}
        public string Host { get; set;}
    }
}
