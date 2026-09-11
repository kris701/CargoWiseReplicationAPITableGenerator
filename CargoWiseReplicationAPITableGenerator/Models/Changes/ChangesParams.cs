using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CargoWiseReplicationAPITableGenerator.Models.Changes
{
	public class ChangesParams
	{
		[JsonPropertyName("table_name")]
		public string TableName { get; set; }
	}
}
