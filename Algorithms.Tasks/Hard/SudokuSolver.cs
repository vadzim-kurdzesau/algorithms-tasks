namespace Algorithms.Tasks
{
    public class SudokuSolver
    {
        private const char EmptyCell = '.';
        private const char MinDigit = '1';
        private const char MaxDigit = '9';
        private const int RowLength = 9;

        /// <summary>
        /// Solves the sudoku.
        /// </summary>
        /// <param name="board"></param>
        public void SolveSudoku(char[][] board)
        {
            var sudokuBoard = new SudokuBoard();
            sudokuBoard.Import(board);
            Backtrack(board, 0, 0, sudokuBoard);
        }

        private bool Backtrack(char[][] board, int row, int column, SudokuBoard sudokuBoard)
        {
            if (row == RowLength || column == RowLength)
            {
                return true;
            }

            var (nextRow, nextColumn) = NextIndex(row, column);
            if (board[row][column] != EmptyCell)
            {
                return Backtrack(board, nextRow, nextColumn, sudokuBoard);
            }

            // Substitute all possible values
            for (char i = MinDigit; i <= MaxDigit; i++)
            {
                if (sudokuBoard.IsValidToAdd(row, column, i))
                {
                    sudokuBoard.Add(row, column, i);
                    board[row][column] = i;

                    if (Backtrack(board, nextRow, nextColumn, sudokuBoard))
                    {
                        return true;
                    }

                    sudokuBoard.Remove(row, column, i);
                    board[row][column] = EmptyCell;
                }
            }

            return false;
        }

        private static (int row, int column) NextIndex(int row, int column)
        {
            if (column == RowLength - 1)
            {
                return (row + 1, 0);
            }

            return (row, column + 1);
        }

        private class SudokuBoard
        {
            private readonly HashSet<char>[] _rows = new HashSet<char>[RowLength];
            private readonly HashSet<char>[] _columns = new HashSet<char>[RowLength];
            private readonly HashSet<char>[] _boxes = new HashSet<char>[RowLength];

            public SudokuBoard()
            {
                for (int i = 0; i < RowLength; i++)
                {
                    _rows[i] = new HashSet<char>();
                    _columns[i] = new HashSet<char>();
                    _boxes[i] = new HashSet<char>();
                }
            }

            public bool IsValidToAdd(int row, int column, char value)
            {
                if (_rows[row].Contains(value) || _columns[column].Contains(value) || _boxes[GetBoxIndex(row, column)].Contains(value))
                {
                    return false;
                }

                return true;
            }

            public void Add(int row, int column, char value)
            {
                _rows[row].Add(value);
                _columns[column].Add(value);
                _boxes[GetBoxIndex(row, column)].Add(value);
            }

            public void Remove(int row, int column, char value)
            {
                _rows[row].Remove(value);
                _columns[column].Remove(value);
                _boxes[GetBoxIndex(row, column)].Remove(value);
            }

            public void Import(char[][] board)
            {
                for (int row = 0; row < RowLength; row++)
                {
                    for (int column = 0; column < RowLength; column++)
                    {
                        var value = board[row][column];
                        if (value == EmptyCell)
                        {
                            continue;
                        }

                        if (IsValidToAdd(row, column, value))
                        {
                            Add(row, column, value);
                        }
                    }
                }
            }

            private static int GetBoxIndex(int row, int column)
            {
                return 3 * (row / 3) + column / 3;
            }
        }
    }
}
