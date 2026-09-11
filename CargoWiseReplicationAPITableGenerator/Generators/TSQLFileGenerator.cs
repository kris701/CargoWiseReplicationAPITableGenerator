using CargoWiseReplicationAPITableGenerator.Models.Changes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CargoWiseReplicationAPITableGenerator.Generators
{
	public class TSQLFileGenerator : IFileGenerator
	{
		public string Schema { get; set; } = "dbo";

		public string Generate(List<ChangesDataItemsColumns> columns, string tableName)
		{
			var sb = new StringBuilder();

			sb.AppendLine($"CREATE TABLE [{Schema}].[{tableName}] (");
			var index = 0;
			foreach (var column in columns)
				sb.AppendLine($"\t[{column.Name}] \t {APITypeToSQLType(column.Type)} NULL{(index++ < columns.Count - 1 ? "," : "")}");
			sb.AppendLine($");");

			return sb.ToString();
		}

		private string APITypeToSQLType(string type)
		{
			switch (type.ToLower())
			{
				case "uniqueidentifier":
					return "UNIQUEIDENTIFIER";
				case "nvarchar":
				case "varchar":
				case "char":
					return "NVARCHAR(MAX)";
				case "datetime":
				case "datetime2":
				case "smalldatetime":
					return "DATETIME";
				case "datetimeoffset":
					return "DATETIMEOFFSET";
				case "money":
				case "decimal":
					return "DECIMAL(19,4)";
				case "int":
				case "smallint":
				case "tinyint":
					return "INT";
				case "bit":
					return "BIT";
				case "varbinary":
					return "VARBINARY(MAX)";
				default: return "NVARCHAR(MAX)";
			}
		}
	}
}
