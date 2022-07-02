namespace Lernkartei.Domain.Entities
{
    public partial class Card
    {
        public Card()
        {
            Front = "";
            Back = "";
        }
        public int Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
        public string? Plural { get; set; }
        public string? Perfekt { get; set; }
        public int WordTypes { get; set; }
        public int Artikle { get; set; }

    }
}
