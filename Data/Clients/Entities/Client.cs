using System.ComponentModel.DataAnnotations;

namespace InvoiceAutomationWebApp.Data.Clients.Entities
{

    public class Client
    {
        [Key]
        public long ClientID { get; set; }

        public string ClientName { get; set; } = string.Empty;
    }

}
