using System;
using System.Collections.Generic;

namespace MethodChainingExample
{
    public interface IInvoiceLink: IEnumerable<Invoice>
    {
        IInvoiceQueryLink With(Func<Invoice, bool> func);
    }
}