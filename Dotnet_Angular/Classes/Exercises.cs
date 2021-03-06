﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace Dotnet_Angular.Classes
{
    public class Exercises
    {
        // TODO refine for extreme inputs
        public static long ConstructArray(int n, int k, int x) {
            // n = array length
            // k = range of numbers
            // x = final element in array
            List<int> previousNumbers = new List<int>(new int[] {1});

            for (int i = 0; i < n - 1; i++){
                if (i == n - 2){
                    for (int j = 0; j < previousNumbers.Count; j++){
                        if (previousNumbers[j] == x) previousNumbers.RemoveAt(j);
                    }
                    break;
                }

                List<int> currentNumbers = new List<int>();
                foreach (int num in previousNumbers){
                    for (int j = 1; j <= k; j++){
                        if (num != j) currentNumbers.Add(j);
                    }
                }

                previousNumbers = new List<int>(currentNumbers);
                currentNumbers.Clear();
            }

            return previousNumbers.Count;
        }

        public static int Pairs(int difference, List<int> input){
            input = input.Distinct().ToList();
            input.Sort((a, b) => -1* a.CompareTo(b));

            int count = 0;
            for (int i = 0; i < input.Count; i++){
                for (int j = 0; j < input.Count; j++){
                    if (input[i] - input[j] > difference)
                        break;
                    if (input[i] - input[j] == difference)
                        count++;
                }
            }
            return count;
        }

        public static int EqualV2(List<int> input){
            input.Sort();
            int min = input[0], max = input[input.Count - 1], count = 0;
            while(max != min){
                int amountToSub = 0;
                switch(max - min)
                {
                    case int n when (n >= 5):
                        amountToSub = 5;
                        break;
                    case int n when (n >= 2 && n <= 4):
                        amountToSub = 2;
                        break;
                    case int n when (n == 1):
                        amountToSub = 1;
                        break;
                }
                max = 0;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] - amountToSub >= min){
                        input[i] -= amountToSub;
                        count++;
                    }
                    if (input[i] == min && input.Count != 2){
                        input.RemoveAt(i--);
                        continue;
                    }
                    if (input[i] > max)
                         max = input[i];
                }
            }
            return count;
        }

        public static int Equal(List<int> input)
        {
            int count = 0;
            while (input.Distinct().Count() != 1)
            {
                int max = 0, min = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    if (i == 0) min = input[i]; // set the min
                    if (input[i] >= max)
                    {
                        max = input[i];
                    }
                    if (input[i] < min)
                    {
                        min = input[i];
                    }
                }

                int amountToSub = 0;
                switch(max - min)
                {
                    case int n when (n >= 5):
                        amountToSub = 5;
                        break;
                    case int n when (n >= 2 && n <= 4):
                        amountToSub = 2;
                        break;
                    case int n when (n == 1):
                        amountToSub = 1;
                        break;
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] - amountToSub >= min){
                        input[i] -= amountToSub;
                        count++;
                    }
                }
            }
            return count;
        }

        public static BigInteger Factorial(int num){
            BigInteger value = new BigInteger(1);
            while (num > 0){
                value = BigInteger.Multiply(value, new BigInteger(num--));
            }
            return value;
        }

        public static int BigSpender(int money, List<int> itemSetOne, List<int> itemSetTwo){
            int max = 0;
            foreach(int itemOne in itemSetOne){
                if (itemOne > money) continue;
                foreach(int itemTwo in itemSetTwo){
                    if (itemTwo > money) continue;
                    int result = itemOne + itemTwo;
                    if (result < money && result > max)
                        max = result;
                }
            }
            return max;
        }

        public static int MatchingPairs(List<string> items)
        {
            int matches = 0;
            Dictionary<string, int> matchingItems = new Dictionary<string, int>();

            foreach (string item in items)
            {
                if (matchingItems.ContainsKey(item))
                // if theres already one item, then now we have a pair
                // increment and then delete key
                {
                    matchingItems.Remove(item);
                    matches++;
                }
                else matchingItems[item] = 0;
            }
            return matches;
        }

        public static long Fib(long num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;

            long cur = 0;
            long next = 1;
            long res = 0;
            while (num-- - 2 >= 0)
            {
                res = cur + next;
                cur = next;
                next = res;
            }
            return res;
        }

        public static ulong FibRecursive(long num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return FibRecursive(num - 1) + FibRecursive(num - 2);
        }
    }
}
