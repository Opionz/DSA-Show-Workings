using Business;
using System.Collections.Generic;

//Dictionary<int, string> numberNames = new Dictionary<int, string>();

//// adding key and corresponding values 

//numberNames.Add(1, "One");
//numberNames.Add(2, "Two");
//numberNames.Add(3, "Three");

////The following throws run-time exception: key already added.
////numberNames.Add(3, "Three"); 

//foreach (KeyValuePair<int, string> kvp in numberNames)
//    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

//creating a dictionary using collection-initializer syntax
var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};


foreach (var kvp in cities)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


//Accessing Dictionary Elements

Console.WriteLine(cities["UK"]); //prints value of UK key
Console.WriteLine(cities["USA"]);//prints value of USA key
// Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

//use ContainsKey() to check for an unknown key
if (cities.ContainsKey("France"))
{
	Console.WriteLine(cities["France"]);
}

//use TryGetValue() to get a value of unknown key
string result = "City doesnt exist";

if (cities.TryGetValue("France", out result))
{
	Console.WriteLine(result);
}

//use ElementAt() to retrieve key-value pair using index
for (int i = 0; i < cities.Count; i++)
{
	Console.WriteLine("Key: {0}, Value: {1}",
											cities.ElementAt(i).Key,
											cities.ElementAt(i).Value);
}


cities["UK"] = "Liverpool, Bristol"; // update value of UK key
cities["USA"] = "Los Angeles, Boston"; // update value of USA key
// cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

if (cities.ContainsKey("France"))
{
	cities["France"] = "Paris";
}

Console.WriteLine("/// Output entire dictionary after updates");
for (int i = 0; i < cities.Count; i++)
{
	Console.WriteLine("Key: {0}, Value: {1}",
											cities.ElementAt(i).Key,
											cities.ElementAt(i).Value);
}

cities.Remove("UK"); // removes UK 
					 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

Console.WriteLine("/// Output entire dictionary after removing UK");
for (int i = 0; i < cities.Count; i++)
{
	Console.WriteLine("Key: {0}, Value: {1}",
											cities.ElementAt(i).Key,
											cities.ElementAt(i).Value);
}

if (cities.ContainsKey("France"))
{ // check key before removing it
	cities.Remove("France");
}

cities.Clear(); //removes all elements




Console.Read();










































//Console.WriteLine("Kindly put in the COM number below!");
//string port = Console.ReadLine();
//SerialPortParser GetParse = new SerialPortParser();
//var ParsePort = GetParse.ParsePort(port);
//Console.WriteLine(ParsePort);
//Console.ReadLine();

