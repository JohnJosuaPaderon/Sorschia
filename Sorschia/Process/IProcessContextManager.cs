﻿using System;

namespace Sorschia
{
    public interface IProcessContextManager
    {
        IProcessContext Initialize(bool throwExceptions = true);
        void CatchException(IProcessContext context, Exception exception);
        void Finalize(IProcessContext context);
    }
}
