using CargoWiseReplicationAPITableGenerator.Models.Changes;
using System.Text.Json;

namespace CargoWiseReplicationAPITableGenerator.Helpers
{
	public static class ProgramHelpers
	{
		public static ChangesResponse Parse(string fileText)
		{
			var result = JsonSerializer.Deserialize<ChangesResponse>(fileText);
			if (result == null)
				throw new Exception("Could not parse replication api file!");
			return result;
		}
	}
}
