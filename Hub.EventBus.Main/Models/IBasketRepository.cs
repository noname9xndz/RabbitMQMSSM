﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hub.EventBus.Main.Models
{
    public interface IBasketRepository
    {
        Task<CustomerBasket> GetBasketAsync(string customerId);
        IEnumerable<string> GetUsers();
        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket);
        Task<bool> DeleteBasketAsync(string id);
    }
}
