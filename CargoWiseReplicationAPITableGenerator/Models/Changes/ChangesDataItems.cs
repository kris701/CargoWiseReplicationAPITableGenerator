using System.Text.Json.Serialization;

namespace CargoWiseReplicationAPITableGenerator.Models.Changes
{
	public class ChangesDataItems
	{
		[JsonPropertyName("columns")]
		public List<ChangesDataItemsColumns> Columns { get; set; }
	}
}
