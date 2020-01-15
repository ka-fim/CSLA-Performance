using System.Collections.Generic;

namespace PerformanceTest_CSLA4
{
    public class Repository
    {
        public const int ItemsCount = 100000;

        public IEnumerable<PerformanceTestDto> GetAll()
        {
            var result = new List<PerformanceTestDto>();

            for (var i = 1; i <= ItemsCount; ++i)
            {
                result.Add(new PerformanceTestDto()
                {
                    Identifier = i,
                    Name = $"Test_{i}"
                });
            }

            return result;
        }
    }
}