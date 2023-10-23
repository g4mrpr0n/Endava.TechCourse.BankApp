﻿using Endava.TechCourse.BankApp.Domain.Common;

namespace Endava.TechCourse.BankApp.Domain.Models
{
    internal class Wallet : BaseEntity
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public decimal ChangeRate { get; set; }
    }
}