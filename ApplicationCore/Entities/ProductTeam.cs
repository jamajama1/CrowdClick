namespace ApplicationCore.Entities
{
    public class ProductTeam
    {
        public int Id { get; set; }
        public string? MemberResponsibilities { get; set; }

        // Navigation properties
        public int ProductId { get; set; }
        public Project Product { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}