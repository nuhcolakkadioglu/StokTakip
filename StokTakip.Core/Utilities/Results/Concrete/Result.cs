﻿using StokTakip.Core.Utilities.Results.Abstract;
using StokTakip.Core.Utilities.Results.ComplexType;

namespace StokTakip.Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }
        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;
        }
        public Result(ResultStatus resultStatus, string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }
    }
}
