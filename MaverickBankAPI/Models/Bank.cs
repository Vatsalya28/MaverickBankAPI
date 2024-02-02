using System;
using System.Collections.Generic;

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a bank entity.
    /// </summary>
    public class Bank : IEquatable<Bank>
    {
        /// <summary>
        /// Gets or sets the unique identifier of the bank.
        /// </summary>
        public int BankID { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank.
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets the collection of branches associated with the bank.
        /// </summary>
        public ICollection<Branch> Branches { get; set; }

        /// <summary>
        /// Gets or sets the collection of beneficiaries associated with the bank.
        /// </summary>
        public ICollection<Beneficiary> Beneficiaries { get; set; }
        public ICollection<Account> Accounts { get; set; }

        /// <summary>
        /// Initializes a new instance of the Bank class.
        /// </summary>
        public Bank()
        {
            // Default constructor
        }

        /// <summary>
        /// Initializes a new instance of the Bank class with the specified parameters.
        /// </summary>
        /// <param name="bankID">The unique identifier of the bank.</param>
        /// <param name="bankName">The name of the bank.</param>
        public Bank(int bankID, string bankName)
        {
            BankID = bankID;
            BankName = bankName;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public bool Equals(Bank other)
        {
            if (other == null)
                return false;

            return this.BankID.Equals(other.BankID);
        }
    }
}
