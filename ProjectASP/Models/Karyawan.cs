using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectASP.Models
{
    [Table("mst_karyawan", Schema = "dbo")]

    public class Karyawan
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Handphone { get; set; }
        public string Email { get; set; }
        public string? Note { get; set; }

    }
}
