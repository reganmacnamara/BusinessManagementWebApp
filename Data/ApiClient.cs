using BusinessManagementWebApp.Data.Clients.CreateClient;
using BusinessManagementWebApp.Data.Clients.GetClient;
using BusinessManagementWebApp.Data.Clients.GetClients;
using BusinessManagementWebApp.Data.Clients.UpdateClient;
using BusinessManagementWebApp.Data.Invoices.CreateInvoice;
using BusinessManagementWebApp.Data.Invoices.GetClientInvoices;
using BusinessManagementWebApp.Data.Invoices.GetInvoice;
using BusinessManagementWebApp.Data.Invoices.GetInvoices;
using BusinessManagementWebApp.Data.Invoices.UpdateInvoice;
using BusinessManagementWebApp.Data.Products.CreateProduct;
using BusinessManagementWebApp.Data.Products.GetProduct;
using BusinessManagementWebApp.Data.Products.GetProducts;
using BusinessManagementWebApp.Data.Products.UpdateProduct;
using BusinessManagementWebApp.Data.Receipts.GetClientReceipts;
using BusinessManagementWebApp.Data.Receipts.GetReceipt;
using BusinessManagementWebApp.Data.Receipts.GetReceipts;
using BusinessManagementWebApp.Data.Receipts.UpdateReceipt;

namespace BusinessManagementWebApp.Data
{

    public class ApiClient(HttpClient http)
    {

        #region Client Endpoints

        public async Task<HttpResponseMessage> CreateClientAsync(CreateClientRequest request)
            => await http.PostAsJsonAsync("/Client", request);

        public async Task<HttpResponseMessage> DeleteClientAsync(long clientID)
            => await http.DeleteAsync($"/Client/{clientID}");

        public async Task<GetClientResponse> GetClientAsync(long clientID)
            => await http.GetFromJsonAsync<GetClientResponse>($"/Client/{clientID}") ?? new GetClientResponse();

        public async Task<GetClientsResponse> GetClientsAsync()
            => await http.GetFromJsonAsync<GetClientsResponse>("/Client") ?? new GetClientsResponse();

        public async Task<HttpResponseMessage> UpdateClientAsync(UpdateClientRequest request)
            => await http.PatchAsJsonAsync("/Client", request);

        #endregion

        #region Invoice Endpoints

        public async Task<HttpResponseMessage> CreateInvoiceAsync(CreateInvoiceRequest request)
            => await http.PostAsJsonAsync("/Invoice", request);

        public async Task<HttpResponseMessage> DeleteInvoiceAsync(long invoiceID)
            => await http.DeleteAsync($"/Invoice/{invoiceID}");

        public async Task<GetClientInvoicesResponse> GetClientInvoicesAsync(long clientID)
            => await http.GetFromJsonAsync<GetClientInvoicesResponse>($"/Invoice/Client/{clientID}") ?? new GetClientInvoicesResponse();

        public async Task<GetInvoiceResponse> GetInvoiceAsync(long invoiceID)
            => await http.GetFromJsonAsync<GetInvoiceResponse>($"/Invoice/{invoiceID}") ?? new GetInvoiceResponse();

        public async Task<GetInvoicesResponse> GetInvoicesAsync()
            => await http.GetFromJsonAsync<GetInvoicesResponse>("/Invoice") ?? new GetInvoicesResponse();

        public async Task<HttpResponseMessage> UpdateInvoiceAsync(UpdateInvoiceRequest request)
            => await http.PatchAsJsonAsync("/Invoice", request);

        #endregion

        #region Product Endpoints

        public async Task<HttpResponseMessage> CreateProductAsync(CreateProductRequest request)
            => await http.PostAsJsonAsync("/Product", request);

        public async Task<HttpResponseMessage> DeleteProductAsync(long productID)
            => await http.DeleteAsync($"/Product/{productID}");

        public async Task<GetProductResponse> GetProductAsync(long productID)
            => await http.GetFromJsonAsync<GetProductResponse>($"/Product/{productID}") ?? new GetProductResponse();

        public async Task<GetProductsResponse> GetProductsAsync()
            => await http.GetFromJsonAsync<GetProductsResponse>("/Product") ?? new GetProductsResponse();

        public async Task<HttpResponseMessage> UpdateProductAsync(UpdateProductRequest request)
            => await http.PatchAsJsonAsync("/Product", request);

        #endregion

        #region Receipt Endpoints

        public async Task<HttpResponseMessage> CreateReceiptAsync(CreateInvoiceRequest request)
            => await http.PostAsJsonAsync("/Receipt", request);

        public async Task<HttpResponseMessage> DeleteReceiptAsync(long receiptID)
            => await http.DeleteAsync($"/Receipt/{receiptID}");

        public async Task<GetClientReceiptsResponse> GetClientReceiptsAsync(long clientID)
            => await http.GetFromJsonAsync<GetClientReceiptsResponse>($"/Receipt/Client/{clientID}") ?? new GetClientReceiptsResponse();

        public async Task<GetReceiptResponse> GetReceiptAsync(long receiptID)
            => await http.GetFromJsonAsync<GetReceiptResponse>($"/Receipt/{receiptID}") ?? new GetReceiptResponse();

        public async Task<GetReceiptsResponse> GetReceiptsAsync()
            => await http.GetFromJsonAsync<GetReceiptsResponse>("/Receipt") ?? new GetReceiptsResponse();

        public async Task<HttpResponseMessage> UpdateReceiptAsync(UpdateReceiptRequest request)
            => await http.PatchAsJsonAsync("/Receipt", request);

        #endregion
    }

}
