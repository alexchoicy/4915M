using AutoMapper;
using Server.Model;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IRestTypeServices
    {
        public List<RestaurantType> GetAllType();

    }
    public class RestTypeServices : IRestTypeServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public RestTypeServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public List<RestaurantType> GetAllType()
        {
            var data = _dataContext.RestaurantType.ToList();




            return data;
        }
    }
}
