using System;
using System.Collections.Generic;

namespace LIAECommerce.Models
{
    public class Return
    {
        public int ReturnId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public short Opened { get; set; }
        public int ReturnReasonId { get; set; }
        public ReturnReason ReturnReason { get; set; }
        public int ReturnActionId { get; set; }
        public ReturnAction ReturnAction { get; set; }
        public int ReturnStatusId { get; set; }
        public ReturnStatus ReturnStatus { get; set; }
        public string Comment { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<ReturnHistory> ReturnHistory { get; set; }
    }
}
