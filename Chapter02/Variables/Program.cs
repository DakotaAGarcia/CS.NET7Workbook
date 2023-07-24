using System.Xml;
{

}

object height = 1.88; //storing a double in an object
object name = "Amir"; //storing a string in an object

Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length; //gives complire error

int length2 = ((string)name).Length; //tell comppiler it is a string

Console.WriteLine($"{name} has {length2} charachters");

//storing a string in a dynamic object
//string has a length property
dynamic something = "Ahmed";

//int does not have a length property
//something = 12;
// an array of any type has a length property
something = new[] { 3, 5, 7 };

//this compiles but would throw an exception at run time.
//if you later stored a data type that does not have a 
//property name length

Console.WriteLine($"Length is {something.Length}");

var population = 67_000_000; // 67 million in the uk
var weight = 1.88; // in kilos
var price = 4.99M;  //in pounds sterling
var fruit = "apples";    //strings use double quotes
var letter = 'Z';  //chars use single quotes
var happy = true;  //boolens have value of true or false


//good use of var because it avoids the repeated type
//as shown in the more verbose second statement
var xml1 = new XmlDocument(); // C# 3 and later
XmlDocument xml2 = new XmlDocument(); //all C# versions

//bad use of var because we cannot tell the type so we should use a
//specific type declaration as shown in the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.text");

Console.WriteLine($"default(int)    =   {default(int)}");
Console.WriteLine($"default(bool)    =   {default(bool)}");
Console.WriteLine($"default(DateTime)    =   {default(DateTime)}");
Console.WriteLine($"default(string)    =   {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to : {number}");
number = default;
Console.WriteLine($"number has been rest to its default: {number}");
