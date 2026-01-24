using InvoiceAutomationWebApp.Data.Clients.CreateClient;
using InvoiceAutomationWebApp.Data.Clients.DeleteClient;
using InvoiceAutomationWebApp.Data.Clients.GetClient;
using InvoiceAutomationWebApp.Data.Clients.GetClients;
using InvoiceAutomationWebApp.Data.Clients.UpdateClient;
using InvoiceAutomationWebApp.Data.Products.CreateProduct;
using InvoiceAutomationWebApp.Data.Products.DeleteProduct;
using InvoiceAutomationWebApp.Data.Products.GetProduct;
using InvoiceAutomationWebApp.Data.Products.GetProducts;
using InvoiceAutomationWebApp.Data.Products.UpdateProduct;
using InvoiceAutomationWebApp.Data.Transactions.CreateTransaction;
using InvoiceAutomationWebApp.Data.Transactions.DeleteTransaction;
using InvoiceAutomationWebApp.Data.Transactions.GetClientTransactions;
using InvoiceAutomationWebApp.Data.Transactions.GetTransaction;
using InvoiceAutomationWebApp.Data.Transactions.GetTransactions;
using InvoiceAutomationWebApp.Data.Transactions.UpdateTransaction;

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

        #region Product Endpoints

        public async Task<HttpResponseMessage> CreateProductAsync(CreateProductRequest request)
            => await http.PostAsJsonAsync("/Product/Create", request);

        public async Task<HttpResponseMessage> DeleteProductAsync(DeleteProductRequest request)
            => await http.PostAsJsonAsync("/Product/Delete", request);

        public async Task<GetProductResponse> GetProductAsync(string productID)
            => await http.GetFromJsonAsync<GetProductResponse>($"/Product/{productID}") ?? new GetProductResponse();

        public async Task<GetProductsResponse> GetProductsAsync()
            => await http.GetFromJsonAsync<GetProductsResponse>("/Product") ?? new GetProductsResponse();

        public async Task<HttpResponseMessage> UpdateProductAsync(UpdateProductRequest request)
            => await http.PostAsJsonAsync("/Product/Update", request);

        #endregion

        #region Transaction Endpoints

        public async Task<HttpResponseMessage> CreateTransactionAsync(CreateTransactionRequest request)
            => await http.PostAsJsonAsync("/Transaction/Create", request);

        public async Task<HttpResponseMessage> DeleteTransactionAsync(DeleteTransactionRequest request)
            => await http.PostAsJsonAsync("/Transaction/Delete", request);

        public async Task<GetClientTransactionsResponse> GetClientTransactionsAsync(string clientID)
            => await http.GetFromJsonAsync<GetClientTransactionsResponse>($"/Transaction/Client/{clientID}") ?? new GetClientTransactionsResponse();

        public async Task<GetTransactionResponse> GetTransactionAsync(string transactionID)
            => await http.GetFromJsonAsync<GetTransactionResponse>($"/Transaction/{transactionID}") ?? new GetTransactionResponse();

        public async Task<GetTransactionsResponse> GetTransactionsAsync()
            => await http.GetFromJsonAsync<GetTransactionsResponse>("/Transaction") ?? new GetTransactionsResponse();

        public async Task<HttpResponseMessage> UpdateTransactionAsync(UpdateTransactionRequest request)
            => await http.PostAsJsonAsync("/Transaction/Update", request);

        #endregion

    }

}
