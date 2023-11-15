// See https://aka.ms/new-console-template for more information
using DataStructuresAndAlgorithms;

Console.WriteLine("Hello, World!");
int[] ints = { 5, 2, 4, 6, 1, 3};

SortingArlgorims mySort = new SortingArlgorims(ints);

int[] ints1 = mySort.InsertionSort_2();

foreach (int i in ints1)
    Console.WriteLine(i);