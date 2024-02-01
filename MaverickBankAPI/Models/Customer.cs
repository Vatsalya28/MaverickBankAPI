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

        public Customer()
        {

        }

        public Customer(int customerId, int userId, User user, string name, string gender, string contactNumber, string address, DateTime dateOfBirth, string aadharNumber, string panNumber)
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