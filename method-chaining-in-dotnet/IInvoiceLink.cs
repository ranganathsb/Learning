using System;
using System.Collections.Generic;

namespace MethodChainingExample
{
    public interface IInvoiceLink
    {
        IInvoiceQueryLink With(Func<Invoice, bool> func);
    }
}