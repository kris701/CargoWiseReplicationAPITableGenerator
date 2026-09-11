using CargoWiseReplicationAPITableGenerator.Models.Options;
using CargoWiseReplicationAPITableGenerator.Programs;
using CommandLine;
using CommandLine.Text;

namespace CargoWiseReportTemplateCreator
{
	internal class Program
	{
		public static async Task Main(string[] args)
		{
			var parser = new Parser(with => with.HelpWriter = null);
			var parserResult = parser.ParseArguments<CSharpFileGeneratorOptions, TSQLFileGeneratorOptions>(args);
			parserResult.WithNotParsed(errs => DisplayHelp(parserResult, errs));
			await parserResult.WithParsedAsync<CSharpFileGeneratorOptions>(CSharpFileGeneratorProgram.Run);
			await parserResult.WithParsedAsync<TSQLFileGeneratorOptions>(TSQLFileGeneratorProgram.Run);
		}

		private static void HandleParseError(IEnumerable<CommandLine.Error> errs)
		{
			var sentenceBuilder = SentenceBuilder.Create();
			foreach (var error in errs)
				if (error is not HelpRequestedError)
					Console.WriteLine(sentenceBuilder.FormatError(error));
		}

		private static void DisplayHelp<T>(ParserResult<T> result, IEnumerable<CommandLine.Error> errs)
		{
			var helpText = HelpText.AutoBuild(result, h =>
			{
				h.AddEnumValuesToHelpText = true;
				return h;
			}, e => e, verbsIndex: true);
			Console.WriteLine(helpText);
			HandleParseError(errs);
		}
	}
}