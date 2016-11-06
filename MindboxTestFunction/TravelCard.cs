using System.Collections.Generic;
using System.Linq;

namespace MindboxTestFunction
{
    public class TravelCard
    {
        public string Source { get; set; }
        public string Destination { get; set; }

        // Требуемая заданием функция.
        // Временная сложность алгоритма сортировки: в лучшем случае - O(n+1); в среднем случае - O(2n^2); в худшем случае - O(2n^2).
        // Ёмкостная сложность алгоритма сортировки: O(n).
        public static List<TravelCard> SortCards(List<TravelCard> cards)
        {
            List<TravelCard> sortedCards = new List<TravelCard>();

            // Поиск первой карточки.
            foreach (TravelCard card in cards)
            {
                // Если пункт отправления карточки не повторяется в пунктах назначения других карточек, то такая карточка будет первой.
                if (cards.Find(c => c.Destination == card.Source) == null)
                {
                    sortedCards.Add(card);

                    // Добавление остальных карточек в упорядоченный список.
                    for (int i = 0; i < cards.Count; i++)
                    {
                        // Если пункт отправления карточки совпадает с пунктом назначения последней карточки в упорядоченном списке, то такая карточка добавляется в список.
                        if (cards[i].Source == sortedCards.Last().Destination)
                        {
                            sortedCards.Add(cards[i]);
                            i = -1;
                            continue;
                        }
                    }

                    break;
                }
            }

            return sortedCards;
        }
    }
}
