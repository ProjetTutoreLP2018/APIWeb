using System;
namespace APIWeb.Models
{
    public class Produit
    {
        public int id;
        public string name;
        public decimal price; 

        public Produit()
        {
        }

        public Produit(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }


        public override string ToString()
        {
            return string.Format("[Produit: id={0}, name={1}, price={2}]", id, name, price);
        }

    }
}
