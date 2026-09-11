using System.Text.Json.Serialization;

namespace CargoWiseReplicationAPITableGenerator.Models.Changes
{
	public class ChangesResponse
	{
		[JsonPropertyName("data")]
		public ChangesData Data { get; set; }
		[JsonPropertyName("params")]
		public ChangesParams Params { get; set; }
	}
}
