using BusinessManagementWebApp.Data.Clients.CreateClient;
using BusinessManagementWebApp.Data.Clients.DeleteClient;
using BusinessManagementWebApp.Data.Clients.GetClient;
using BusinessManagementWebApp.Data.Clients.GetClients;
using BusinessManagementWebApp.Data.Clients.UpdateClient;
using BusinessManagementWebApp.Data.Products.CreateProduct;
using BusinessManagementWebApp.Data.Products.DeleteProduct;
using BusinessManagementWebApp.Data.Products.GetProduct;
using BusinessManagementWebApp.Data.Products.GetProducts;
using BusinessManagementWebApp.Data.Products.UpdateProduct;
using BusinessManagementWebApp.Data.TransactionAllocations.UpsertTransactionAllocation;
using BusinessManagementWebApp.Data.TransactionItems.DeleteTransactionItem;
using BusinessManagementWebApp.Data.TransactionItems.GetTransactionItems;
using BusinessManagementWebApp.Data.TransactionItems.UpsertTransactionItem;
using BusinessManagementWebApp.Data.Transactions.CreateTransaction;
using BusinessManagementWebApp.Data.Transactions.DeleteTransaction;
using BusinessManagementWebApp.Data.Transactions.GetClientTransactions;
using BusinessManagementWebApp.Data.Transactions.GetTransaction;
using BusinessManagementWebApp.Data.Transactions.GetTransactions;
using BusinessManagementWebApp.Data.Transactions.UpdateTransaction;

namespace BusinessManagementWebApp.Data
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

        #region TransactionAllocation Endpoints

        public async Task<HttpResponseMessage> UpsertTransactionAllocationAsync(UpsertTransactionAllocationRequest request)
            => await http.PostAsJsonAsync("/TransactionAllocation/Upsert", request);

        #endregion

        #region TransactionItem Endpoints

        public async Task<HttpResponseMessage> DeleteTransactionItemAsync(DeleteTransactionItemRequest request)
            => await http.PostAsJsonAsync("/TransactionItem/Delete", request);

        public async Task<GetTransactionItemsResponse> GetTransactionItemsAsync()
            => await http.GetFromJsonAsync<GetTransactionItemsResponse>("/Transaction") ?? new GetTransactionItemsResponse();

        public async Task<HttpResponseMessage> UpsertTransactionItemAsync(UpsertTransactionItemRequest request)
            => await http.PostAsJsonAsync("/TransactionItem/Upsert", request);

        #endregion
    }

}
