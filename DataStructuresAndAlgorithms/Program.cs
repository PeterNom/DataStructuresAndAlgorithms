using DataStructuresAndAlgorithms.Algorithms;
using DataStructuresAndAlgorithms.DataStructures;

Console.WriteLine("Hello, World!");
int[] ints   = { 12, 11, 13, 5, 6, 7 };
int[] subMax = { 13,-3,-25,20, -3, -16, -23, 18, 20, -7, 12, -5,-22,15,-4,7 };

SortingAlgorithms mySort = new SortingAlgorithms(ints);
MinMaxAlgorithms myMax = new MinMaxAlgorithms(subMax);
Graph graph = new Graph(4);
Heap myHeap = new Heap();
BinaryTree binaryTree = new BinaryTree();

// Insertion Sort
int[] ints1 = mySort.InsertionSortV2();

foreach (int i in ints1)
    Console.WriteLine(i);

// Bubble Sort
int[] ints2 = mySort.BubbleSort();

foreach (int i in ints2)
    Console.WriteLine(i);

// Merge Sort
mySort.Mergesort(0, mySort.GetArray().Length-1);

foreach (int i in mySort.GetArray())
    Console.WriteLine(i);

// Maximum Sub Array
Console.WriteLine(myMax.FindMaximumSubarray(0, myMax.GetArray().Length-1));

//BFS
graph.GraphInitialize(graph);

Console.WriteLine("DSF");
graph.DFS(2);
Console.WriteLine();
Console.WriteLine("BSF");
graph.BFS(2);
Console.WriteLine();

for (int i = 0;i < 10; i++)
{
    myHeap.push(i);
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(myHeap.pop());
}

Console.WriteLine("Tree");

//Tree
binaryTree.AddNode(1);
binaryTree.AddNode(2);
binaryTree.AddNode(7);
binaryTree.AddNode(3);
binaryTree.AddNode(10);
binaryTree.AddNode(5);
binaryTree.AddNode(8);

binaryTree.Remove(7);

Console.WriteLine("PreOrder Traversal:");
binaryTree.TraversePreOrder(binaryTree.Root);
Console.WriteLine();

Console.WriteLine("InOrder Traversal:");
binaryTree.TraverseInOrder(binaryTree.Root);
Console.WriteLine();

Console.WriteLine("PostOrder Traversal:");
binaryTree.TraversePostOrder(binaryTree.Root);
Console.WriteLine();