using CargoWiseReplicationAPITableGenerator.Models.Changes;

namespace CargoWiseReplicationAPITableGenerator.Generators
{
	public interface IFileGenerator
	{
		public string Generate(List<ChangesDataItemsColumns> columns, string tableName);
	}
}
