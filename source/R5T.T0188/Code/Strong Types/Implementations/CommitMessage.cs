using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0188
{
    /// <inheritdoc cref="ICommitMessage"/>
    [StrongTypeImplementationMarker]
    public class CommitMessage : TypedBase<string>, IStrongTypeMarker,
        ICommitMessage
    {
        public CommitMessage(string value)
            : base(value)
        {
        }
    }
}
