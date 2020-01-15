using System;
using Csla;

namespace PerformanceTest_CSLA4
{
    [Serializable]
    public class PerformanceTestEntityCollection : BusinessListBase<PerformanceTestEntityCollection, PerformanceTestEntity>
    {
        private void DataPortal_Fetch()
        {
            var repository = new Repository();

            foreach (var dto in repository.GetAll())
            {
                Add(DataPortal.FetchChild<PerformanceTestEntity>(dto));
            }
        }

    }
}