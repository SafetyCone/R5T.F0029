using System;


namespace R5T.F0029
{
	public class ConfigurationOperator : IConfigurationOperator
	{
		#region Infrastructure

	    public static ConfigurationOperator Instance { get; } = new();

	    private ConfigurationOperator()
	    {
        }

	    #endregion
	}
}