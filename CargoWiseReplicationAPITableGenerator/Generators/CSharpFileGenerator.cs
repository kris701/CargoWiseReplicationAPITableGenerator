using CargoWiseReplicationAPITableGenerator.Models.Changes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoWiseReplicationAPITableGenerator.Generators
{
	public class CSharpFileGenerator : IFileGenerator
	{
		public string NameSpace { get; set; } = "YourNamespace";

		public string Generate(List<ChangesDataItemsColumns> columns, string tableName)
		{
			var sb = new StringBuilder();

			sb.AppendLine($"namespace {NameSpace}");
			sb.AppendLine($"{{");
			sb.AppendLine($"\tpublic class {tableName}");
			sb.AppendLine($"\t{{");
			foreach(var column in columns)
				sb.AppendLine($"\t\tpublic {APITypeToCSharpType(column.Type)} {column.Name} {{ get; set; }}");
			sb.AppendLine($"\t}}");
			sb.AppendLine($"}}");

			return sb.ToString();
		}

		private string APITypeToCSharpType(string type)
		{
			switch (type.ToLower())
			{
				case "uniqueidentifier": 
					return "Guid";
				case "nvarchar": 
				case "varchar":
				case "char":
					return "string";
				case "datetime":
				case "datetime2":
				case "smalldatetime":
					return "DateTime";
				case "datetimeoffset":
					return "DateTimeOffset";
				case "money":
				case "decimal":
					return "double";
				case "int":
				case "smallint":
				case "tinyint":
					return "int";
				case "bit":
					return "bool";
				case "varbinary":
					return "byte[]";
				default: return "string";
			}
		}
	}
}
