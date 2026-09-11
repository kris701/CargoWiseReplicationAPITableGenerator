using System.Text.Json.Serialization;

namespace CargoWiseReplicationAPIInterface.Models.Changes
{
	public class ChangesResponse
	{
		[JsonPropertyName("apiVersion")]
		public string APIVersion { get; set; }
		[JsonPropertyName("data")]
		public ChangesData Data { get; set; }
	}
}
