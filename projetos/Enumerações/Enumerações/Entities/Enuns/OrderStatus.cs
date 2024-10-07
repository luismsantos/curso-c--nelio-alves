namespace Enumerações.Entities.Enuns;

public enum OrderStatus : int // derivacao de tipo 
{
    PendingPayment = 0,
    Processing = 1,
    Shipped = 2,
    Delivered = 3
}