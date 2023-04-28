using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0188
{
    /// <summary>
    /// Strongly-types a string as a source-control commit message.
    /// </summary>
    [StrongTypeMarker]
    public interface ICommitMessage : IStrongTypeMarker,
        IMessage
    {
    }
}
