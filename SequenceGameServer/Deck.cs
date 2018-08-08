using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceGameServer
{
    public class Deck : IDeck
    {
        private Stack<ICard> _cards;
        private IRandomNumberGenerator _randomNumberGenerator;

        public Deck(IRandomNumberGenerator randomNumberGenerator)
        {
            _cards = new Stack<ICard>();
            _randomNumberGenerator = randomNumberGenerator;
        }

        public int CardsRemaining => _cards.Count;

        public void AddCard(ICard card)
        {
            _cards.Push(card);
        }
		
        public ICard Draw()
        {
            return _cards.Pop();
        }
		
        public void Shuffle()
        {
            var cardList = _cards.ToArray();
            _cards.Clear();
            _cards = new Stack<ICard>(cardList.OrderBy(x => _randomNumberGenerator.Generate(cardList.Length)));
        }
    }
}