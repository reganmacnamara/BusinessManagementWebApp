<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Blazor-Server-512BD4?style=for-the-badge&logo=blazor&logoColor=white" />
  <img src="https://img.shields.io/badge/MudBlazor-8.15-594AE2?style=for-the-badge&logo=materialdesign&logoColor=white" />
  <img src="https://img.shields.io/badge/License-MIT-10B981?style=for-the-badge" />
</p>

# Mac's Business Manager

A responsive business management frontend for tracking clients, invoices, receipts, products, services, payments, and operational reports. Built with **Blazor Server** and **MudBlazor**, it connects to a companion REST API to provide a clean interface for day-to-day invoicing, payment allocation, reporting, and company administration workflows.

---

## Features

### Authentication
- JWT-based login and registration with short-lived access tokens and long-lived refresh tokens
- Refresh tokens stored server-side and automatically rotated on use
- Automatic token refresh on expiry with transparent retry of failed requests
- Bearer token attached to API requests through a custom `DelegatingHandler`
- Logout revokes the refresh token server-side
- Unauthenticated users are redirected to the login screen
- Company registration flow for onboarding a new business account

### Dashboard
- At-a-glance stat cards for clients, outstanding invoices, payments received, and products
- Recent invoices and receipts with status indicators
- Clickable cards for quick navigation

### Clients
- Full CRUD with contact details and address fields
- Tabbed detail view showing a client's invoices and receipts in one place
- Bulk delete with confirmation dialog

### Invoices
- Raise invoices against clients with editable line items linked to products or services
- Inline cell editing for quantity and price
- Automatic tax and net value calculation, including 10% GST
- Due-date and payment-term support
- Status tracking with color-coded chips
- PDF export for individual invoices

### Receipts
- Record payments and allocate them against outstanding invoices
- Smart allocation that calculates the maximum allocatable amount per invoice
- Unallocated balance shown in real time
- Status tracking with color-coded chips
- PDF export for individual receipts

### Products
- Product catalogue with code, description, pricing, and stock levels
- Low-stock alerts with visual indicators
- Currency-formatted unit cost and unit price fields

### Services
- Reusable service catalogue with descriptions, estimated durations, and pricing
- Create, edit, search, and bulk delete service records
- Service activity support through the API

### Reports
- Date-filtered sales summary, revenue, and payment performance reporting
- Accounts receivable aging report with drill-through to invoices
- Revenue breakdowns by client, product, and service
- Stock valuation and retail value reporting

### Options
- Company details used for invoices and receipts
- Payment term management
- Invoice and receipt reference defaults with optional auto-incrementing

---

## Tech Stack

