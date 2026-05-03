namespace MacsBusinessManagementWebApp.Data.Services.UpsertServiceActivity;

public class UpsertServiceActivityRequest
{
    public long ServiceActivityID { get; set; }

    public long ServiceID { get; set; }

    public string ActivityName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int SortOrder { get; set; }
}
