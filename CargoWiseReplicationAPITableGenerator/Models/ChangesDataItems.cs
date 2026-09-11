using System.Text.Json.Serialization;

namespace CargoWiseReplicationAPIInterface.Models.Changes
{
	public class ChangesDataItems
	{
		[JsonPropertyName("columns")]
		public List<ChangesDataItemsColumns> Columns { get; set; }
	}
}
