using System.Collections.Generic;
using System.Linq;
using Aurochses.Data.AutoMapper.Tests.Fakes;
using AutoMapper;
using Xunit;

namespace Aurochses.Data.AutoMapper.Tests
{
    public class DataMapperTests
    {
        [Fact]
        public void Inherit_IDataMapper()
        {
            // Arrange & Act
            var dataMapper = new DataMapper();

            // Assert
            Assert.IsAssignableFrom<IDataMapper>(dataMapper);
        }

        [Fact]
        public void Map_Success()
        {
            // Arrange
            var source = new List<FakeSource>
            {
                new FakeSource {Id = 1, SourceName = "FirstSourceName"},
                new FakeSource {Id = 2, SourceName = "SecondSourceName"},
                new FakeSource {Id = 3, SourceName = "ThirdSourceName"}
            };

            Mapper.Initialize(cfg => cfg.CreateMap<FakeSource, FakeDestination>());

            var dataMapper = new DataMapper();

            var expected = new List<FakeDestination>
            {
                new FakeDestination {Id = 1},
                new FakeDestination {Id = 2},
                new FakeDestination {Id = 3}
            };

            // Act
            var result = dataMapper.Map<FakeDestination>(source.AsQueryable()).ToList();

            // Assert
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].Id, result[i].Id);
                Assert.Equal(expected[i].DestinationName, result[i].DestinationName);
            }
        }
    }
}