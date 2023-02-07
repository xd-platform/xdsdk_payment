using System.Collections.Generic;
using XD.SDK.Common.Internal;

namespace XD.SDK.Payment.Internal
{
    public interface XDGRefundResultWrapper
    {
        XDGError xdgError { get; }
        List<XDGRefundDetails> refundList { get; }
    }
}