using FluentAssertions;
using Lernkartei.Common.Enum;
using Lernkartei.Domain.Abstraction;
using Lernkartei.Dto.Card;
using Lernkartei.Infrastructure.Concrete;
using Lernkartei.Service.Abstract.Card;
using Lernkartei.Service.Concrete.Card;
using Lernkartei.Test.Persist;
using Microsoft.EntityFrameworkCore;
using Swish.InfraStructure.context;

namespace Lernkartei.Test
{
    public class CardTest : PersistTest
    {
        DbContextOptionsBuilder<LernkarteiContext> optionsBuilder = new();
        private readonly ICardService _cardService;
        private readonly ICardRepository _cardREpository;
        private readonly LernkarteiContext _contex;
        public CardTest()
        {
            optionsBuilder.UseSqlServer(GlobalVariables.connectionstring);
            _contex = new LernkarteiContext(optionsBuilder.Options);
            _cardREpository = new CardRepository(_contex);
            _cardService = new CardService(_cardREpository);
        }
        [Fact]
        public void Add_Card_SuccessfullyAddRowToCard()
        {
            CardDto model = new CardDto
            {
                Id = 0,
                Front = "انجام دادن",
                Back = "Machen",
                WordTypes = WordTypes.Verb,
                Artikle = Artikle.Null,
                Plural = null,
                Perfekt = "gemacht"
            };
            CardDto result = _cardService.Add(model);
            result.Id.Should().BeGreaterThan(0);
        }
    }
}