﻿using System;

namespace Dotnet_Angular.Classes
{
    /// <summary>
    /// Statement Row represents a single row in the bank statement
    /// It represents a single transaction on account
    /// </summary>
    public interface IStatementRow
    {
        /// <summary>
        /// Account on which the transaction is made
        /// </summary>
        Account Account { get; }

        /// <summary>
        /// Date and time of the transaction
        /// </summary>
        DateTimeOffset Date { get; }

        /// <summary>
        /// Amount of the operation
        /// </summary>
        decimal Amount { get; }

        /// <summary>
        /// Balance of the account after the transaction
        /// </summary>
        decimal Balance { get; }

        /// <summary>
        /// Description of the transaction
        /// </summary>
        string Description { get; }
    }
}