using System.ComponentModel.DataAnnotations.Schema;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("BillDetails")]
    public class BillDetail : DomainEntity<int>
    {
        public BillDetail(int id ,int billId, int productId, int quantity, decimal price)
        {
            this.Id = id;
            this.BillId = billId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
        }
        public BillDetail(int billId, int productId, int quantity, decimal price)
        {
            this.BillId = billId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
        }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }
    }
}