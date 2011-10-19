using System.Collections.Generic;

namespace MethodChainingExample
{
    public interface IInvoiceQueryLink
    {
        IEnumerable<Invoice> Execute();
    }
}