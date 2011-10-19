using System;
using System.Collections.Generic;

namespace MethodChainingExample
{
    public class Find: IInvoiceLink, IInvoiceQueryLink
    {
        private Find() { } //this class shouldn't be created directly

        public static IInvoiceLink Invoices { get { return new Find(); } }

        public IInvoiceQueryLink With(Func<Invoice, bool> func)
        {
            InvoiceConstraint = func;

            return this;
        }

        protected Func<Invoice, bool> InvoiceConstraint { get; set; }
        public IEnumerable<Invoice> Execute()
        {
            throw new NotImplementedException();
        }
    }
}