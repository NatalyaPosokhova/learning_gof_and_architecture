using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SeaWar
{
    class Program
    {
        public static void Main()
        {
            int shipsQuantity = 0;
            Point point;
            int deckQuantity;
            ShipDirection direction;
            HumanBoardBuilder humanBoardBuilder = new HumanBoardBuilder();

            Console.WriteLine("Сколько кораблей создать?");
            shipsQuantity = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < shipsQuantity; i++)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("ВВедите координаты корабля x:");
                        point.x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ВВедите координаты корабля y:");
                        point.y = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите количество палуб:");
                        deckQuantity = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите направление:");
                        direction = (ShipDirection)Convert.ToInt32(Console.ReadLine());

                        humanBoardBuilder.Add(point, deckQuantity, direction);
                        break;
                    }
                    catch (CreateShipException ex)
                    {
                        Console.WriteLine("Неверные координаты корабля");
                    }
                } while (true);
            }

            List<Player> playersList = new List<Player>();
            playersList.Add(new Computer("Computer"));
            playersList.Add(new Human("Human"));

            List<Board> boardList = new List<Board>();
            boardList.Add(humanBoardBuilder.GetBoard());
            boardList.Add(new ComputerBoardBuilder().GetBoard());

            GameLogic logic = new GameLogic(playersList, boardList);

        }
    }
}
