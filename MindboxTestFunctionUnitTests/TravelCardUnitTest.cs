using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MindboxTestFunction
{
    [TestClass]
    public class TravelCardUnitTest
    {
        [TestMethod]
        public void TestSortCards()
        {
            // Arrange
            List<TravelCard> cards = new List<TravelCard>();
            cards.Add(new TravelCard() { Source = "Берлин", Destination = "Лиссабон" });
            cards.Add(new TravelCard() { Source = "Милан", Destination = "Мюнхен" });
            cards.Add(new TravelCard() { Source = "Лиссабон", Destination = "Москва" });
            cards.Add(new TravelCard() { Source = "Мюнхен", Destination = "Берлин" });
            cards.Add(new TravelCard() { Source = "Рим", Destination = "Милан" });

            // Act
            List<TravelCard> sortedCards = TravelCard.SortCards(cards);

            // Assert
            Assert.AreEqual("Рим", sortedCards.First().Source);
            Assert.AreEqual("Москва", sortedCards.Last().Destination);
            Assert.AreEqual(cards.Count, sortedCards.Count);
        }
    }
}
