namespace backend.Repository.Interface
{
    public interface IHouseRepository
    {
        Task<List<HouseDto>> GetAll();
    }
}
