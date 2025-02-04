﻿using Microsoft.AspNetCore.Http.HttpResults;

namespace Core.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount {  get; set; }
        public DateTime TransactionDate {  get; set; }
        public Account Accounts { get; set; }
        public int ToAccountId {  get; set; }
        public int FromAccountId { get; set; }
    }
}

