/*
 * Sam's house has an apple tree and an orange tree that yield an abundance of fruit. 
 * Using the information given below, determine the number of apples and oranges that land on Sam's house.
 * In the diagram below:
 * The red region denotes the house, where:
 * s is the start point, and 
 * t is the endpoint. 
 * 
 * The apple tree is to the left of the house, and the orange tree is to its right.
 * Assume the trees are located on a single point, where 
 * the apple tree is at a point , and 
 * the orange tree is at b point .
 * When a fruit falls from its tree, it lands d units of distance from its tree of origin along the x-axis. 
 * *A negative value of d means the fruit fell d units to the tree's left, and a positive value of d means it falls d units to the tree's right. *

countApplesAndOranges has the following parameter(s):

s: integer, starting point of Sam's house location.
t: integer, ending location of Sam's house location.
a: integer, location of the Apple tree.
b: integer, location of the Orange tree.
apples: integer array, distances at which each apple falls from the tree.
oranges: integer array, distances at which each orange falls from the tree.

*/
int s = 7;
int t = 10;
int a = 4;
int b = 12;
List<int> apples = new List<int> { 2, 3, -4 };
List<int> oranges = new List<int> { 3, -2, -4 };
countApplesAndOranges(s, t, a, b, apples, oranges);


static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
    Console.WriteLine($"{apples.Count(x => x + a >= s && x + a <= t)}\n{oranges.Count(x => x + b >= s && x + b <= t)}");
}