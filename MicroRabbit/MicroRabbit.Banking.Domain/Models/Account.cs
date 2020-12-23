using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public int id { get; set; }
        public string AccountType1 { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
