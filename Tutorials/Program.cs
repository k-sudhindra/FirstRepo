/*
 * Updated for barch
 * 
 * using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    
    //  Complete the diagonalDifference function below.
     
    static int diagonalDifference(int[][] a)
    {

        int leftDiagonalSum = 0;
        //Console.WriteLine(a.Length);
        for (int leftDiagonalIndx = 0; leftDiagonalIndx < a.Length; leftDiagonalIndx++)
        {
            Console.WriteLine("Fetching value at a[{0}][{0}]", leftDiagonalIndx);
            Console.WriteLine(a[leftDiagonalIndx][leftDiagonalIndx]);
            leftDiagonalSum += a[leftDiagonalIndx][leftDiagonalIndx];

        }

        int rightDiagonalSum = 0;
        int rightDiagonalFirstAxis = 0;

        for (int rightDiagonalIndx = a.Length - 1; rightDiagonalIndx >= 0; rightDiagonalIndx--)
        {
            rightDiagonalSum += a[rightDiagonalFirstAxis][rightDiagonalIndx];
            rightDiagonalFirstAxis++;

        }
        return Math.Abs(rightDiagonalSum - leftDiagonalSum);


    }

    static void Main(string[] args)
    {
       // TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++)
        {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}*/


/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    
     // Complete the plusMinus function below.
     
    static void plusMinus(int[] arr)
    {
        int postiveEntries = 0;
        int negativeEntries = 0;
        int zeroValueEntries = 0;
 

        foreach(int entry in arr)
        {
            if(entry == 0 )
            {
                zeroValueEntries++;
            } else if(entry > 0)
            {
                postiveEntries++;
             
            } else
            {
                negativeEntries++;
            }


        }

        Console.WriteLine((float)postiveEntries / arr.Length);
        Console.WriteLine((float)negativeEntries / arr.Length);
        Console.WriteLine((float)zeroValueEntries / arr.Length);


    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the miniMaxSum function below.
     */
    static void miniMaxSum(int[] arr)
    {
        Int64 minSum = 0;
        Int64 maxSum = 0;
        int count = 4;
        for (int i = 0; i < arr.Length; i++)
        {
            Int64 sum = arr[i];
            int secondIndx = i + 1;
            for (int j =0; j < count; j++)
            {
                secondIndx += j;
                int indx = i + secondIndx;
                if (indx > arr.Length - 1)
                {
                    indx = arr.Length - indx;
                }
                sum += arr[indx];
            }
            if(i==0)
            {
                minSum = maxSum = sum;
            }
            if (sum < minSum)
                minSum = sum;
            if (sum > maxSum)
                maxSum = sum;
        }
        Console.WriteLine("{0}  {1}", minSum, maxSum);

    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}