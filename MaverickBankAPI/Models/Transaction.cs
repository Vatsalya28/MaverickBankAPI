namespace MaverickBankAPI.Models
{

    public class Transaction:IEquatable<Transaction>
    {
        /// <summary>
        /// Gets or sets the unique identifier for the transaction.
        /// </summary>
        public int TransactionID { get; set; }

        /// <summary>
        /// Gets or sets the type of the transaction.
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the amount involved in the transaction.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the transaction.
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Gets or sets the ID of the source account involved in the transaction.
        /// </summary>
        public int Source_ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the destination account involved in the transaction.
        /// </summary>
        public int Destination_Id { get; set; }

        /// <summary>
        /// Gets or sets the source account associated with the transaction.
        /// </summary>
        public Account? SourceAccount { get; set; }

        /// <summary>
        /// Gets or sets the destination account associated with the transaction.
        /// </summary>
        public Account? DestinationAccount { get; set; }

        /// <summary>
        /// Default constructor for transaction
        /// </summary>
        public Transaction()
        {

        }

        /// <summary>
        /// Initializes a new instance of the Transaction class with specified parameters.
        /// </summary>
        /// <param name="transactionId">The unique identifier for the transaction.</param>
        /// <param name="transactionType">The type of the transaction.</param>
        /// <param name="amount">The amount involved in the transaction.</param>
        /// <param name="transactionDate">The date and time of the transaction.</param>
        /// <param name="sourceId">The ID of the source account involved in the transaction.</param>
        /// <param name="destinationId">The ID of the destination account involved in the transaction.</param>
        public Transaction(int transactionId, string transactionType, double amount, DateTime transactionDate, int sourceId, int destinationId)
        {
            TransactionID = transactionId;
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
            Source_ID = sourceId;
            Destination_Id = destinationId;
        }


        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>

        public bool Equals(Transaction? other)
        {
            var transaction = other ?? new Transaction();
            return this.TransactionID.Equals(transaction.TransactionID);
        }
    }
}










































#region Annotation


//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace MaverickBankAPI.Models
//{
//    /// <summary>
//    /// Represents a transaction entity.
//    /// </summary>
//    public class Transaction
//    {
//        /// <summary>
//        /// Gets or sets the transaction ID.
//        /// </summary>
//        [Key]
//        public int TransactionID { get; set; }

//        /// <summary>
//        /// Gets or sets the account ID associated with the transaction.
//        /// </summary>
//        [ForeignKey("Account")]
//        public int AccountID { get; set; }

//        /// <summary>
//        /// Gets or sets the associated account.
//        /// </summary>
//        public Account Account { get; set; }

//        /// <summary>
//        /// Gets or sets the type of the transaction.
//        /// </summary>
//        [Required]
//        public string TransactionType { get; set; }

//        /// <summary>
//        /// Gets or sets the amount of the transaction.
//        /// </summary>
//        [Column(TypeName = "float")]
//        public double Amount { get; set; }

//        /// <summary>
//        /// Gets or sets the destination account ID for transfer transactions.
//        /// </summary>
//        [ForeignKey("DestinationAccount")]
//        public int? DestinationAccountID { get; set; }

//        /// <summary>
//        /// Gets or sets the associated destination account for transfer transactions.
//        /// </summary>
//        public Account DestinationAccount { get; set; }

//        /// <summary>
//        /// Gets or sets the date and time of the transaction.
//        /// </summary>
//        public DateTime TransactionDate { get; set; } = DateTime.Now;
//    }
//}
#endregion