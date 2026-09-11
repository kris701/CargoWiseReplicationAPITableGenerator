using System.Text.Json.Serialization;

namespace CargoWiseReplicationAPITableGenerator.Models.Changes
{
	public class ChangesData
	{
		[JsonPropertyName("items")]
		public List<ChangesDataItems> Items { get; set; }
	}
}
