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
           MemberDAO.Instance.AddMember(member);
        }

        public int CheckLogin(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(Member member)
        {
            MemberDAO.Instance.DeleteMember(member);
        }

        public Member GetMemberByID(int memberID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetMembers()
        {
            return MemberDAO.Instance.GetMembers();
        }

        public void UpdateMember(Member member)
        {
            MemberDAO.Instance.Update(member);
        }
    }
}
