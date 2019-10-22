using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Lan");
            P2 = new Player("Thao");
            Game = new Board(3, 4, 6);
        }
        public  void Playgame()
        {
            Game.Printgame();
            while(true)
            {
                Console.WriteLine(P1.GetName() + " a turn");
                P1.PickBall(Game);
                Game.Printgame();
                if (Game.Isgameover())
                {
                    Console.WriteLine(P1.GetName() + "Loses");
                    Console.WriteLine(P2.GetName() + "Win");
                    break;
                }
                Console.WriteLine(P2.GetName() + " a turn");
                P2.PickBall(Game);
                Game.Printgame();
                if (Game.Isgameover())
                {
                    Console.WriteLine(P1.GetName() + "Win");
                    Console.WriteLine(P2.GetName() + "Lose");
                    break;
                }
            }
        }
    }
}
