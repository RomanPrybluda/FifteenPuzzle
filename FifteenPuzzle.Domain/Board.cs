using System.Drawing;

namespace FifteenPuzzle.Domain
{
    public class Board
    {
        private Point _chosenField = new Point(3, 3);

        public int[,] GameField { get; } = new int[,]
        {
            { 1, 2, 3, 4 },       // 0,0  0,1  0,2  0,3
            { 5, 6, 7, 8 },       // 1,0  1,1  1,2  1,3
            { 9, 10, 11, 12 },    // 2,0  2,1  2,2  2,3
            { 13, 14, 15, 16 }    // 3,0  3,1  3,2  3,3
        };

        public Board()
        {
            Shuffle();
        }

        public void MoveLeft()
        {
            if (_chosenField.X == 0)
                return;

            var temp = GameField[_chosenField.Y, _chosenField.X - 1];
            GameField[_chosenField.Y, _chosenField.X - 1] = GameField[_chosenField.Y, _chosenField.X];
            GameField[_chosenField.Y, _chosenField.X] = temp;

            _chosenField.X--;
        }

        public void MoveRight()
        {
            if (_chosenField.X == 3)
                return;

            var temp = GameField[_chosenField.Y, _chosenField.X + 1];
            GameField[_chosenField.Y, _chosenField.X + 1] = GameField[_chosenField.Y, _chosenField.X];
            GameField[_chosenField.Y, _chosenField.X] = temp;

            _chosenField.X++;
        }

        public void MoveUp()
        {
            if (_chosenField.Y == 0)
                return;

            var temp = GameField[_chosenField.Y - 1, _chosenField.X];
            GameField[_chosenField.Y - 1, _chosenField.X] = GameField[_chosenField.Y, _chosenField.X];
            GameField[_chosenField.Y, _chosenField.X] = temp;

            _chosenField.Y--;
        }

        public void MoveDown()
        {
            if (_chosenField.Y == 3)
                return;

            var temp = GameField[_chosenField.Y + 1, _chosenField.X];
            GameField[_chosenField.Y + 1, _chosenField.X] = GameField[_chosenField.Y, _chosenField.X];
            GameField[_chosenField.Y, _chosenField.X] = temp;

            _chosenField.Y++;
        }

        public void Shuffle()
        {
            Random rng = new Random();

            for (int i = 0; i < 100; i++)
            {
                var direction = rng.Next(1, 5);
                var step = rng.Next(1, 4);

                for (int j = 1; j <= step; j++)
                {
                    switch (direction)
                    {
                        case 1:
                            MoveRight();
                            break;
                        case 2:
                            MoveLeft();
                            break;
                        case 3:
                            MoveDown();
                            break;
                        case 4:
                            MoveUp();
                            break;
                        default:
                            break;
                    }

                }
            }

        }

        public bool IsVictory()
        {
            int num = 1;
            bool victory = true;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (GameField[i, j] != num)
                    {
                        victory = false;
                        break;
                    }

                    num++;

                }
            }
            return victory;
        }

    }
}