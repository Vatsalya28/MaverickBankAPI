using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a transaction entity.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the transaction ID.
        /// </summary>
        [Key]
        public int TransactionID { get; set; }

        /// <summary>
        /// Gets or sets the account ID associated with the transaction.
        /// </summary>
        [ForeignKey("Account")]
        public int AccountID { get; set; }

        /// <summary>
        /// Gets or sets the associated account.
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// Gets or sets the type of the transaction.
        /// </summary>
        [Required]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the amount of the transaction.
        /// </summary>
        [Column(TypeName = "float")]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the destination account ID for transfer transactions.
        /// </summary>
        [ForeignKey("DestinationAccount")]
        public int? DestinationAccountID { get; set; }

        /// <summary>
        /// Gets or sets the associated destination account for transfer transactions.
        /// </summary>
        public Account DestinationAccount { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the transaction.
        /// </summary>
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
