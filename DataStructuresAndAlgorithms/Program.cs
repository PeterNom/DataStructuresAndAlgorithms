// See https://aka.ms/new-console-template for more information
using DataStructuresAndAlgorithms;

Console.WriteLine("Hello, World!");
int[] ints   = { 12, 11, 13, 5, 6, 7 };
int[] subMax = { 13,-3,-25,20, -3, -16, -23, 18, 20, -7, 12, -5,-22,15,-4,7 };

SortingAlgorithms mySort = new SortingAlgorithms(ints);
MinMaxAlgorithms myMax = new MinMaxAlgorithms(subMax);

int[] ints1 = mySort.InsertionSortV2();

foreach (int i in ints1)
    Console.WriteLine(i);

int[] ints2 = mySort.BubbleSort();

foreach (int i in ints2)
    Console.WriteLine(i);

mySort.Mergesort(0, mySort.GetArray().Length-1);

foreach (int i in mySort.GetArray())
    Console.WriteLine(i);

Console.WriteLine(myMax.FindMaximumSubarray(0, myMax.GetArray().Length-1));
