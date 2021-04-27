using Kursovik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovik
{
    public class SampleData
    {
        public static void Initialize(UsersContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Email = "Admin",
                        Password = "AdminBTGP",
                    },
                    new User
                    {
                        Email = "MoDeR",
                        Password = "ModerBTGP",
                    });
                context.SaveChanges();
            }

        }
    }
}
