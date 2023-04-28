using System;

using R5T.T0132;


namespace R5T.T0188.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ICommitMessage ToCommitMessage(string value)
        {
            var output = new CommitMessage(value);
            return output;
        }
    }
}
