using Microsoft.AspNetCore.Mvc;
using TheatricalPlayers.Domain.Interfaces.Services;
using TheatricalPlayersRefactoringKata;

namespace TheatricalPlayers.Apirest.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoiceController : ControllerBase
{
    private readonly IInvoiceService _invoiceService;

    public InvoiceController(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    [HttpGet]
    public string PrintStatement([FromBody]Invoice invoice)
    {
        return _invoiceService.Print(invoice);
    }
}
