namespace BusinessManagementWebApp.Data.Entities;

public class TransactionAllocation
{
    public long TransactionAllocationID { get; set; }

    public long AllocatingID { get; set; }

    public long RecievingID { get; set; }

    public decimal AllocationValue { get; set; }

    public DateTime AllocationDate { get; set; }

    public Transaction AllocatingTransaction { get; set; }

    public Transaction RecievingTransaction { get; set; }
}
