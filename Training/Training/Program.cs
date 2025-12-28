//Console.WriteLine("enter: ");

//var input = Console.ReadLine();

//try
//{
//    var items = input.Split("->").Select(x => int.Parse(x)).ToList();

//    LinkedList<int> list = new LinkedList<int>(items);

//    bool first = true;

//    var count = list.Count;
//    int[] res = new int[count];


//    foreach (var i in list)
//    {
//        res[--count] = i;

//    }

//    count = 0;

//    foreach (var i in list)
//    {
//        if (res[count++] != i)
//        {
//            Console.WriteLine("false");
//            return;
//        }


//    }

//    Console.WriteLine("true");


//}
//catch (Exception)
//{

//    Console.WriteLine("Error");
//}


//question2 


//[3,9,20,null,null,15,7]
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Text.Json;
using System.Xml.Linq;

Console.WriteLine("enter: ");



var input = Console.ReadLine();

var list = JsonSerializer.Deserialize<List<int?>>(input);

int curr = 0;
int total = 0;

List<List<int>> res = new List<List<int>>();
while (list.Count >= Math.Pow(2, curr))
{

    res.Add(new List<int>());
    for (int i = total; i <= total + Math.Pow(2, curr) && res.Count >= i; i++)
    {

        res[curr].Add(list[i] ?? 0);
    }


    total += (int)Math.Pow(2, curr);
    curr++;

}

Console.WriteLine(res);



//Determine whether a linked list is a palindromic linked list. 

//Example 1: 
//Enter: 1->2 
//Output: false 
//Example 2: 

//Enter: 1->2->2->1 
//Output: true 
//Upgrade: 
//Can you solve this problem with O(n) time complexity and O(1) space complexity?



//----
//Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. Answers within 10-5 of the actual answer will be accepted.


//Example 1:
//	   3
//   /  \
//  9    20
// 	    / \    
//     15  7

//Input: root = [3,9,20,null,null,15,7]
//Output: [3.00000,14.50000,11.00000]
//Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
//Hence return [3, 14.5, 11].


//Example 2:
//	   3
//   /  \
//  9    20
// / \    
//15  7
//Input: root = [3,9,20,15,7]
//Output: [3.00000,14.50000,11.00000]

//Constraints:
//The number of nodes in the tree is in the range [1, 104].
//-231 <= Node.val <= 231 - 1