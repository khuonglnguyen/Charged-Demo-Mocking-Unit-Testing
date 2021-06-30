using System.Collections.Generic;

namespace api.Services
{
    public interface ICartService 
  {
    double Total();
    IEnumerable<CartItem> Items();
  }
}