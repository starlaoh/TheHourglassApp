using System;
using System.Collections.Generic;
using System.Text;

namespace TheHourglass.RestaurantRepository
{
    public interface IRestaurantRepo
    {
        Restaurant GetRestaurantWithId(int id);
    }
}
