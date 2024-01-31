using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents an account entity.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the account ID.
        /// </summary>
        [Key]
        public int AccountID { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        [Column(TypeName = "nvarchar(50)")] // Adjust the data type and length as per your requirements
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the customer ID associated with the account.
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the associated customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the type of the account.
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or sets the balance of the account.
        /// </summary>
        [Column(TypeName = "float")]
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets the transactions associated with the account.
        /// </summary>
        public ICollection<Transaction> Transactions { get; set; }

        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        public Account()
        {
            Balance = 0.00; // Default balance
            Transactions = new List<Transaction>(); // Initialize the collection
        }
    }

    
}
