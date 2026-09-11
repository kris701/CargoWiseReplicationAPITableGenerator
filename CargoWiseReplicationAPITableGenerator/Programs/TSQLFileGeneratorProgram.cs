using CargoWiseReplicationAPITableGenerator.Generators;
using CargoWiseReplicationAPITableGenerator.Helpers;
using CargoWiseReplicationAPITableGenerator.Models.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoWiseReplicationAPITableGenerator.Programs
{
	public static class TSQLFileGeneratorProgram
	{
		public static async Task Run(TSQLFileGeneratorOptions opts)
		{
			if (!Path.Exists(opts.OutputPath))
				throw new Exception("Output path does not exist!");

			Console.WriteLine("Loading file...");
			var text = File.ReadAllText(opts.InputFile);

			Console.WriteLine("Parsing...");
			var parsed = ProgramHelpers.Parse(text);

			Console.WriteLine("Generating...");
			var generator = new TSQLFileGenerator()
			{
				Schema = opts.Schema
			};
			var generated = generator.Generate(parsed.Data.Items[0].Columns, parsed.Params.TableName);

			Console.WriteLine("Writing output...");
			var path = Path.Combine(opts.OutputPath, parsed.Params.TableName + ".sql");
			File.WriteAllText(path, generated);
		}
	}
}
