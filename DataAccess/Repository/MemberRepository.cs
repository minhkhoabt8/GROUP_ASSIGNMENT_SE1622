using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddNewMember(Member member)
        {
            throw new NotImplementedException();
        }

        public int CheckLogin(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(int memberID)
        {
            throw new NotImplementedException();
        }

        public Member GetMemberByID(int memberID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetMembers()
        {
            throw new NotImplementedException();
        }

        public void UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
