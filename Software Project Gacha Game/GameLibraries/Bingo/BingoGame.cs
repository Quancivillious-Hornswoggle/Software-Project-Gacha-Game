using System;
using System.Collections.Generic;

namespace BingoGameApp
{
    public class BingoGame
    {
        private bool _gameActive;
        private readonly List<int> _calledNumbers = new List<int>();
        private readonly int[,] _card = new int[5, 5];
        private readonly bool[,] _marked = new bool[5, 5];
        private readonly Random _random = new Random();

        public BingoGame()
        {
        }

        public void GenerateCard()
        {
            int[] mins = new int[] { 1, 16, 31, 46, 61 };
            int[] maxs = new int[] { 15, 30, 45, 60, 75 };
            for (int col = 0; col < 5; col++)
            {
                HashSet<int> used = new HashSet<int>();
                for (int row = 0; row < 5; row++)
                {
                    int num;
                    do
                    {
                        num = _random.Next(mins[col], maxs[col] + 1);
                    } while (!used.Add(num));
                    _card[row, col] = num;
                    _marked[row, col] = false;
                }
            }
            _card[2, 2] = 0;
            _marked[2, 2] = true;
        }

        public void StartGame()
        {
            _gameActive = true;
            _calledNumbers.Clear();
            for (int row = 0; row < 5; row++)
                for (int col = 0; col < 5; col++)
                    _marked[row, col] = false;
            _marked[2, 2] = true;
        }

        public CallResult CallNumber()
        {
            if (!_gameActive || _calledNumbers.Count >= 75)
            {
                _gameActive = false;
                return null;
            }
            int number;
            do
            {
                number = _random.Next(1, 76);
            } while (_calledNumbers.Contains(number));
            _calledNumbers.Add(number);
            bool found = MarkNumber(number);
            bool won = found && CheckWin();
            if (won)
                _gameActive = false;
            return new CallResult(number, found, won);
        }

        private bool MarkNumber(int number)
        {
            for (int row = 0; row < 5; row++)
                for (int col = 0; col < 5; col++)
                    if (_card[row, col] == number)
                    {
                        _marked[row, col] = true;
                        return true;
                    }
            return false;
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 5; i++)
                if (IsComplete(GetRow(i)) || IsComplete(GetCol(i)))
                    return true;
            bool diag1 = true, diag2 = true;
            for (int i = 0; i < 5; i++)
            {
                diag1 &= _marked[i, i];
                diag2 &= _marked[i, 4 - i];
            }
            return diag1 || diag2;
        }

        private bool[] GetRow(int row)
        {
            bool[] r = new bool[5];
            for (int i = 0; i < 5; i++)
                r[i] = _marked[row, i];
            return r;
        }

        private bool[] GetCol(int col)
        {
            bool[] c = new bool[5];
            for (int i = 0; i < 5; i++)
                c[i] = _marked[i, col];
            return c;
        }

        private bool IsComplete(bool[] arr)
        {
            foreach (bool b in arr)
                if (!b)
                    return false;
            return true;
        }

        public int GetCardNumber(int row, int col)
        {
            return _card[row, col];
        }

        public bool IsMarked(int row, int col)
        {
            return _marked[row, col];
        }

        public bool IsGameActive()
        {
            return _gameActive;
        }

        public List<int> GetCalledNumbers()
        {
            return new List<int>(_calledNumbers);
        }

        public void Reset()
        {
            _gameActive = false;
            _calledNumbers.Clear();
            for (int row = 0; row < 5; row++)
                for (int col = 0; col < 5; col++)
                    _marked[row, col] = false;
        }

        public string GetDisplayNumber(int row, int col)
        {
            return _card[row, col] == 0 ? "FREE" : _card[row, col].ToString();
        }

        public class CallResult
        {
            public int Number { get; }
            public bool FoundOnCard { get; }
            public bool Won { get; }

            public CallResult(int number, bool foundOnCard, bool won)
            {
                Number = number;
                FoundOnCard = foundOnCard;
                Won = won;
            }

            public string GetFormattedNumber()
            {
                char letter = Number <= 15 ? 'B' : Number <= 30 ? 'I' : Number <= 45 ? 'N' : Number <= 60 ? 'G' : 'O';
                return $"{letter}{Number}";
            }
        }
    }
}
