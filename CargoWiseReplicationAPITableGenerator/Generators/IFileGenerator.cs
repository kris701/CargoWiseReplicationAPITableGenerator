using CargoWiseReplicationAPITableGenerator.Models.Changes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoWiseReplicationAPITableGenerator.Generators
{
	public interface IFileGenerator
	{
		public string Generate(List<ChangesDataItemsColumns> columns, string tableName);
	}
}
