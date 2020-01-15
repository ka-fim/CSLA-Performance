using System;
using Csla;

namespace PerformanceTest_CSLA5
{
    [Serializable]
    public class PerformanceTestEntity : BusinessBase<PerformanceTestEntity>
    {
        public int Identifier { get; set; }

        public string Name { get; set; }

        public static PerformanceTestEntityCollection GetAll()
        {
            var dp = new DataPortal<PerformanceTestEntityCollection>();
            return dp.Fetch();
        }

        //[FetchChild]
        private void Child_Fetch(params object[] parameters)
        {
            var dto = (PerformanceTestDto) parameters[0];

            Identifier = dto.Identifier;
            Name = dto.Name;
        }
    }
}