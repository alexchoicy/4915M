using Server.Model;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IUserServices
    {
        public IEnumerable<Staff> GetAll();
    }
    public class UserServices : IUserServices
    {
        private readonly DataContext _dataContext;

        public UserServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Staff> GetAll()
        {
            return _dataContext.staff;
        }
    }
}
