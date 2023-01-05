using System.Collections.Generic;
using XD.SDK.Common.Internal;

namespace XD.SDK.Payment.Internal
{
    public interface IXDGRefundResultWrapper
    {
        IXDGError xdgError { get; }
        List<IXDGRefundDetails> refundList { get; }
    }
}