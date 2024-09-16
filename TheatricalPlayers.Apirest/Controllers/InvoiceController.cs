using Microsoft.AspNetCore.Mvc;
using TheatricalPlayers.Domain.Interfaces.Services;
using TheatricalPlayersRefactoringKata;

namespace TheatricalPlayers.Apirest.Controllers;

public class InvoiceController
{
    private readonly IInvoiceService _invoiceService;
    [HttpGet]
    public string PrintStatement(Invoice invoice)
    {
        return _invoiceService.PrintStatement(invoice);
    }
}
