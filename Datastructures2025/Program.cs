// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] myArray = new int[5];
myArray[0] = 12;
//myArray[1] = 3; 
myArray[2] = 5;
myArray[3] = 99;
myArray[4] = 77;

int i1 = 12;
int i2 = 3;
int i3 = 4; 

Console.WriteLine($"Det der er på index 3 {myArray[3]}");

myArray[4] = myArray[3] + 25;

Console.WriteLine($"Det der er på index 4 {myArray[4]}");

for(int i = 0; i<5; i++)
{
    Console.WriteLine($"Indeks {i}  indeholder {myArray[i]} ");
}
Console.WriteLine("Foreach");
foreach(int element in myArray)
{
    Console.WriteLine(element);
}

string[] names = new string[20];
for(int i = 0; i<names.Length; i++)
{
    names[i] = "Default name";
}
names[0] = "Peter";
names[1] = "Dorthe";

Console.WriteLine(names[1][2]);

//myArray[5] = 12;
//Ulemper:
//Fix size
//Samme type i hele arrayet
//kan indeksere uden for


//List<int> myFirstList = new List<int>();
List<int> myFirstList = [34, -233, 9801, 67, 2, -9582, 770];

//myFirstList.Add(982);

myFirstList.Insert(1, 230);
myFirstList.Add(120);

myFirstList[4] = 100;
//foreach(int element in myFirstList)
//{
//    Console.WriteLine(element);
//}


for(int index =0; index < myFirstList.Count; index++ )
{
    Console.WriteLine($"Indeks {index}  indeholder {myFirstList[index]} ");
}

myFirstList.Sort();
Console.WriteLine("After sort");

for (int index = 0; index < myFirstList.Count; index++)
{
    Console.WriteLine($"Indeks {index}  indeholder {myFirstList[index]} ");
}

//List<string> namesList;
//namesList =  new List<string>();
//namesList.Add("Peter");