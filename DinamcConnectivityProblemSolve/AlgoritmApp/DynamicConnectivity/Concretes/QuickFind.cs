using DynamicConnectivityProblem.DynamicConnectivity.Abtracts;

namespace DynamicConnectivityProblem.DynamicConnectivity.Concretes
{
    public class QuickFind : DynamicConnectivityBase, IDynamicConnectivity
    {
        public QuickFind(int arraySize) : base(arraySize) { }
        public bool Connected(int firstIndex, int secondIndex) => Array[firstIndex] == Array[secondIndex];

        public void Union(int firstIndex, int secondIndex)
        {
            if (!Connected(firstIndex, secondIndex))
            {
                int firstElement = Array[firstIndex],
                    secondElement = Array[secondIndex];

                for (int i = 0; i < Array.Length; i++)
                    if (Array[i] == firstElement)
                        Array[i] = secondElement;
            }
        }

    }
}
