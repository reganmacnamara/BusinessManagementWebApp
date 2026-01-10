using InvoiceAutomationWebApp.Data.Clients.CreateClient;
using InvoiceAutomationWebApp.Data.Clients.DeleteClient;
using InvoiceAutomationWebApp.Data.Clients.GetClient;
using InvoiceAutomationWebApp.Data.Clients.GetClients;
using InvoiceAutomationWebApp.Data.Clients.UpdateClient;
using InvoiceAutomationWebApp.Data.Transactions.CreateTransaction;
using InvoiceAutomationWebApp.Data.Transactions.DeleteTransaction;
using InvoiceAutomationWebApp.Data.Transactions.GetTransaction;
using InvoiceAutomationWebApp.Data.Transactions.GetTransactions;

namespace InvoiceAutomationWebApp.Data
{

    public class ApiClient(HttpClient http)
    {

        #region Client Endpoints

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

        #endregion

        #region Transaction Endpoints

        public async Task<HttpResponseMessage> CreateTransactionAsync(CreateTransactionRequest request)
            => await http.PostAsJsonAsync("/Transaction/Create", request);

        public async Task<HttpResponseMessage> DeleteTransactionAsync(DeleteTransactionRequest request)
            => await http.PostAsJsonAsync("/Transaction/Delete", request);

        public async Task<GetTransactionResponse> GetTransactionAsync(string transactionID)
            => await http.GetFromJsonAsync<GetTransactionResponse>($"/Transaction/{transactionID}") ?? new GetTransactionResponse();

        public async Task<GetTransactionsResponse> GetTransactionsAsync()
            => await http.GetFromJsonAsync<GetTransactionsResponse>("/Transaction") ?? new GetTransactionsResponse();

        #endregion

    }

}
