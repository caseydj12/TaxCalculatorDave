using System.ComponentModel.DataAnnotations;

namespace TaxCalc.Models
{
    public class TaxViewModel
    {
        // Todo: should we move this to the entity folder? does it matter?
        [Key]
        public Guid TaxId { get; set; }
        public double GrossAnnualSalary { get; set; }
        public double GrossMonthlySalary { get; set; }
        public double NetAnnualSalary { get; set; }
        public double NetMonthlySalary { get; set; }
        public double AnnualTaxPaid { get; set; }
        public double MonthlyTaxPaid { get; set; }
    }
}
