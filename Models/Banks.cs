using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Bank
    {
        [Key]
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string BankType { get; set; }
        public int EstablishedYear { get; set; }
        public bool IsActive { get; set; }
    }
}