using System;


namespace R5T.F0029
{
	public class ConfigurationOperator : IConfigurationOperator
	{
		#region Infrastructure

	    public static IConfigurationOperator Instance { get; } = new ConfigurationOperator();

	    private ConfigurationOperator()
	    {
        }

	    #endregion
	}
}