| Layer | Technology |
|---|---|
| **Framework** | ASP.NET Core 8, Blazor Server |
| **UI Components** | MudBlazor 8.15, Material Design |
| **Object Mapping** | AutoMapper 16.0 |
| **JSON** | Newtonsoft.Json 13.0 |
| **Authentication** | JWT bearer tokens |
| **Backend API** | [BusinessManagementAPI](https://github.com/reganmacnamara/BusinessManagementAPI) (separate service) |

---

## Project Structure

```text
Components/
+-- Auth/                    # Login and registration pages
+-- Clients/                 # Client dialogs and shared client UI
+-- Invoices/                # Invoice item dialogs and invoice UI helpers
+-- Layout/                  # Main layout, empty layout, and navigation
+-- PaymentTerms/            # Payment term dialog
+-- Products/                # Product dialog and shared product UI
+-- Receipts/                # Receipt allocation dialog
+-- Shared/                  # Shared UI such as page load errors

Pages/
+-- Auth/                    # Login and company registration routes
+-- Clients/                 # Client list and detail/edit pages
+-- Invoices/                # Invoice list, create, and detail/edit pages
+-- Options/                 # Company, payment terms, and defaults
+-- Products/                # Product list and detail/edit pages
+-- Receipts/                # Receipt list, create, and detail/edit pages
+-- Reports/                 # Reporting dashboard and report tables
+-- Services/                # Service list and detail/edit pages

Data/
+-- Auth/                    # Login and register request/response DTOs
+-- Entities/                # Domain models
+-- Reports/                 # Report response DTOs
+-- {Module}/                # Request/response DTOs per module
+-- ApiClient.cs             # Central HTTP client wrapping API calls

Infrastructure/
+-- AutoMapper/              # Mapping profiles between entities and DTOs
+-- Services/
    +-- Auth/                # Token storage and authenticated HTTP handling
    +-- Settings/            # User settings service
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A running instance of the **BusinessManagementAPI**
- Visual Studio 2022, VS Code, or JetBrains Rider

### Running the App

1. Clone the repository.

   ```bash
   git clone https://github.com/reganmacnamara/MacsBusinessManagementWebApp.git
   cd MacsBusinessManagementWebApp
   ```

2. Ensure the API is running.

   The app connects to the BusinessManagementAPI at `https://localhost:7285` by default. Update the named `WebAPI` HTTP client in `Program.cs` if your API runs elsewhere.

3. Run the app.

   ```bash
   dotnet run
   ```

   Open your browser at `http://localhost:5099`. The HTTPS profile also serves `https://localhost:7187`.

4. Log in or register.

   Create an account from the login page, then sign in to access the dashboard. Use the company registration flow when setting up a new company account.

---

## How It Works

The app is a frontend client. It holds no database of its own; all business data is fetched from and persisted to the **BusinessManagementAPI** through HTTP. The `ApiClient` class centralizes API calls so pages and components can focus on UI workflows.

### Invoice Lifecycle

```text
Create Client -> Raise Invoice -> Add Line Items -> Receive Payment -> Allocate Receipt
                                      |                                  |
                                      v                                  v
                            Gross / Tax / Net                  Outstanding balance
                              calculated                       reduced automatically
```

1. Create a client with contact and address details.
2. Raise an invoice against that client and add line items linked to products or services.
3. Record a receipt when payment is received.
4. Allocate the receipt against outstanding invoices so invoice balances and statuses update.

---

## API Endpoints Used

| Module | Endpoints |
|---|---|
| **Auth** | `POST /Auth/Login`, `POST /Auth/Register`, `POST /Auth/Refresh`, `POST /Auth/Logout` |
| **Clients** | `GET /Client`, `GET /Client/{id}`, `POST /Client`, `PATCH /Client`, `DELETE /Client/{id}` |
| **Company** | `GET /Company`, `POST /Company/Register`, `POST /Company` |
| **Company Settings** | `GET /CompanySettings`, `POST /CompanySettings` |
| **Invoices** | `GET /Invoice`, `GET /Invoice/{id}`, `GET /Invoice/Client/{id}`, `POST /Invoice`, `PATCH /Invoice`, `DELETE /Invoice/{id}`, `PUT /Invoice/Item`, `DELETE /Invoice/Item/{id}`, `GET /Invoice/{id}/pdf` |
| **Payment Terms** | `GET /PaymentTerms`, `GET /PaymentTerms/{id}`, `POST /PaymentTerms`, `PATCH /PaymentTerms`, `DELETE /PaymentTerms/{id}` |
| **Products** | `GET /Product`, `GET /Product/{id}`, `POST /Product`, `PATCH /Product`, `DELETE /Product/{id}` |
| **Receipts** | `GET /Receipt`, `GET /Receipt/{id}`, `GET /Receipt/Client/{id}`, `POST /Receipt`, `PATCH /Receipt`, `DELETE /Receipt/{id}`, `PUT /Receipt/Item`, `DELETE /Receipt/Item/{id}`, `GET /Receipt/{id}/pdf` |
| **Reports** | `GET /Report/SalesSummary`, `GET /Report/Aging`, `GET /Report/RevenueByClient`, `GET /Report/RevenueByProduct`, `GET /Report/RevenueByService`, `GET /Report/PaymentPerformance`, `GET /Report/Stock` |
| **Services** | `GET /Service`, `GET /Service/{id}`, `POST /Service`, `PATCH /Service`, `DELETE /Service/{id}`, `PUT /Service/Activity`, `DELETE /Service/Activity/{id}` |

Report endpoints that support date filtering accept `dateFrom` and `dateTo` query string values in `yyyy-MM-dd` format.

---

## License

MIT
