using System;
using Csla;

namespace PerformanceTest_CSLA5
{
    [Serializable]
    public class PerformanceTestEntityCollection : BusinessListBase<PerformanceTestEntityCollection, PerformanceTestEntity>
    {
        [Fetch]
        private void Fetch()
        {
            var repository = new Repository();

            foreach (var dto in repository.GetAll())
            {
                Add(DataPortal.FetchChild<PerformanceTestEntity>(dto));
            }
        }

    }
}