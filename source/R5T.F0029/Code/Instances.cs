using System;


namespace R5T.F0029
{
    public static class Instances
    {
        public static IConfigurationBuilderOperator ConfigurationBuilderOperator { get; } = F0029.ConfigurationBuilderOperator.Instance;
        public static IConfigurationOperator ConfigurationOperator { get; } = F0029.ConfigurationOperator.Instance;
    }
}