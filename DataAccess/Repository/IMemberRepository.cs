using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int memberID);
        void AddNewMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(Member member);
        int CheckLogin(string email, string password);
    }
}
