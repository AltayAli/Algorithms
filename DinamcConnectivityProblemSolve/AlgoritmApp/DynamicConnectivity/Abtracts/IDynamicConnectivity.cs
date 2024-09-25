using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicConnectivityProblem.DynamicConnectivity.Abtracts
{
    public interface IDynamicConnectivity
    {
        bool Connected(int firstIndex, int secondIndex);
        void Union(int firstIndex, int secondIndex);
    }
}
