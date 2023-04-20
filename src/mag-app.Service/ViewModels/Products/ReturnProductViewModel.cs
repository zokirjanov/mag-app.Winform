using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.ViewModels.Products
{
    public class ReturnProductViewModel
    {
        public string Barcode { get; set; }
        public string Category { get; set; }
        public string SubCastegory { get; set; }
        public long SaleGlobalId { get; set; }
        public string SgName { get; set; }
        public decimal Return { get; set; }
        public decimal SgProductPrice { get; set; }
        public decimal ReturnedPrice { get; set; }
        public DateTime ReturnDate { get; set; }

        public static implicit operator ReturnProduct(ReturnProductViewModel product)
        {
            return new ReturnProduct()
            {
                Barcode= product.Barcode,
                Category = product.Category,
                SubCategory = product.SubCastegory,
                SaleGlobalId= product.SaleGlobalId,
                SgProductName= product.SgName,
                Quantity= product.Return,
                SgProductPrice= product.SgProductPrice,
                ReturnedPrice= product.ReturnedPrice,
                ReturnDate = TimeHelper.CurrentTime(),
            };
        }
    }
}
