using System;
using System.Collections.Generic;


class MaxSequenceinRowColDiag
{
    static void Main()
    {
        Console.WriteLine("Enter martix's size: ");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        
        string[,] matrix = new string[n, m];
        List<string> MaxSeq = new List<string>();
        int currentSum = 1;
        int maxSum = 0;
        int tempRow = 1;
        int tempCol = 0;

        Console.WriteLine("Enter the cells of the matrix:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

         //Check for max sequence in rows
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m-1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSum++;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        MaxSeq.Clear();
                        MaxSeq.Add(matrix[row, col]);
                    }
                }
                else 
                {
                    currentSum = 1;
                    MaxSeq.Clear();
                }           
            }
            currentSum = 1;
        }        
 
        //Checks max sequence in cols
 
        for (int col = 0; col < m; col++)        
        {
            for (int row = 0; row < n-1; row++)   
            {                
                 if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSum++;
                    
                    //MaxSeq.Add(matrix[row + 1, col]);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        MaxSeq.Clear();
                        MaxSeq.Add(matrix[row, col]);
                    }
                }
                else 
                {
                    currentSum = 1;
                    
                }             
            }
            currentSum = 1;
        }
 
        //Check "Main diagonal" and these above it
        for (int i = 0; i < m-1; i++)
        {
            for (int row = 0, col = tempCol; (row < n-1) && (col < m-1); row++, col++)
            {
                 if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentSum++;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        MaxSeq.Clear();
                        MaxSeq.Add(matrix[row, col]);
                    }
                }
                else 
                {
                    currentSum = 1;
                    
                }
           
            }
            tempCol++;
            currentSum = 1;
        }
 
        //Check diagonals under "Main diagonal"
        for (int i = 0; i < n-1; i++)
        {
            for (int row = tempRow, col = 0; (row < n-1) && (col < m-1); row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentSum++;
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        MaxSeq.Clear();
                        MaxSeq.Add(matrix[row, col]);
                    }
                }
                else 
                {
                    currentSum = 1;
                    
                }
                        
            }
            tempRow++;
            currentSum = 1;
        } 

        //Print result
        Console.WriteLine("Max sequence is of {0} elemets",maxSum);
        for (int i = 0; i < maxSum; i++)
        {
            Console.Write(MaxSeq[0] + " "); 
        }
        Console.WriteLine();
    }
}