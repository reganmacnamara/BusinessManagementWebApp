using InvoiceAutomationWebApp.Data.Clients.GetClient;
using InvoiceAutomationWebApp.Data.Clients.GetClients;

namespace InvoiceAutomationWebApp.Data
{

    public class ApiClient(HttpClient http)
    {
        public async Task<GetClientResponse> GetClientAsync(string clientID)
            => await http.GetFromJsonAsync<GetClientResponse>($"/Client/{clientID}") ?? new GetClientResponse();

        public async Task<GetClientsResponse> GetClientsAsync()
            => await http.GetFromJsonAsync<GetClientsResponse>("/Client") ?? new GetClientsResponse();
    }

}
