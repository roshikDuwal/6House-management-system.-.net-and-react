using backend.Repository.Interface;

namespace backend.Repository.Implementation
{
    public class HouseRepository : IHouseRepository
    {
        public Task<List<HouseDto>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
