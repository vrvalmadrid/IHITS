using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inHealthTechnicalExam.DataAccessLayer.Models
{
    [Table("UserRole", Schema = "dbo")]
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "UserRole Id")]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "User Id")]
        public int UserID { get; set; }
        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Role Id")]
        public int RoleID { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
