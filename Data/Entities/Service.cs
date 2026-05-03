namespace MacsBusinessManagementWebApp.Data.Entities;

public class Service
{
    public long ServiceID { get; set; }

    public long CompanyID { get; set; }

    public string ServiceName { get; set; } = string.Empty;

    public string ServiceDescription { get; set; } = string.Empty;

    public decimal EstimatedDuration { get; set; }

    public DurationUnit DurationUnit { get; set; }

    public decimal UnitCost { get; set; }

    public decimal UnitPrice { get; set; }

    public List<ServiceActivity> ServiceActivities { get; set; } = [];
}
