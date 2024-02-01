namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents a bank employee in the Maverick Bank system.
    /// </summary>
    public class BankEmployee : IEquatable<BankEmployee>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the bank employee.
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank employee.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user associated with the bank employee.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the position or role of the bank employee.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the associated user object.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankEmployee"/> class.
        /// </summary>
        public BankEmployee()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankEmployee"/> class with specified parameters.
        /// </summary>
        /// <param name="employeeID">The unique identifier for the bank employee.</param>
        /// <param name="name">The name of the bank employee.</param>
        /// <param name="userID">The unique identifier of the user associated with the bank employee.</param>
        /// <param name="position">The position or role of the bank employee.</param>
        public BankEmployee(int employeeID, string name, int userID, string position)
        {
            EmployeeID = employeeID;
            Name = name;
            UserID = userID;
            Position = position;
        }

        /// <summary>
        /// Determines whether the current bank employee object is equal to another bank employee object.
        /// </summary>
        /// <param name="other">The bank employee to compare with the current bank employee.</param>
        /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(BankEmployee? other)
        {
            var employee = other ?? new BankEmployee();
            return this.EmployeeID.Equals(employee.EmployeeID);
        }
    }
}



#region Annotation
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents a bank employee entity.
//    /// </summary>
//    public class BankEmployee
//    {
//        /// <summary>
//        /// Gets or sets the employee ID.
//        /// </summary>
//        [Key]
//        public int EmployeeID { get; set; }

//        /// <summary>
//        /// Gets or sets the name of the bank employee.
//        /// </summary>
//        public string Name { get; set; }

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
//        /// Gets or sets the position of the bank employee.
//        /// </summary>
//        public string Position { get; set; }
//    }
//}
#endregion