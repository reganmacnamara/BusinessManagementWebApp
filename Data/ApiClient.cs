using InvoiceAutomationWebApp.Data.Clients.CreateClient;
using InvoiceAutomationWebApp.Data.Clients.DeleteClient;
using InvoiceAutomationWebApp.Data.Clients.GetClient;
using InvoiceAutomationWebApp.Data.Clients.GetClients;
using InvoiceAutomationWebApp.Data.Clients.UpdateClient;

namespace InvoiceAutomationWebApp.Data
{

    public class ApiClient(HttpClient http)
    {
        public async Task<HttpResponseMessage> CreateClientAsync(CreateClientRequest request)
            => await http.PostAsJsonAsync("/Client/Create", request);

        public async Task<HttpResponseMessage> DeleteClientAsync(DeleteClientRequest request)
            => await http.PostAsJsonAsync("/Client/Delete", request);

        public async Task<GetClientResponse> GetClientAsync(string clientID)
            => await http.GetFromJsonAsync<GetClientResponse>($"/Client/{clientID}") ?? new GetClientResponse();

        public async Task<GetClientsResponse> GetClientsAsync()
            => await http.GetFromJsonAsync<GetClientsResponse>("/Client") ?? new GetClientsResponse();

        public async Task<HttpResponseMessage> UpdateClientAsync(UpdateClientRequest request)
            => await http.PostAsJsonAsync("/Client/Update", request);
    }

}
