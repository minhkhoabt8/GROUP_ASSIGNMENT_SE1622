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
        Member Login(string email, string password);
        void AddNewMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberID);
        
    }
}
