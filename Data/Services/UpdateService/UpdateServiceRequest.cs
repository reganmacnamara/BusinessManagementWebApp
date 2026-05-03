using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Services.UpdateService;

public class UpdateServiceRequest
{
    public long ServiceID { get; set; }

    public string ServiceName { get; set; } = string.Empty;

    public string ServiceDescription { get; set; } = string.Empty;

    public decimal EstimatedDuration { get; set; }

    public DurationUnit DurationUnit { get; set; }

    public decimal UnitCost { get; set; }

    public decimal UnitPrice { get; set; }
}
