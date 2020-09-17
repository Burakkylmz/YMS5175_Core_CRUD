using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YMS5175_Core_CRUD.DataAccess.ORM.Entities;

namespace YMS5175_Core_CRUD.DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {
            //Standart .Net'te database ile iletişime geçmemizi sağlayan "ConnectionString" sentax'sını burada yazıyorduk. Core'da işler biraz değişti. Core projelerimizin her safhasında bizi dependancy injection'a zorladığı için database connection yaparkende bu hususa uymamızı bekliyor. Ayrıca Core çalışma mantığı sizelere anlatrıken "pipelines" ve içerisinde barındırdığı iş parçacıkları yani "middleware"lardan bahsetmiştim. Project Context nesnemde CRUD operasyonlarını yürütürken kullanılan bir yapı olduğu için Core'un pipeline'ına eklememiz gerekmektedir.
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
