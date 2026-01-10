namespace InvoiceAutomationWebApp.Infrastructure.Enums
{
    public sealed class TransactionType
    {
        public string Code { get; }

        private TransactionType(string code)
            => Code = code;

        public static readonly TransactionType Invoice = new("INV");
        public static readonly TransactionType Receipt = new("REC");

        public override string ToString() => Code;
    }
}
