using StokTakip.Core.Utilities.Results.ComplexType;

namespace StokTakip.Core.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}
