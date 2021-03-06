﻿using System;
using APIWeb.Models;
using Microsoft.AspNetCore.Http;

namespace APIWeb.Services
{
        public class ProductRepository
        {

            public Produit[] GetAllProducts()
            {
           
                    return new Produit[]
                {
                    new Produit
                    {
                        id = 1,
                        name = "Paquet de bonbons",
                        price = 3.5m
                    },
                     new Produit
                    {
                        id = 2,
                        name = "Serpillère",
                        price = 10.25m
                    }
                    };
              }

            public Produit GetProduit(int id)
            {
                Produit[] produits = GetAllProducts();
                foreach(Produit produit in produits){
                    if(produit.id == id){
                        return produit;
                    }
                }
                return null;  
                }
        }

   

}
