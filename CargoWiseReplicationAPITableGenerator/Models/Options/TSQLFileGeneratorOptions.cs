using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoWiseReplicationAPITableGenerator.Models.Options
{
	[Verb("tsql", HelpText = "Use the TSQL generator")]
	public class TSQLFileGeneratorOptions : BaseOptions
	{
		[Option('s', "schema", Required = false, HelpText = "Schema to make the table in")]
		public string Schema { get; set; } = "dbo";
	}
}
