using System;


namespace R5T.T0188.Extensions
{
    public static class StringExtensions
    {
        public static ICommitMessage ToCommitMessage(this string value)
        {
            return Instances.StringOperator_Extensions.ToCommitMessage(value);
        }
    }
}
