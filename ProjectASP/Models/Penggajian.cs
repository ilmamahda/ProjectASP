using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectASP.Models
{
    [Table("mst_penggajian", Schema = "dbo")]
    public class Penggajian
    {
        [Key]
        public Guid GajiId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public int Nominal { get; set; }
    }
}
