<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Blazor-Server-512BD4?style=for-the-badge&logo=blazor&logoColor=white" />
  <img src="https://img.shields.io/badge/MudBlazor-8.15-594AE2?style=for-the-badge&logo=materialdesign&logoColor=white" />
  <img src="https://img.shields.io/badge/License-MIT-10B981?style=for-the-badge" />
</p>

# Mac's Business Manager

A modern, responsive business management frontend for tracking clients, invoices, receipts, and products. Built with **Blazor Server** and **MudBlazor**, it connects to a companion REST API to provide a clean interface for day-to-day invoicing and payment workflows.

---

## Features

### Authentication
- JWT-based login and registration with short-lived access tokens (60 min) and long-lived refresh tokens (30 days)
- Refresh tokens stored server-side and automatically rotated on use
- Automatic token refresh on expiry with transparent retry of failed requests
- Bearer token attached to all API requests via a custom `DelegatingHandler`
- Logout revokes refresh token server-side
- Unauthenticated users are automatically redirected to the login screen

### Dashboard
- At-a-glance stat cards: total clients, outstanding invoices (with dollar amounts), payments received, and product count
- Recent invoices and receipts with status indicators
- Clickable cards for quick navigation

### Clients
- Full CRUD with contact details and address fields
- Tabbed detail view showing the client's invoices and receipts in one place
- Bulk delete with confirmation dialog

### Invoices
- Raise invoices against clients with editable line items linked to products
- Inline cell editing for quantity and price
- Automatic tax and net value calculation (10% GST)
- Status tracking: **Outstanding** / **Paid** chips with color coding
- PDF export (single or bulk)

### Receipts
- Record payments and allocate them against outstanding invoices
- Smart allocation: auto-calculates maximum allocatable amount per invoice
- Un-allocated balance shown in real time
- Status tracking: **Unallocated** / **Allocated** chips
- PDF export (single or bulk)

### Products
- Product/service catalogue with code, description, pricing, and stock levels
- Low-stock alerts (5 or fewer in stock) with visual indicators
- Currency-formatted unit cost and unit price fields

---

## Tech Stack

| Layer | Technology |
|---|---|
| **Framework** | ASP.NET Core 8 — Blazor Server |
| **UI Components** | MudBlazor 8.15 (Material Design) |
| **Object Mapping** | AutoMapper 16.0 |
| **Authentication** | JWT Bearer Tokens |
| **Backend API** | [BusinessManagementAPI](https://github.com/reganmacnamara/BusinessManagementAPI) (separate service) |

---

## Project Structure

```
Components/
├── Auth/                    # Login & registration page
├── Dashboard.razor          # Overview stats and recent activity
├── Clients/                 # Client list, view/edit, add dialog
├── Invoices/                # Invoice list, create, view/edit, add item dialog
├── Receipts/                # Receipt list, create, view/edit, allocation dialog
├── Products/                # Product catalogue, view/edit, add dialog
└── Layout/
    ├── MainLayout.razor     # App shell with theme, nav drawer, auth guard
    ├── EmptyLayout.razor    # Minimal layout for login page
    └── NavMenu.razor        # Sidebar navigation

Data/
├── Auth/                    # Login & register request/response DTOs
├── Entities/                # Domain models (Client, Invoice, Receipt, Product, ...)
├── {Module}/                # Request/response DTOs per module
└── ApiClient.cs             # Central HTTP client wrapping all API calls

Infrastructure/
├── Services/Auth/           # AuthTokenService (token + refresh cookie storage), AuthHeaderHandler (auto-refresh on 401, cookie attach/capture)
└── AutoMapper/              # Mapping profiles between entities and DTOs
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A running instance of the **BusinessManagementAPI**
- Visual Studio 2022, VS Code, or JetBrains Rider

### Running the App

1. **Clone the repository**

   ```bash
   git clone https://github.com/reganmacnamara/InvoiceAutomationWebApp.git
   cd InvoiceAutomationWebApp
   ```

2. **Ensure the API is running**

   The app connects to the BusinessManagementAPI at `https://localhost:7285` by default. Update the base address in `Program.cs` if your API runs elsewhere.

3. **Run the app**

   ```bash
   dotnet run
   ```

   Open your browser at `http://localhost:5099`.

4. **Log in or register**

   Create an account from the login page, then sign in to access the dashboard.

---

## How It Works

The app is a pure frontend — it holds no database of its own. All data is fetched from and persisted to the **BusinessManagementAPI** via HTTP. The `ApiClient` class centralises every API call, keeping components clean.

### Invoice Lifecycle

```
Create Client  →  Raise Invoice  →  Add Line Items  →  Receive Payment  →  Allocate Receipt
                                         ↓                                       ↓
                                   Auto-calculates               Outstanding balance reduced
                                   Gross / Tax / Net             Invoice marked as Paid
```

1. **Create a client** with contact and address details
2. **Raise an invoice** against that client and add line items linked to products
3. **Record a receipt** when payment is received
4. **Allocate the receipt** against outstanding invoices — the balance updates automatically

---

## API Endpoints Used

| Module | Endpoints |
|---|---|
| **Auth** | `POST /Auth/Login` · `POST /Auth/Register` · `POST /Auth/Refresh` · `POST /Auth/Logout` |
| **Clients** | `GET /Client` · `GET /Client/{id}` · `POST /Client` · `PATCH /Client` · `DELETE /Client/{id}` |
| **Invoices** | `GET /Invoice` · `GET /Invoice/{id}` · `GET /Invoice/Client/{id}` · `POST /Invoice` · `PATCH /Invoice` · `DELETE /Invoice/{id}` · `PUT /Invoice/Item` · `DELETE /Invoice/Item/{id}` · `GET /Invoice/{id}/pdf` |
| **Receipts** | `GET /Receipt` · `GET /Receipt/{id}` · `GET /Receipt/Client/{id}` · `POST /Receipt` · `PATCH /Receipt` · `DELETE /Receipt/{id}` · `PUT /Receipt/Item` · `DELETE /Receipt/Item/{id}` · `GET /Receipt/{id}/pdf` |
| **Products** | `GET /Product` · `GET /Product/{id}` · `POST /Product` · `PATCH /Product` · `DELETE /Product/{id}` |

---

## License

MIT
