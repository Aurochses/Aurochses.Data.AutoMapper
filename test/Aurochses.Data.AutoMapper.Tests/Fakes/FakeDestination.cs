using System.Diagnostics.CodeAnalysis;

namespace Aurochses.Data.AutoMapper.Tests.Fakes
{
    [ExcludeFromCodeCoverage]
    public class FakeDestination
    {
        public int Id { get; set; }
        public string DestinationName { get; set; }
    }
}