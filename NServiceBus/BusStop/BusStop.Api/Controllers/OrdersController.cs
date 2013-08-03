using System;
using System.Web.Http;
using BusStop.Contracts;

namespace BusStop.Api.Controllers
{
    public class OrdersController : ApiController
    {
        public Guid Get()
        {
            var message = new PlaceOrder
                {
                    OrderId = Guid.NewGuid(),
                    CustomerId = Guid.NewGuid(),
                    ProductId = Guid.NewGuid()
                };

            WebApiApplication.Bus.Send(message);

            return message.OrderId;
        }
    }
}