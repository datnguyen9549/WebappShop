using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Web.Data.Enums;
using Web.Data.Interfaces;
using Web.Infrastructure.SharedKernel;

namespace Web.Data.Entities
{
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill()
        {

        }
        public Bill(string customerName, string customerAddress, string customerEmail, string customerPhone, Status status, string customerId, BillStatus billStatus, PaymentMethod paymentMethod)
        {
            CustomerName = customerName;
            CustomerEmail = customerName;
            CustomerPhone = customerPhone;
            Status = status;
            CustomerId = CustomerId;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
        }
        public Bill(int id, string customerName, string customerAddress, string customerEmail, string customerPhone, Status status, string customerId, BillStatus billStatus, PaymentMethod paymentMethod)
        {
            Id=id;
            CustomerName = customerName;
            CustomerEmail = customerName;
            CustomerPhone = customerPhone;
            Status = status;
            CustomerId = CustomerId;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
        }
               
        [StringLength(250)]
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual AppUser User { get; set; }
        [Required]
        [StringLength(256)]
        public string CustomerName { get; set; }
        public BillStatus BillStatus { get; set; }
        [Required]
        [StringLength(256)]
        public String CustomerAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;
        
    }
}
