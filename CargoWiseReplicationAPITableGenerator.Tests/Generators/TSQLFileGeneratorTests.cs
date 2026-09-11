using CargoWiseReplicationAPITableGenerator.Generators;
using CargoWiseReplicationAPITableGenerator.Models.Changes;
using System.Text.Json;

namespace CargoWiseReplicationAPITableGenerator.Tests.Generators
{
	[TestClass]
	public class TSQLFileGeneratorTests
	{
		[TestMethod]
		[DataRow("TestFiles/JobShipment1.json", "TestFiles/JobShipment1.sql", "JobShipment")]
		[DataRow("TestFiles/GlbStaff1.json", "TestFiles/GlbStaff1.sql", "GlbStaff")]
		[DataRow("TestFiles/JobHeader1.json", "TestFiles/JobHeader1.sql", "JobHeader")]
		public void Can_Generate(string inputFile, string expectedFile, string tableName)
		{
			// ARRANGE
			var generator = new TSQLFileGenerator();
			var parsed = JsonSerializer.Deserialize<ChangesResponse>(File.ReadAllText(inputFile));
			Assert.IsNotNull(parsed);
			var expectedText = File.ReadAllText(expectedFile);

			// ACT
			var text = generator.Generate(parsed.Data.Items[0].Columns, tableName);

			// ASSERT
			Assert.AreEqual(expectedText, text);
		}
	}
}
