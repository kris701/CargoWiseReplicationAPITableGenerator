using CommandLine;

namespace CargoWiseReplicationAPITableGenerator.Models.Options
{
	[Verb("csharp", HelpText = "Use the C# generator")]
	public class CSharpFileGeneratorOptions : BaseOptions
	{
		[Option('n', "namespace", Required = false, HelpText = "Namespace to put in the file")]
		public string NameSpace { get; set; } = "YourNamespace";
	}
}
