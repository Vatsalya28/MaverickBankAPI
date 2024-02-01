namespace MaverickBankAPI.Models
{
    public class BankEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public string Position { get; set; }

        public User? User { get; set; }
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