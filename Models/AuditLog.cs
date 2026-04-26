using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class AuditLog
    {
        [Key]
        public int LogID { get; set; }
        public int UserID { get; set; }
        public string Action { get; set; }
        public string TableAffected { get; set; }
        public DateTime ActionTime { get; set; }
        public User User { get; set; }
    }
}