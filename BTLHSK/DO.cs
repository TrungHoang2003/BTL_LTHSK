using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHSK
{
    [Table("tblTaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        public int Id { get; set; }
        public string sTenTaiKhoan { get; set; }
        public string sMatKhau { get; set; }
    }

    [Table("tblNhanVien")]
    public class NhanVien
    {
    }
}
