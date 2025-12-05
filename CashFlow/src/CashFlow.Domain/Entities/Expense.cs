using CashFlow.Domain.Entities.Enums;

namespace CashFlow.Domain.Entities
{
    public class Expense
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
