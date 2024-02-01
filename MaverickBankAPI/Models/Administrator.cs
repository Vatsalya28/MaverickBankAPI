namespace MaverickBankAPI.Models
{
    public class Administrator
    {
        public int AdministratorID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }

        public User? User { get; set; }
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