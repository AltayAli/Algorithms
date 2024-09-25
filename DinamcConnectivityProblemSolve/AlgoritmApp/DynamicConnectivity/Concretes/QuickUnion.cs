using DynamicConnectivityProblem.DynamicConnectivity.Abtracts;

namespace DynamicConnectivityProblem.DynamicConnectivity.Concretes
{
    public class QuickUnion : DynamicConnectivityBase, IDynamicConnectivity
    {
        public QuickUnion(int arraySize) : base(arraySize) { }

        public bool Connected(int firstIndex, int secondIndex)
           =>Root(firstIndex) == Root (secondIndex);

        public void Union(int firstIndex, int secondIndex)
        {
            int i = Root(firstIndex);
            int j = Root(secondIndex);
            Array[i] = j;
        }

        private int Root(int index)
        {
            while(index != Array[index])  index = Array[index];

            return index;
        }
    }
}
