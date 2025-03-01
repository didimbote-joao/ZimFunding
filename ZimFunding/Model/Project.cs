using Microsoft.EntityFrameworkCore;

namespace ZimFunding.Model
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Precision(18, 2)] // Define precisão e escala
        public decimal GoalAmount { get; set; }
        [Precision(18, 2)] // Define precisão e escala
        public decimal CollectedAmount { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public bool IsCompleted { get; set; } = false;

        public int UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string? Image { get; set; } // Caminho da imagem do projeto

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Donation> Donations { get; set; } = new List<Donation>();
    }
}
