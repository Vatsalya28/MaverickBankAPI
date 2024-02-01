﻿

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a beneficiary in the Maverick Bank system.
    /// </summary>
    public class Beneficiary : IEquatable<Beneficiary>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the beneficiary.
        /// </summary>
        public int BeneficiaryID { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the customer associated with the beneficiary.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the name of the beneficiary.
        /// </summary>
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// Gets or sets the account number of the beneficiary.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the bank name of the beneficiary.
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets the branch of the beneficiary's bank.
        /// </summary>
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the IFSC code of the beneficiary's bank.
        /// </summary>
        public string IFSCCode { get; set; }

        /// <summary>
        /// Gets or sets the associated customer object.
        /// </summary>
        public Customer? Customer { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Beneficiary"/> class.
        /// </summary>
        public Beneficiary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Beneficiary"/> class with specified parameters.
        /// </summary>
        /// <param name="beneficiaryID">The unique identifier for the beneficiary.</param>
        /// <param name="customerID">The unique identifier of the customer associated with the beneficiary.</param>
        /// <param name="beneficiaryName">The name of the beneficiary.</param>
        /// <param name="accountNumber">The account number of the beneficiary.</param>
        /// <param name="bankName">The bank name of the beneficiary.</param>
        /// <param name="branch">The branch of the beneficiary's bank.</param>
        /// <param name="iFSCCode">The IFSC code of the beneficiary's bank.</param>
        public Beneficiary(int beneficiaryID, int customerID, string beneficiaryName, string accountNumber, string bankName, string branch, string iFSCCode)
        {
            BeneficiaryID = beneficiaryID;
            CustomerID = customerID;
            BeneficiaryName = beneficiaryName;
            AccountNumber = accountNumber;
            BankName = bankName;
            Branch = branch;
            IFSCCode = iFSCCode;
        }

        /// <summary>
        /// Determines whether the current beneficiary object is equal to another beneficiary object.
        /// </summary>
        /// <param name="other">The beneficiary to compare with the current beneficiary.</param>
        /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(Beneficiary? other)
        {
            var beneficiary = other ?? new Beneficiary();
            return this.BeneficiaryID.Equals(beneficiary.BeneficiaryID);
        }
    }
}



#region Annotation
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents a beneficiary entity.
//    /// </summary>
//    public class Beneficiary
//    {
//        /// <summary>
//        /// Gets or sets the beneficiary ID.
//        /// </summary>
//        [Key]
//        public int BeneficiaryID { get; set; }

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
//        /// Gets or sets the beneficiary name.
//        /// </summary>
//        public string BeneficiaryName { get; set; }

//        /// <summary>
//        /// Gets or sets the account number.
//        /// </summary>
//        public string AccountNumber { get; set; }

//        /// <summary>
//        /// Gets or sets the bank name.
//        /// </summary>
//        public string BankName { get; set; }

//        /// <summary>
//        /// Gets or sets the branch.
//        /// </summary>
//        public string Branch { get; set; }

//        /// <summary>
//        /// Gets or sets the IFSC code.
//        /// </summary>
//        public string IFSCCode { get; set; }
//    }
//}
#endregion