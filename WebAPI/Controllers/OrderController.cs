using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers;

[Route("[controller]")]
public class OrderController : ApiControllerBase<OrderService>
{
    public OrderController(OrderService service) : base(service)
    {}

    [HttpPut("total/{id:int}")]
    public async Task<IActionResult> CalculateTotal(int id) {
        await Service.CalculateTotal(id);
        return Ok();
    }

    [HttpPut("total")]
    public async Task<IActionResult> CalculateTotal() {
        await Service.CalculateTotal();
        return Ok();
    }
}