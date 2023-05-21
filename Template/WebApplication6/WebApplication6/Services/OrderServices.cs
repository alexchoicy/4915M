using WebApplication6.Data.Enity;
using WebApplication6.Helper;

namespace WebApplication6.Services
{
    public interface IOrderServices
    {
        public IEnumerable<Order> GetAll();
        Order GetById(int id);
    }

    public class OrderServices : IOrderServices
    {
        private readonly DataContext _context;

        public OrderServices(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Member;
        }

        public Order GetById(int id)
        {
            return _context.Member.Find(id);
        }
    }
}
