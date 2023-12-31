﻿using Endava.TechCourse.BankApp.Domain.Common;
using Endava.TechCourse.BankApp.Shared.Enums;

namespace Endava.TechCourse.BankApp.Domain.Models
{
    public class Wallet : BaseEntity
    {
        public string Type { get; set; } = "Portofel digital";

        public decimal Amount { get; set; } = new Random().Next(50, 300);

        public string Currency { get; set; }

        public decimal ChangeRate { get; set; }

        public WalletType WalletType { get; set; }
    }
}