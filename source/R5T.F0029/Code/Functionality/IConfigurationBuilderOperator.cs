using System;

using Microsoft.Extensions.Configuration;

using R5T.T0132;


namespace R5T.F0029
{
	[FunctionalityMarker]
	public partial interface IConfigurationBuilderOperator : IFunctionalityMarker
	{
		public void AddJsonFile(
			IConfigurationBuilder configurationBuilder,
			string jsonFilePath)
        {
			configurationBuilder.AddJsonFile(jsonFilePath);
        }
	}
}