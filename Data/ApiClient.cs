using MacsBusinessManagementWebApp.Data.Auth.Login;
using MacsBusinessManagementWebApp.Data.Auth.Register;
using MacsBusinessManagementWebApp.Data.Clients.CreateClient;
using MacsBusinessManagementWebApp.Data.Clients.GetClient;
using MacsBusinessManagementWebApp.Data.Clients.GetClients;
using MacsBusinessManagementWebApp.Data.Clients.UpdateClient;
using MacsBusinessManagementWebApp.Data.Companies.GetCompany;
using MacsBusinessManagementWebApp.Data.Companies.RegisterCompany;
using MacsBusinessManagementWebApp.Data.Companies.UpdateCompany;
using MacsBusinessManagementWebApp.Data.Invoices.CreateInvoice;
using MacsBusinessManagementWebApp.Data.Invoices.GetClientInvoices;
using MacsBusinessManagementWebApp.Data.Invoices.GetInvoice;
using MacsBusinessManagementWebApp.Data.Invoices.GetInvoices;
using MacsBusinessManagementWebApp.Data.Invoices.UpdateInvoice;
using MacsBusinessManagementWebApp.Data.Invoices.UpsertInvoiceItem;
using MacsBusinessManagementWebApp.Data.PaymentTerms.CreatePaymentTerm;
using MacsBusinessManagementWebApp.Data.PaymentTerms.GetPaymentTerm;
using MacsBusinessManagementWebApp.Data.PaymentTerms.GetPaymentTerms;
using MacsBusinessManagementWebApp.Data.PaymentTerms.UpdatePaymentTerm;
using MacsBusinessManagementWebApp.Data.Products.CreateProduct;
using MacsBusinessManagementWebApp.Data.Products.GetProduct;
using MacsBusinessManagementWebApp.Data.Products.GetProducts;
using MacsBusinessManagementWebApp.Data.Products.UpdateProduct;
using MacsBusinessManagementWebApp.Data.Receipts.CreateReceipt;
using MacsBusinessManagementWebApp.Data.Receipts.GetClientReceipts;
using MacsBusinessManagementWebApp.Data.Receipts.GetReceipt;
using MacsBusinessManagementWebApp.Data.Receipts.GetReceipts;
using MacsBusinessManagementWebApp.Data.Receipts.UpdateReceipt;
using MacsBusinessManagementWebApp.Data.Receipts.UpsertReceiptItem;

namespace MacsBusinessManagementWebApp.Data
{

    public class ApiClient(HttpClient http)
    {

        #region Auth Endpoints

        public async Task<HttpResponseMessage> LoginAsync(LoginAccountRequest request)
            => await http.PostAsJsonAsync("/Auth/Login", request);

        public async Task<HttpResponseMessage> RegisterAsync(RegisterAccountRequest request)
            => await http.PostAsJsonAsync("/Auth/Register", request);

        #endregion

        #region Client Endpoints

        public async Task<HttpResponseMessage> CreateClientAsync(CreateClientRequest request)
            => await http.PostAsJsonAsync("/Client", request);

        public async Task<HttpResponseMessage> DeleteClientAsync(long clientID)
            => await http.DeleteAsync($"/Client/{clientID}");

        public async Task<GetClientResponse> GetClientAsync(long clientID)
            => await http.GetFromJsonAsync<GetClientResponse>($"/Client/{clientID}");

        public async Task<GetClientsResponse> GetClientsAsync()
            => await http.GetFromJsonAsync<GetClientsResponse>("/Client");

        public async Task<HttpResponseMessage> UpdateClientAsync(UpdateClientRequest request)
            => await http.PatchAsJsonAsync("/Client", request);

        #endregion

        #region Company Endpoints

        public async Task<GetCompanyResponse> GetCompanyAsync()
            => await http.GetFromJsonAsync<GetCompanyResponse>("/Company");

        public async Task<HttpResponseMessage> RegisterCompanyAsync(RegisterCompanyRequest request)
            => await http.PostAsJsonAsync("/Company/Register", request);

        public async Task<HttpResponseMessage> UpdateCompanyAsync(UpdateCompanyRequest request)
            => await http.PatchAsJsonAsync("/Company", request);

        #endregion

        #region Invoice Endpoints

        public async Task<HttpResponseMessage> CreateInvoiceAsync(CreateInvoiceRequest request)
            => await http.PostAsJsonAsync("/Invoice", request);

        public async Task<HttpResponseMessage> DeleteInvoiceAsync(long invoiceID)
            => await http.DeleteAsync($"/Invoice/{invoiceID}");

        public async Task<HttpResponseMessage> DeleteInvoiceItemAsync(long invoiceItemID)
            => await http.DeleteAsync($"/Invoice/Item/{invoiceItemID}");

