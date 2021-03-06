﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIWeb.Models;
using APIWeb.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private ProductRepository productRepository;

        public ProductController(){
            this.productRepository = new ProductRepository();
        }

        [HttpGet]
        // GET: api/product
        public Produit[] Get()
        {
            return this.productRepository.GetAllProducts();
        }

        // GET api/product/2
        [HttpGet("{id}")]
        public Produit Get(int id)
        {
            return this.productRepository.GetProduit(id);
        }

        // --- Non implémenté ---

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
