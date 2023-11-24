// See https://aka.ms/new-console-template for more information
using DataStructuresAndAlgorithms;

Console.WriteLine("Hello, World!");
int[] ints = { 12, 11, 13, 5, 6, 7 };

SortingArlgorims mySort = new SortingArlgorims(ints);

int[] ints1 = mySort.InsertionSortV2();

foreach (int i in ints1)
    Console.WriteLine(i);

int[] ints2 = mySort.BubbleSort();

foreach (int i in ints2)
    Console.WriteLine(i);

mySort.Mergesort(0, mySort.GetArray().Length-1);

foreach (int i in mySort.GetArray())
    Console.WriteLine(i);