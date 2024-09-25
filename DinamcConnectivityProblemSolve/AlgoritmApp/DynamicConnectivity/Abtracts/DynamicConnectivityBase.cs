namespace DynamicConnectivityProblem.DynamicConnectivity.Abtracts
{
    public abstract class DynamicConnectivityBase
    {
        protected int[] Array { get; private set; }
        public DynamicConnectivityBase(int arraySize)
        {
            Array = new int[arraySize];
            Reset();

        }

        private void Reset()
        {
            for (int i = 0; i < Array.Length; i++)
                Array[i] = i;
        }
    }
}
