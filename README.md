# Invoice Automation Web App

A business management web application for tracking clients, invoices, receipts, and products. Built with Blazor Server and MudBlazor, it connects to a companion REST API to provide a clean, responsive interface for day-to-day invoicing and payment workflows.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?logo=blazor&logoColor=white)
![MudBlazor](https://img.shields.io/badge/MudBlazor-8.15-594AE2?logo=materialdesign&logoColor=white)

---

## Features

- **Dashboard** — at-a-glance summary of clients, outstanding invoices, receipts received, and product count
- **Clients** — create, view, edit, and delete client accounts with full contact and address details
- **Invoices** — raise invoices against clients, add line items per product, track outstanding vs. paid status, and export to PDF
- **Receipts** — record payments received and allocate them against outstanding invoices
- **Products** — maintain a product/service catalogue with pricing and stock levels
- **PDF Export** — generate and download invoice and receipt PDFs directly from the browser

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 8 — Blazor Server |
| UI Components | MudBlazor 8.15 (Material Design) |
| Object Mapping | AutoMapper 16.0 |
| JSON Serialization | Newtonsoft.Json 13.0 |
| Backend API | BusinessManagementAPI (separate service) |

---

## Project Structure

```
Components/
├── Dashboard.razor          # Overview stats and recent activity
├── Clients/                 # Client list + view/edit screens
├── Invoices/                # Invoice list, create, view/edit
├── Receipts/                # Receipt list, create, view/edit
├── Products/                # Product catalogue list + view/edit
└── Layout/                  # Nav menu and main layout shell

Data/
├── Entities/                # Core domain models (Client, Invoice, Receipt, Product, ...)
├── {Module}/                # Request/response DTOs per module
└── ApiClient.cs             # Central HTTP client wrapping all API calls

Infrastructure/
└── AutoMapper/              # Mapping profiles between entities and DTOs
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A running instance of **BusinessManagementAPI**
- Visual Studio 2022, VS Code, or JetBrains Rider

### Running the App

1. **Clone the repository**

   ```bash
   git clone https://github.com/reganmacnamara/InvoiceAutomationWebApp.git
   cd InvoiceAutomationWebApp
   ```

2. **Configure the API base address**

   In `appsettings.Development.json`, set the URL of your running BusinessManagementAPI instance:

   ```json
   {
     "ApiBaseAddress": "https://localhost:7285"
   }
   ```

3. **Run the app**

   ```bash
   dotnet run
   ```

   Then open your browser at `https://localhost:5001` (or the port shown in the terminal).

---

## How It Works

The app is a pure frontend — it holds no database of its own. All data is fetched from and persisted to the **BusinessManagementAPI** via HTTP. The `ApiClient` class centralises every API call, keeping components clean.

**Invoice lifecycle:**
1. Create a client
2. Raise an invoice against that client, add line items (linked to products)
3. When payment is received, create a receipt and allocate it against the outstanding invoice
4. The outstanding balance on the invoice is reduced by the allocated receipt amount

---

## License

MIT
