

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a loan entity in the Maverick Bank system.
    /// </summary>
    public class Loan : IEquatable<Loan>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the loan.
        /// </summary>
        public int LoanID { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the customer associated with the loan.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the amount of the loan.
        /// </summary>
        public float LoanAmount { get; set; }

        /// <summary>
        /// Gets or sets the interest rate for the loan.
        /// </summary>
        public float InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the tenure of the loan in months.
        /// </summary>
        public int TenureMonths { get; set; }

        /// <summary>
        /// Gets or sets the status of the loan (default is "Pending").
        /// </summary>
        public string Status { get; set; } = "Pending";

        /// <summary>
        /// Gets or sets the associated customer object.
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class.
        /// </summary>
        public Loan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class with specified parameters.
        /// </summary>
        /// <param name="loanID">The unique identifier for the loan.</param>
        /// <param name="customerID">The unique identifier of the customer associated with the loan.</param>
        /// <param name="loanAmount">The amount of the loan.</param>
        /// <param name="interestRate">The interest rate for the loan.</param>
        /// <param name="tenureMonths">The tenure of the loan in months.</param>
        /// <param name="status">The status of the loan.</param>
        public Loan(int loanID, int customerID, float loanAmount, float interestRate, int tenureMonths, string status)
        {
            LoanID = loanID;
            CustomerID = customerID;
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            TenureMonths = tenureMonths;
            Status = status;
        }

        /// <summary>
        /// Determines whether the current loan object is equal to another loan object.
        /// </summary>
        /// <param name="other">The loan to compare with the current loan.</param>
        /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(Loan? other)
        {
            var loan = other ?? new Loan();
            return this.LoanID.Equals(loan.LoanID);
        }
    }
}




#region Annotation
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents a loan entity.
//    /// </summary>
//    public class Loan
//    {
//        /// <summary>
//        /// Gets or sets the loan ID.
//        /// </summary>
//        [Key]
//        public int LoanID { get; set; }

//        /// <summary>
//        /// Gets or sets the associated customer ID.
//        /// </summary>
//        [ForeignKey("Customer")]
//        public int CustomerID { get; set; }

//        /// <summary>
//        /// Gets or sets the associated customer.
//        /// </summary>
//        public Customer Customer { get; set; }

//        /// <summary>
//        /// Gets or sets the loan amount.
//        /// </summary>
//        public float LoanAmount { get; set; }

//        /// <summary>
//        /// Gets or sets the interest rate.
//        /// </summary>
//        public float InterestRate { get; set; }

//        /// <summary>
//        /// Gets or sets the tenure in months.
//        /// </summary>
//        public int TenureMonths { get; set; }

//        /// <summary>
//        /// Gets or sets the status of the loan.
//        /// </summary>
//        public string Status { get; set; }
//    }
//}
#endregion