        public async Task<GetClientInvoicesResponse> GetClientInvoicesAsync(long clientID)
            => await http.GetFromJsonAsync<GetClientInvoicesResponse>($"/Invoice/Client/{clientID}");

        public async Task<GetInvoiceResponse> GetInvoiceAsync(long invoiceID)
            => await http.GetFromJsonAsync<GetInvoiceResponse>($"/Invoice/{invoiceID}");

        public async Task<GetInvoicesResponse> GetInvoicesAsync()
            => await http.GetFromJsonAsync<GetInvoicesResponse>("/Invoice");

        public async Task<HttpResponseMessage> UpdateInvoiceAsync(UpdateInvoiceRequest request)
            => await http.PatchAsJsonAsync("/Invoice", request);

        public async Task<HttpResponseMessage> UpsertInvoiceItemAsync(UpsertInvoiceItemRequest request)
            => await http.PutAsJsonAsync("/Invoice/Item", request);

        #endregion

        #region PaymentTerm Endpoints

        public async Task<HttpResponseMessage> CreatePaymentTermAsync(CreatePaymentTermRequest request)
            => await http.PostAsJsonAsync("/PaymentTerms", request);

        public async Task<HttpResponseMessage> DeletePaymentTermAsync(long paymentTermID)
            => await http.DeleteAsync($"/PaymentTerms/{paymentTermID}");

        public async Task<GetPaymentTermResponse> GetPaymentTermAsync(long paymentTermID)
            => await http.GetFromJsonAsync<GetPaymentTermResponse>($"/PaymentTerms/{paymentTermID}");

        public async Task<GetPaymentTermsResponse> GetPaymentTermsAsync()
            => await http.GetFromJsonAsync<GetPaymentTermsResponse>("/PaymentTerms");

        public async Task<HttpResponseMessage> UpdatePaymentTermAsync(UpdatePaymentTermRequest request)
            => await http.PatchAsJsonAsync("/PaymentTerms", request);

        #endregion

        #region Product Endpoints

        public async Task<HttpResponseMessage> CreateProductAsync(CreateProductRequest request)
            => await http.PostAsJsonAsync("/Product", request);

        public async Task<HttpResponseMessage> DeleteProductAsync(long productID)
            => await http.DeleteAsync($"/Product/{productID}");

        public async Task<GetProductResponse> GetProductAsync(long productID)
            => await http.GetFromJsonAsync<GetProductResponse>($"/Product/{productID}");

        public async Task<GetProductsResponse> GetProductsAsync()
            => await http.GetFromJsonAsync<GetProductsResponse>("/Product");

        public async Task<HttpResponseMessage> UpdateProductAsync(UpdateProductRequest request)
            => await http.PatchAsJsonAsync("/Product", request);

        #endregion

        #region PDF Export Endpoints

        public async Task<HttpResponseMessage> ExportInvoicePdfAsync(long invoiceID)
            => await http.GetAsync($"/Invoice/{invoiceID}/pdf");

        public async Task<HttpResponseMessage> ExportReceiptPdfAsync(long receiptID)
            => await http.GetAsync($"/Receipt/{receiptID}/pdf");

        #endregion

        #region Receipt Endpoints

        public async Task<HttpResponseMessage> CreateReceiptAsync(CreateReceiptRequest request)
            => await http.PostAsJsonAsync("/Receipt", request);

        public async Task<HttpResponseMessage> DeleteReceiptAsync(long receiptID)
            => await http.DeleteAsync($"/Receipt/{receiptID}");

        public async Task<HttpResponseMessage> DeleteReceiptItemAsync(long receiptItemID)
            => await http.DeleteAsync($"/Receipt/Item/{receiptItemID}");

        public async Task<GetClientReceiptsResponse> GetClientReceiptsAsync(long clientID)
            => await http.GetFromJsonAsync<GetClientReceiptsResponse>($"/Receipt/Client/{clientID}");

        public async Task<GetReceiptResponse> GetReceiptAsync(long receiptID)
            => await http.GetFromJsonAsync<GetReceiptResponse>($"/Receipt/{receiptID}");

        public async Task<GetReceiptsResponse> GetReceiptsAsync()
            => await http.GetFromJsonAsync<GetReceiptsResponse>("/Receipt");

        public async Task<HttpResponseMessage> UpdateReceiptAsync(UpdateReceiptRequest request)
            => await http.PatchAsJsonAsync("/Receipt", request);

        public async Task<HttpResponseMessage> UpsertReceiptItemAsync(UpsertReceiptItemRequest request)
            => await http.PutAsJsonAsync("/Receipt/Item", request);

        #endregion
    }

}
