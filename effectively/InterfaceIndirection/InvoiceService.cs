namespace effectively.ExtractInterface {
    using Microsoft.AspNetCore.Http;
    using System.Net;
    using System.Web;

    public class InvoiceService {

        public InvoiceDto GetInvoice(int id) {

            // arg! how can I test that this happened?

            // TODO: how can we support this in .NET Core?
            //HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;

            return new InvoiceDto { Id = id };
        }

    }
}
