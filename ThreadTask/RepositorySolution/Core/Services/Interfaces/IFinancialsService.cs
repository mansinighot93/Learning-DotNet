using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Interfaces
{
public interface IFinancialsService
{
    decimal GetTotalSold();
    FinancialStats GetStats();
}
}
