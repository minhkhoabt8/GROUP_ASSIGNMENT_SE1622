using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Extensions.Configuration;


namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private static FStoreDBContext dbcontext= new FStoreDBContext();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        // code below here
        private Member GetDefaultMember()
        {
            Member Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
                string email = config["account: defaultAccount: email"];
                string password = config["account: defaultAccount:password"];
                Default = new Member
                {
                    MemberId = 0,
                    Email = email,
                    Password = password,
                    City = "",
                    Country = "",
                    CompanyName = ""


                };

            }
            return Default;
        }
        public List<Member> GetMembers()
        {
            List<Member> members = null;
            try
            {
                using (var context = new FStoreDBContext())
                {
                    members = context.Members.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public void AddMember(Member member)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Member member)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
         public void DeleteMember(int memberID)
         {
             try
             {
                 using (var context = new FStoreDBContext())
                 {
                     var _member = context.Members.SingleOrDefault(value => value.MemberId == memberID);
                     context.Members.Remove(_member);
                     context.SaveChanges();

                 }
             }
             catch (Exception ex)
             {
                 throw new Exception(ex.Message);
             }

         }
        public Member GetMember(int memberId)
        {
            Member member = null;

            try
            {
                var context = new FStoreDBContext();
                member = context.Members.SingleOrDefault(mem => mem.MemberId == memberId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return member;
        }

        public IEnumerable<Order> GetMemberOrderHistory(int memberId)
        {
            try
            {
                var orderList = dbcontext.Orders.Where(o => o.MemberId == memberId).ToList();
                return orderList;
                
            }
            catch(Exception ex)
            {

            }
            return null;
        } 

    }
}
