using System.Collections.Generic;

namespace api.Services
{
    public interface IShipmentService
    {
        void Ship(IAddressInfo info, IEnumerable<CartItem> items);
    }
}