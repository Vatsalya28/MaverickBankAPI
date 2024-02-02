namespace MaverickBankAPI.Models
{
    public class Customer:IEquatable<Customer>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user associated with the customer.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the user entity associated with the customer.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
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
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the Aadhar number of the customer.
        /// </summary>
        public string AadharNumber { get; set; }

        /// <summary>
        /// Gets or sets the PAN (Permanent Account Number) of the customer.
        /// </summary>
        public string PanNumber { get; set; }

        /// <summary>
        /// Gets the age of the customer based on the date of birth.
        /// </summary>
        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - DateOfBirth.Year;
                return age;
            }
        }

        /// <summary>
        /// Gets or sets the collection of accounts associated with the customer.
        /// </summary>
        public ICollection<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or sets the collection of beneficiaries associated with the customer.
        /// </summary>
        public ICollection<Beneficiary> Beneficiaries { get; set; }

        /// <summary>
        /// Gets or sets the collection of loans associated with the customer.
        /// </summary>
        public ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Default constructor for the Customer class.
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Parameterized constructor for the Customer class.
        /// </summary>
        /// <param name="customerId">The unique identifier for the customer.</param>
        /// <param name="userId">The identifier of the user associated with the customer.</param>
        /// <param name="name">The name of the customer.</param>
        /// <param name="gender">The gender of the customer.</param>
        /// <param name="contactNumber">The contact number of the customer.</param>
        /// <param name="address">The address of the customer.</param>
        /// <param name="dateOfBirth">The date of birth of the customer.</param>
        /// <param name="aadharNumber">The Aadhar number of the customer.</param>
        /// <param name="panNumber">The PAN (Permanent Account Number) of the customer.</param>

        public Customer(int customerId, int userId, string name, string gender, string contactNumber, string address, DateTime dateOfBirth, string aadharNumber, string panNumber)
        {
            CustomerID = customerId;
            UserID = userId;
            Name = name;
            Gender = gender;
            ContactNumber = contactNumber;
            Address = address;
            DateOfBirth = dateOfBirth;
            AadharNumber = aadharNumber;
            PanNumber = panNumber;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>

        public bool Equals(Customer? other)
            {
            var customer = other ?? new Customer();
            return this.CustomerID.Equals(customer.CustomerID);
            }
        
    }

}




















#region Annotiation

//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents a customer entity.
//    /// </summary>
//    public class Customer
//    {
//        /// <summary>
//        /// Gets or sets the customer ID.
//        /// </summary>
//        [Key]
//        public int CustomerID { get; set; }

//        /// <summary>
//        /// Gets or sets the associated user ID.
//        /// </summary>
//        [ForeignKey("User")]
//        public int UserID { get; set; }

//        /// <summary>
//        /// Gets or sets the associated user.
//        /// </summary>
//        public User User { get; set; }

//        /// <summary>
//        /// Gets or sets the name of the customer.
//        /// </summary>
//        [Required]
//        public string Name { get; set; }

//        /// <summary>
//        /// Gets or sets the gender of the customer.
//        /// </summary>
//        public string Gender { get; set; }

//        /// <summary>
//        /// Gets or sets the contact number of the customer.
//        /// </summary>
//        public string ContactNumber { get; set; }

//        /// <summary>
//        /// Gets or sets the address of the customer.
//        /// </summary>
//        public string Address { get; set; }

//        /// <summary>
//        /// Gets or sets the date of birth of the customer.
//        /// </summary>
//        public DateTime? DateOfBirth { get; set; }

//        /// <summary>
//        /// Gets or sets the Aadhar number of the customer.
//        /// </summary>
//        public string AadharNumber { get; set; }

//        /// <summary>
//        /// Gets or sets the PAN number of the customer.
//        /// </summary>
//        public string PanNumber { get; set; }

//        /// <summary>
//        /// Gets or sets the accounts associated with the customer.
//        /// </summary>
//        public ICollection<Account> Accounts { get; set; }

//        public Customer()
//        {
//            Accounts = new List<Account>();
//        }
//    }
//}
#endregion