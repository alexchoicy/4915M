using WebApplication6.Data.Enity;
using WebApplication6.Helper;

namespace WebApplication6.Services
{
    public interface IMemberServices
    {
        public IEnumerable<Member> GetAll();
        Member GetById(int id);
    }

    public class MemberServices : IMemberServices
    {
        private readonly DataContext _context;

        public MemberServices(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Member> GetAll()
        {
            return _context.Member;
        }

        public Member GetById(int id)
        {
            return _context.Member.Find(id);
        }
    }
}
