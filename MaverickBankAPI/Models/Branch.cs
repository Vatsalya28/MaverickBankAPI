using System;

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a bank branch.
    /// </summary>
    public class Branch
    {
        /// <summary>
        /// Gets or sets the IFSC (Indian Financial System Code) of the branch.
        /// </summary>
        public string IFSCCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the branch.
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the bank to which the branch belongs.
        /// </summary>
        public int BankID { get; set; }

        /// <summary>
        /// Gets or sets the bank entity associated with the branch.
        /// </summary>
        public Bank Bank { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Branch"/> class.
        /// </summary>
        public Branch()
        {
            // Default constructor
        }

        /// <summary>
        /// Initializes a new instance of the Branch class with specified parameters.
        /// </summary>
        /// <param name="ifscCode">The IFSC code of the branch.</param>
        /// <param name="branchName">The name of the branch.</param>
        /// <param name="bankID">The ID of the bank to which the branch belongs.</param>
        public Branch(string ifscCode, string branchName, int bankID)
        {
            IFSCCode = ifscCode;
            BranchName = branchName;
            BankID = bankID;
        }
    }
}
