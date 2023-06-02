using AutoMapper;
using Server.Model;
using Server.Model.Entity;

namespace Server.Services
{
    public interface ISupplierServices
    {
        public IEnumerable<Suppliers> getAll();
    }
    public class SupplierServices : ISupplierServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public SupplierServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public IEnumerable<Suppliers> getAll()
        {
            return _dataContext.suppliers;
        }
    }
}
