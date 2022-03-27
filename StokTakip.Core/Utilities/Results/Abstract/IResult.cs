using StokTakip.Core.Utilities.Results.ComplexType;

namespace StokTakip.Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        ResultStatus ResultStatus { get; }
        string Message { get; }
        Exception Exception { get; }
    }
}
