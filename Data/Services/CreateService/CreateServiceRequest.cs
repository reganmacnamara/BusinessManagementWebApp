using MacsBusinessManagementWebApp.Data.Entities;

namespace MacsBusinessManagementWebApp.Data.Services.CreateService;

public class CreateServiceRequest
{
    public string ServiceName { get; set; } = string.Empty;

    public string ServiceDescription { get; set; } = string.Empty;

    public decimal EstimatedDuration { get; set; }

    public DurationUnit DurationUnit { get; set; }

    public decimal UnitCost { get; set; }

    public decimal UnitPrice { get; set; }
}
