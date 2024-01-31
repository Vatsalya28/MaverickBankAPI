using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a customer entity.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        [Key]
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the associated user ID.
        /// </summary>
        [ForeignKey("User")]
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the associated user.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the gender of the customer.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the contact number of the customer.
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets the address of the customer.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the customer.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the Aadhar number of the customer.
        /// </summary>
        public string AadharNumber { get; set; }

        /// <summary>
        /// Gets or sets the PAN number of the customer.
        /// </summary>
        public string PanNumber { get; set; }

        /// <summary>
        /// Gets or sets the accounts associated with the customer.
        /// </summary>
        public ICollection<Account> Accounts { get; set; }

        public Customer()
        {
            Accounts = new List<Account>();
        }
    }
}
