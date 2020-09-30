using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vendor.Repository;

namespace Vendor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        IVendorDetailRepo ivendor;
        public VendorController(IVendorDetailRepo _db)
        {
            ivendor = _db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            if (ivendor.GetDetails() == null)
            {
                return BadRequest();
            }
            return Ok(ivendor.GetDetails());
        }
        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            return Ok(ivendor.GetVenderbyId(id));
        }
    }
}
