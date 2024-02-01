namespace MaverickBankAPI.Models
{
    /// <summary>
    /// Represents an administrator in the Maverick Bank system.
    /// </summary>
    public class Administrator : IEquatable<Administrator>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the administrator.
        /// </summary>
        public int AdministratorID { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user associated with the administrator.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the name of the administrator.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the associated user object.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class.
        /// </summary>
        public Administrator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class with specified parameters.
        /// </summary>
        /// <param name="administratorID">The unique identifier for the administrator.</param>
        /// <param name="userID">The unique identifier of the user associated with the administrator.</param>
        /// <param name="name">The name of the administrator.</param>
        public Administrator(int administratorID, int userID, string name)
        {
            AdministratorID = administratorID;
            UserID = userID;
            Name = name;
        }

        /// <summary>
        /// Determines whether the current administrator object is equal to another administrator object.
        /// </summary>
        /// <param name="other">The administrator to compare with the current administrator.</param>
        /// <returns><c>true</c> if the objects are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(Administrator? other)
        {
            var administrator = other ?? new Administrator();
            return this.AdministratorID.Equals(administrator.AdministratorID);
        }
    }
}




#region Annotation
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents an administrator entity.
//    /// </summary>
//    public class Administrator
//    {
//        /// <summary>
//        /// Gets or sets the administrator ID.
//        /// </summary>
//        [Key]
//        public int AdministratorID { get; set; }

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
//        /// Gets or sets the name of the administrator.
//        /// </summary>
//        public string Name { get; set; }
//    }
//}
#endregion