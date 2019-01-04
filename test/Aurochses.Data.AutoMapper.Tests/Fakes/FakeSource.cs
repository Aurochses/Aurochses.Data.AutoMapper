using System.Diagnostics.CodeAnalysis;

namespace Aurochses.Data.AutoMapper.Tests.Fakes
{
    [ExcludeFromCodeCoverage]
    public class FakeSource
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
    }
}