namespace ZimFunding.Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User"; // Definição padrão
        public bool Active { get; set; } = false; // Começa desativado até confirmação
        public string ActivationCode { get; set; }
        public string? ProfilePicture { get; set; } // Caminho da foto do usuário
        public ICollection<Project> Projects { get; set; } = new List<Project>(); 
        public ICollection<Donation> Donations { get; set; } = new List<Donation>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
