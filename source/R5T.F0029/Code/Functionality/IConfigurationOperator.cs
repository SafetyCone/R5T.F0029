using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using R5T.T0132;


namespace R5T.F0029
{
	[FunctionalityMarker]
	public partial interface IConfigurationOperator : IFunctionalityMarker
	{
		public IConfiguration BuildConfiguration_Synchronous(
			Action<IConfigurationBuilder> configurationBuilderAction)
        {
			var configurationBuilder = this.GetEmptyConfigurationBuilder();

			configurationBuilderAction(configurationBuilder);

			var configuration = configurationBuilder.Build();
			return configuration;
        }

		public async Task<IConfiguration> BuildConfiguration(
			Func<IConfigurationBuilder, Task> configurationBuilderAction)
		{
			var configurationBuilder = this.GetEmptyConfigurationBuilder();

			await configurationBuilderAction(configurationBuilder);

			var configuration = configurationBuilder.Build();
			return configuration;
		}

		/// <summary>
		/// Gets a section with the given name, and converts it to an instance of <typeparamref name="T"/>.
		/// </summary>
		public T Get<T>(
			IConfiguration configuration,
			string sectionName)
        {
			var output = configuration.GetSection(sectionName).Get<T>();
			return output;
        }

		/// <summary>
		/// Gets a section with the same name as the type name of <typeparamref name="T"/>, and converts it to an instance of <typeparamref name="T"/>.
		/// </summary>
		public T Get<T>(IConfiguration configuration)
		{
			var sectionName = Instances.TypeOperator.Get_NameOf<T>();

			var output = this.Get<T>(
				configuration,
				sectionName);

			return output;
		}

		public ConfigurationBuilder GetEmptyConfigurationBuilder()
        {
			var output = new ConfigurationBuilder();
			return output;
        }
	}
}