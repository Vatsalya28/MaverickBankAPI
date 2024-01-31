using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a loan entity.
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Gets or sets the loan ID.
        /// </summary>
        [Key]
        public int LoanID { get; set; }

        /// <summary>
        /// Gets or sets the associated customer ID.
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the associated customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the loan amount.
        /// </summary>
        public float LoanAmount { get; set; }

        /// <summary>
        /// Gets or sets the interest rate.
        /// </summary>
        public float InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the tenure in months.
        /// </summary>
        public int TenureMonths { get; set; }

        /// <summary>
        /// Gets or sets the status of the loan.
        /// </summary>
        public string Status { get; set; }
    }
}
