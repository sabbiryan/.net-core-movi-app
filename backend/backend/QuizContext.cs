using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    public class QuizContext: DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options): base(options)
        {
            
        }

        public virtual DbSet<Question> Questions { get; set; }
    }



    public class UserDbContext : IdentityDbContext<IdentityUser>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options);
        {
            
        }
    }
}
