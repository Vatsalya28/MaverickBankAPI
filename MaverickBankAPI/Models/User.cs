
using MaverickBankAPI.Models;

public class User
{
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }

    public ICollection<Customer> Customers { get; set; }
    public ICollection<BankEmployee> BankEmployees { get; set; }
    public ICollection<Administrator> Administrators { get; set; }
}
































#region Annotation
//using System;
//using System.ComponentModel.DataAnnotations;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents a user entity.
//    /// </summary>
//    public class User : IEquatable<User>
//    {
//        /// <summary>
//        /// Gets or sets the user ID.
//        /// </summary>
//        [Key]
//        public int UserID { get; set; }

//        /// <summary>
//        /// Gets or sets the user name.
//        /// </summary>
//        public string UserName { get; set; } = string.Empty;

//        /// <summary>
//        /// Gets or sets the user password.
//        /// </summary>
//        public string Password { get; set; } = string.Empty;

//        /// <summary>
//        /// Gets or sets the type of the user.
//        /// </summary>
//        public string UserType { get; set; } = string.Empty;

//        /// <summary>
//        /// Initializes a new instance of the <see cref="User"/> class.
//        /// </summary>
//        public User()
//        {
//            UserID = 0;
//        }

//        /// <summary>
//        /// Initializes a new instance of the <see cref="User"/> class with specified parameters.
//        /// </summary>
//        /// <param name="userId">The user ID.</param>
//        /// <param name="userName">The user name.</param>
//        /// <param name="password">The user password.</param>
//        /// <param name="userType">The type of the user.</param>
//        public User(int userId, string userName, string password, string userType)
//        {
//            UserID = userId;
//            UserName = userName;
//            Password = password;
//            UserType = userType;
//        }

//        /// <summary>
//        /// Initializes a new instance of the <see cref="User"/> class with specified parameters.
//        /// </summary>
//        /// <param name="userName">The user name.</param>
//        /// <param name="password">The user password.</param>
//        /// <param name="userType">The type of the user.</param>
//        public User(string userName, string password, string userType)
//        {
//            UserName = userName;
//            Password = password;
//            UserType = userType;
//        }

//        /// <summary>
//        /// Determines whether the specified object is equal to the current object.
//        /// </summary>
//        /// <param name="other">The object to compare with the current object.</param>
//        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
//        public bool Equals(User? other)
//        {
//            var user = other ?? new User();
//            return this.UserID.Equals(user.UserID);
//        }
//    }
//}
#endregion