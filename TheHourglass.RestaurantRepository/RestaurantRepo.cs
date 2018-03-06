using Dapper;
using System.Data;
using System.Linq;

namespace TheHourglass.RestaurantRepository
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private readonly IDbConnection _conn;

        public RestaurantRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public Restaurant GetRestaurantWithId(int id)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<Restaurant>("SELECT * FROM restaurant WHERE restaurantid = @id", new { id }).FirstOrDefault();
            }
        }
    }
}
