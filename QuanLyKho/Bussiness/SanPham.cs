using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.DTO;
using QuanLyKho.Models;
namespace QuanLyKho.Bussiness
{
    internal class SanPham
    {
        QuanLyKhoEntities entities = new QuanLyKhoEntities();
        public List<Product> getlists()
        {
            return entities.Products.ToList();
        }
        public List<SanPhamDTO> getDetaillists()
        {
            List<SanPhamDTO> lst = new List<SanPhamDTO>();
            var item = entities.Products
                   .Select(e => new SanPhamDTO
                   {
                       ProductID = e.ProductID,
                       ProductName = e.ProductName,
                       TenPB = e.Supplier.SupplierName,
                   })
                   .ToList();
            return lst;
        }
    }
}
