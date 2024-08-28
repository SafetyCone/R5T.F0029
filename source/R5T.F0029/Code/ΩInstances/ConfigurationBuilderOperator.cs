using System;


namespace R5T.F0029
{
	public class ConfigurationBuilderOperator : IConfigurationBuilderOperator
	{
		#region Infrastructure

	    public static IConfigurationBuilderOperator Instance { get; } = new ConfigurationBuilderOperator();

	    private ConfigurationBuilderOperator()
	    {
        }

	    #endregion
	}
}