using KolokwiumPrzykladowe.DTOs;

namespace KolokwiumPrzykladowe.Services;

public interface IDbService
{
    Task<OrderDto> GetOrderById(int orderId);
    Task FulfillOrder(int orderId, FulfillOrderDto dto);
}