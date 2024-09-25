using DynamicConnectivityProblem.DynamicConnectivity.Abtracts;
using DynamicConnectivityProblem.DynamicConnectivity.Concretes;


IDynamicConnectivity dynamicConnectivitySolution = new QuickUnion(50);
dynamicConnectivitySolution.Union(1, 4);
dynamicConnectivitySolution.Union(12, 4);
dynamicConnectivitySolution.Union(6, 23);
dynamicConnectivitySolution.Union(43, 13);
dynamicConnectivitySolution.Union(12, 15);
dynamicConnectivitySolution.Union(16, 36);
dynamicConnectivitySolution.Union(44, 33);
dynamicConnectivitySolution.Union(33, 4);
dynamicConnectivitySolution.Union(4, 19);
dynamicConnectivitySolution.Union(27, 39);
dynamicConnectivitySolution.Union(39, 13);
dynamicConnectivitySolution.Union(11, 49);
dynamicConnectivitySolution.Union(12, 43);
dynamicConnectivitySolution.Union(13, 42);
dynamicConnectivitySolution.Union(21, 46);
dynamicConnectivitySolution.Union(39, 2);

Console.WriteLine("*****************************");
Console.WriteLine("connected(1,4) :" + dynamicConnectivitySolution.Connected(1, 4));
Console.WriteLine("connected(5,6) :" + dynamicConnectivitySolution.Connected(5, 6));
Console.WriteLine("connected(3,2) :" + dynamicConnectivitySolution.Connected(3, 2));
Console.WriteLine("connected(17,26) :" + dynamicConnectivitySolution.Connected(17, 26));
Console.WriteLine("connected(5,5) :" + dynamicConnectivitySolution.Connected(5, 5));
Console.WriteLine("connected(7,6) :" + dynamicConnectivitySolution.Connected(7, 6));
Console.WriteLine("connected(31,43) :" + dynamicConnectivitySolution.Connected(31, 43));
Console.WriteLine("connected(33,2) :" + dynamicConnectivitySolution.Connected(33, 2));
Console.WriteLine("connected(2,44) :" + dynamicConnectivitySolution.Connected(2, 44));
Console.WriteLine("connected(43,2) :" + dynamicConnectivitySolution.Connected(43, 2));