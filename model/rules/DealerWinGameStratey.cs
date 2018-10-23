using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class DealerWinGameStratey : IWinnerStrategy
    {
        public bool isWinner(int playerScore, int dealerScore)
        {
            if(playerScore == dealerScore)
            {
                return true;
            }
            return  false;
        }
    }
}