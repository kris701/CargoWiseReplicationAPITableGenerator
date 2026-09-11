using CommandLine;

namespace CargoWiseReplicationAPITableGenerator.Models
{
	public abstract class BaseOptions
	{
		[Option('i', "input", Required = true, HelpText = "JSON response file from a CargoWise Replication API.")]
		public string InputFile { get; set; }

		[Option('o', "output", Required = true, HelpText = "Path to where to put the result")]
		public string OutputPath { get; set; }
	}
}
