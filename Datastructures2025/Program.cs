// See https://aka.ms/new-console-template for more information
using Datastructures2025;

Console.WriteLine("Hello, World!");

//int[] myArray = new int[5];
//myArray[0] = 12;
////myArray[1] = 3; 
//myArray[2] = 5;
//myArray[3] = 99;
//myArray[4] = 77;

//int i1 = 12;
//int i2 = 3;
//int i3 = 4; 

//Console.WriteLine($"Det der er på index 3 {myArray[3]}");

//myArray[4] = myArray[3] + 25;

//Console.WriteLine($"Det der er på index 4 {myArray[4]}");

//for(int i = 0; i<5; i++)
//{
//    Console.WriteLine($"Indeks {i}  indeholder {myArray[i]} ");
//}
//Console.WriteLine("Foreach");
//foreach(int element in myArray)
//{
//    Console.WriteLine(element);
//}

//string[] names = new string[20];
//for(int i = 0; i<names.Length; i++)
//{
//    names[i] = "Default name";
//}
//names[0] = "Peter";
//names[1] = "Dorthe";

//Console.WriteLine(names[1][2]);

//myArray[5] = 12;
//Ulemper:
//Fix size
//Samme type i hele arrayet
//kan indeksere uden for


//List<int> myFirstList = new List<int>();
//List<int> myFirstList = [34, -233, 9801, 67, 2, -9582, 770];

////myFirstList.Add(982);

//myFirstList.Insert(1, 230);
//myFirstList.Add(120);
//myFirstList.Remove(67);
//myFirstList.RemoveAt(3);
//myFirstList[4] = 100;

//foreach (int element in myFirstList)
//{
//    Console.WriteLine(element);
//}


//for (int index =0; index < myFirstList.Count; index++ )
//{
//    Console.WriteLine($"Indeks {index}  indeholder {myFirstList[index]} ");
//}

//Console.WriteLine("Listen skrevet ud bagfra");
//for(int index = myFirstList.Count-1; index >= 0 ; index= index -1 )
//{
//    Console.WriteLine($"Indeks {index}  indeholder {myFirstList[index]} ");
//}


//myFirstList.Sort();
//Console.WriteLine("After sort");

//for (int index = 0; index < myFirstList.Count; index++)
//{
//    Console.WriteLine($"Indeks {index}  indeholder {myFirstList[index]} ");
//}

////List<string> namesList;
////namesList =  new List<string>();
////namesList.Add("Peter");
///
//Pizza p1 = new Pizza(1, "Magheritha", "Tomat og ost", 135);
//Pizza p2 = new Pizza(2, "Vesuvio", "Tomat, ost, skinke", 120);
//List<Pizza> pizzas;
//pizzas = new List<Pizza>();
//pizzas.Add(p1);
//pizzas.Add(p2);

//pizzas.Add(new Pizza(3, "Hawaii", "Tomas, os, Ananas og skinke", 159));

//foreach(Pizza pizzaElement in pizzas )
//{
//    Console.WriteLine($"Number {pizzaElement.Number} name {pizzaElement.Name}");
//}
//double  sum = 0; 
//foreach(Pizza p in pizzas)
//{
//    sum = sum + p.Price;
//}
//Console.WriteLine($"Den total sum er { sum}");

////string searchDescription = "skinke";
//int antalPizzaerMedSkinke = 0;
//foreach(Pizza c in pizzas)
//{
//    if ( c.Description.Contains("skinke") )
//    {
//        antalPizzaerMedSkinke++;
//    }
//}
//Console.WriteLine($"Antal pizzaer med skinke {antalPizzaerMedSkinke}");


//BiCycleRepository bRepo = new BiCycleRepository();
//bRepo.Add(new BiCycle(12, "Centurion", "2323232355"));
//Console.WriteLine(bRepo.Count);
//BiCycle b1 = new BiCycle(10, "Trek", "5454545455");
//bRepo.Add(b1);
//Console.WriteLine(bRepo.Count);
//bRepo.Add(null);
//Console.WriteLine(bRepo.Count);


//Dictionary<string, BiCycle> _bikes = new Dictionary<string, BiCycle>();

//BiCycle b1 = new BiCycle(10, "Trek", "5454545455");


//_bikes.Add(b1.SNO, b1);
//_bikes.Add("123", new BiCycle(12, "Trek", "123"));
//if (!_bikes.ContainsKey("124"))
//    _bikes.Add("124", new BiCycle(12, "Amigo", "124"));

//_bikes["125"] = new BiCycle(5, "Superduper", "125");

//Console.WriteLine(_bikes.Count);

//foreach (var bikeKVP in _bikes)
//{
//    Console.WriteLine("Key:" + bikeKVP.Key);
//    Console.WriteLine("Value:" + bikeKVP.Value);
//}

//_bikes.Remove("127");
//foreach (BiCycle bike in _bikes.Values)
//{
//    Console.WriteLine(bike);
//}


//HashSet<string> ssnColl = new HashSet<string>();
//bool added = ssnColl.Add("02011987-1235");
//bool isPresent = ssnColl.Contains("02011987-1235");


//HashSet<string> names1 = ["Peter", "Annie", "Frank", "Linda", "Lukas"];
//HashSet<string> names2 = ["Lukas", "Maria", "Martin", "Sofie", "Linda"];

//names1.UnionWith((names2)); 
//foreach(string name in names1)
//{
//    Console.WriteLine(name);
//}

//foreach (string ssn in ssnColl)
//{
//    Console.WriteLine(ssn);
//}

//FruitType typeOfFruit = FruitType.Banana;
//Console.WriteLine(typeOfFruit);

//Pizza p1 = new Pizza(1, "Magheritha", "Tomat og ost", 135, PizzaType.Family);
//Console.WriteLine(p1);


//BiCycleRepository bRepo = new BiCycleRepository();
//bRepo.Add(new BiCycle(12, "Centurion", "23"));
////Console.WriteLine(bRepo.Count);
//BiCycle b1 = new BiCycle(10, "Trek", "54");
//bRepo.Add(b1);
//bRepo.Remove("23");
//Console.WriteLine(bRepo.Count);
//bRepo.Add(null);
//Console.WriteLine(bRepo.Count);


IBiCycleRepository bRepo = new BiCycleRepoDictionary();
bRepo.Add(new BiCycle(12, "Centurion", "23"));
//Console.WriteLine(bRepo.Count);
BiCycle b1 = new BiCycle(10, "Trek", "54");
bRepo.Add(b1);
bRepo.Remove("23");
bRepo.Update(new BiCycle(12, "Trek", "54"));
Console.WriteLine(bRepo.Count);