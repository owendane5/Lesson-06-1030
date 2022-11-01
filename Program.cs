using System.Collections; //array list, and other non-generic data structures 
namespace lesson06;
class Program
{
    static int[] Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    //Arrays > fixed, specific data type    
    // list of int with 10 elements
  int[] myIntArr = new int[10];
    //Access by index 0 to n-1
myIntArr[9] = 100; // add 100 to t he last box in my array
    

    int[] myTwoBoxArray = new int[2];

    myTwoBoxArray[0] = 50;
    myTwoBoxArray[1] = 100;

    return myTwoBoxArray;  // for hacker rank

object[] myObjArr = new Object[10];  // everything in c# is descendent of object\
myObjArr[0] = "this is element in position 0";
myObjArr[1] = true;
myObjArr[2] = 100.86F;


//arraylist > dynamic  (increase/decrease size), doesnt require a data type
    ArrayList myArrList = new ArrayList();  // behind scene its an object array
 // lists offer helper methods 
 myArrList.Add(100);
 myArrList.Add("text");
 myArrList.Add(true);

 var count = myArrList.Count; // property that returns how many elemtns there are 

 myArrList.Remove("text");
 myArrList.RemoveAt(1);


    }
}
