namespace ProficiencyAssessment.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = "";
        public int Category { get; set; }
        public double Price { get; set; }
        public string? Summary { get; set; }
    }
}

