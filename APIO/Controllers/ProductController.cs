using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pyronet.Repo.Data;
using pyronet.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly StoreContext _context;

        public ProductController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
           var products = await _context.Products.ToListAsync();
           return Ok(products);

        }

        [HttpGet("{id}")] //tek bir ürün getirirken bu işlem uygulanıyor.
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
           return await _context.Products.FindAsync(id);

        }
    }

        
 }
