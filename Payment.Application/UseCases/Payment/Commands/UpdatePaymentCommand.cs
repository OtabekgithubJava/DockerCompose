namespace Payment.Application.UseCases.Payment.Commands;

public class UpdatePaymentCommand
{
    public int PaymentId { get; set; }
    public int UserId { get; set; }
    public int CourseId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string Status { get; set; }
}