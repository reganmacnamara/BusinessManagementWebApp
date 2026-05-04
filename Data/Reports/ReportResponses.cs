namespace MacsBusinessManagementWebApp.Data.Reports;

public class GetSalesSummaryResponse
{
    public decimal TotalGrossInvoiced { get; set; }
    public decimal TotalTaxInvoiced { get; set; }
    public decimal TotalNetInvoiced { get; set; }
    public decimal TotalReceived { get; set; }
    public decimal TotalOutstanding { get; set; }
    public decimal TotalOverdue { get; set; }
    public int TotalInvoiceCount { get; set; }
    public int PaidInvoiceCount { get; set; }
    public int OutstandingInvoiceCount { get; set; }
    public int OverdueInvoiceCount { get; set; }
    public int TotalReceiptCount { get; set; }
}

public class GetAgingReportResponse
{
    public List<AgingReportLine> Lines { get; set; } = [];
    public decimal TotalOutstanding { get; set; }
    public decimal TotalOverdue { get; set; }
}

public class AgingReportLine
{
    public long InvoiceID { get; set; }
    public string InvoiceRef { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public int DaysOverdue { get; set; }
    public decimal NetValue { get; set; }
    public decimal OffsetValue { get; set; }
    public decimal BalanceOutstanding { get; set; }
    public string AgingBucket { get; set; } = string.Empty;
}

public class GetRevenueByClientResponse
{
    public List<ClientRevenueLine> Lines { get; set; } = [];
}

public class ClientRevenueLine
{
    public long ClientID { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public int InvoiceCount { get; set; }
    public decimal GrossInvoiced { get; set; }
    public decimal TaxInvoiced { get; set; }
    public decimal NetInvoiced { get; set; }
    public decimal TotalReceived { get; set; }
    public decimal TotalOutstanding { get; set; }
}

public class GetRevenueByProductResponse
{
    public List<ProductRevenueLine> Lines { get; set; } = [];
}

public class ProductRevenueLine
{
    public long ProductID { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductCode { get; set; } = string.Empty;
    public decimal UnitsSold { get; set; }
    public decimal GrossRevenue { get; set; }
    public decimal TaxRevenue { get; set; }
    public decimal NetRevenue { get; set; }
    public long QuantityOnHand { get; set; }
    public decimal UnitCost { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal StockValue { get; set; }
}

public class GetRevenueByServiceResponse
{
    public List<ServiceRevenueLine> Lines { get; set; } = [];
}

public class ServiceRevenueLine
{
    public long ServiceID { get; set; }
    public string ServiceName { get; set; } = string.Empty;
    public decimal UnitsBilled { get; set; }
    public decimal GrossRevenue { get; set; }
    public decimal TaxRevenue { get; set; }
    public decimal NetRevenue { get; set; }
    public decimal UnitCost { get; set; }
    public decimal UnitPrice { get; set; }
}

public class GetPaymentPerformanceResponse
{
    public int TotalInvoices { get; set; }
    public int PaidOnTimeCount { get; set; }
    public int PaidLateCount { get; set; }
    public int CurrentOutstandingCount { get; set; }
    public int OverdueCount { get; set; }
    public decimal OnTimePaymentRate { get; set; }
    public List<ClientPaymentPerformanceLine> ByClient { get; set; } = [];
}

public class ClientPaymentPerformanceLine
{
    public long ClientID { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public int TotalInvoices { get; set; }
    public int PaidOnTimeCount { get; set; }
    public int PaidLateCount { get; set; }
    public int CurrentOutstandingCount { get; set; }
    public int OverdueCount { get; set; }
    public decimal OnTimePaymentRate { get; set; }
}

public class GetStockReportResponse
{
    public List<StockReportLine> Lines { get; set; } = [];
    public decimal TotalStockValue { get; set; }
    public decimal TotalRetailValue { get; set; }
}

public class StockReportLine
{
    public long ProductID { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductCode { get; set; } = string.Empty;
    public long QuantityOnHand { get; set; }
    public decimal UnitCost { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal StockValue { get; set; }
    public decimal RetailValue { get; set; }
    public decimal Margin { get; set; }
}
