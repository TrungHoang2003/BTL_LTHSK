using System.Data.Entity;

namespace BTLHSK
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("name = constr") { }
        public DbSet<TaiKhoan> DStaiKhoan { get; set; }
        public DbSet<NhanVien> DSnhanVien { get; set; }
    }
}
