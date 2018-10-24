using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace BlackJack.controller
{
  class PlayGame : model.IDrawCardObserver
  {
    private model.Game m_game;
    private view.IView m_view;
    public PlayGame(model.Game a_game, view.IView a_view)
    {
      m_game = a_game;
      m_view = a_view;
    }
    public bool Play()
    {

      m_view.DisplayWelcomeMessage();
      m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
      m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());

      if (m_game.IsGameOver())
      {
        m_view.DisplayGameOver(m_game.IsDealerWinner());
      }

      int input = m_view.GetInput();

      switch (input)
      {
        case (int)view.Alternatives.play:
          m_game.NewGame();
          break;
        case (int)view.Alternatives.hit:
          m_game.Hit();
          break;
        case (int)view.Alternatives.stand:
          m_game.Stand();
          break;
        default:
          break;

      }
      return input != (int)view.Alternatives.quit;

    }
    public void DrawCard()
    {
        Console.Clear();
        m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
        m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());
        m_view.MakePause();
    }
  }
}
