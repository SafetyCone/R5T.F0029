using System;


namespace R5T.F0029
{
	public class ConfigurationBuilderOperator : IConfigurationBuilderOperator
	{
		#region Infrastructure

	    public static ConfigurationBuilderOperator Instance { get; } = new();

	    private ConfigurationBuilderOperator()
	    {
        }

	    #endregion
	}
}