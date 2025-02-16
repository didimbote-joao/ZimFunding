using Microsoft.EntityFrameworkCore;

namespace ZimFunding.Model
{
    public class Donation : BaseEntity
    {
        [Precision(18, 2)] // Define precisão e escala
        public decimal Amount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
