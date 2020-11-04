using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportClubWebAPI.Models
{
    public class DBInitializer
    {
        public static void Initialize(MemberContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            if (context.Members.Any())
            {
                return;
            }

            context.Users.AddRange(
                new User
                {
                    Username = "test",
                    Password = "test",
                    FirstName = "test",
                    LastName = "test",
                    Email =
                "test@test.be"
                });

            context.Members.AddRange(
                new Member { Name = "Louis Louisen", Dob = new DateTime(1989, 11, 19),
                    Address = "Langstraat100" },
                new Member { Name = "Roel Roelen", Dob = new DateTime(1989, 10, 19),
                    Address = "Dorpsstraat50"});
            context.SaveChanges();
        }
    }
}
