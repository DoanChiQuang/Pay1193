using Pay1193.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay1193.Services
{
    public interface IPayService
    {
        Task CreateAsync(PaymentRecord paymentRecord);
        PaymentRecord GetById(int id);
        TaxYear GetTaxYearById(int id);
        IEnumerable<TaxYear> GetAllTaxYear();
        IEnumerable<PaymentRecord> GetAll();
        decimal OverTimeHours(decimal hoursWorked, decimal contractualHours);
        decimal ContractualEarning(decimal contractualHours, decimal hoursWorked, decimal hourlyRate);
        decimal OvertimeRate(decimal hourlyRate);
        decimal OvertimeEarnings(decimal overtimeEarnings, decimal contractualEarnings);
        decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees);
        decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings);
        decimal NetPay(decimal totalEarnings, decimal totalDeduction);
    }
}
