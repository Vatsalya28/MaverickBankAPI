

namespace MaverickBankAPI.Models
{
    public class Beneficiary
    {
        public int BeneficiaryID { get; set; }
        public int CustomerID { get; set; }
        public string BeneficiaryName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string IFSCCode { get; set; }

        public Customer Customer { get; set; }
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