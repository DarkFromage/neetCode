using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetCode
{
    internal class ValidSudokuSolution
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int,Dictionary<int,char>> Matrix = new Dictionary<int, Dictionary<int, char>>();
            Dictionary<int, Dictionary<int, char>> InvertMatrix = new Dictionary<int, Dictionary<int, char>>();
            HashSet<int> QuadrantOne = new HashSet<int>();
            HashSet<int> QuadrantTwo = new HashSet<int>();
            HashSet<int> QuadrantThree = new HashSet<int>();
            HashSet<int> QuadrantFor = new HashSet<int>();
            HashSet<int> QuadrantFive = new HashSet<int>();
            HashSet<int> QuadrantSix = new HashSet<int>();
            HashSet<int> QuadrantSeven = new HashSet<int>(); 
            HashSet<int> QuadrantEight = new HashSet<int>();
            HashSet<int> QuadrantNine = new HashSet<int>();

            for (int i = 0; i <= 8; i++)
            {
                for(int j = 0; j <= 8; j++)
                {
                    if (board[i][j] == '.') continue;

                    if (!Matrix.ContainsKey(i))
                    {
                        Matrix.Add(i, new Dictionary<int, char>());
                    }

                    if (!InvertMatrix.ContainsKey(j))
                    {
                        InvertMatrix.Add(j, new Dictionary<int, char>());
                    }

                    if (Matrix[i].ContainsValue(board[i][j]))
                    {
                        return false;
                    }

                    if (InvertMatrix[j].ContainsValue(board[i][j]))
                    {
                        return false;
                    }

                    switch (i, j)
                    {
                        case var (x, y) when x <= 2 && y <= 2:
                            if (QuadrantOne.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantOne.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 2 && y <= 5 && y > 2:
                            if (QuadrantTwo.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantTwo.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 2 && y <= 8 && y > 5:
                            if (QuadrantThree.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantThree.Add(board[i][j]);
                            break;

                        case var (x, y) when x <= 5 && x > 2 && y <= 2:
                            if (QuadrantFor.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantFor.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 5 && x > 2 && y <= 5 && y > 2:
                            if (QuadrantFive.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantFive.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 5 && x > 2 && y <= 8 && y > 5:
                            if (QuadrantSix.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantSix.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 8 && x > 5 && y <= 2:
                            if (QuadrantSeven.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantSeven.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 8 && x > 5 && y <= 5 && y > 2:
                            if (QuadrantEight.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantEight.Add(board[i][j]);
                            break;
                        case var (x, y) when x <= 8 && x > 5 && y <= 8 && y > 5:
                            if (QuadrantNine.Contains(board[i][j]))
                            {
                                return false;
                            }
                            QuadrantNine.Add(board[i][j]);
                            break;

                        default:
                            break;

                    }

                    Matrix[i].Add(j, board[i][j]);
                    InvertMatrix[j].Add(i, board[i][j]);
                }
            }
            
            return true;
        }
    } 
}
