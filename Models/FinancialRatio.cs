using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class FinancialRatio
    {
        [Key]
        public int RatioID { get; set; }
        public int BankID { get; set; }
        public int CategoryID { get; set; }
        public string RatioName { get; set; }
        public decimal RatioValue { get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }
        public Bank Bank { get; set; }
        public RatioCategory RatioCategory { get; set; }
    }
}