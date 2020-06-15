﻿using Identity.API.DTO;
using Identity.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Identity.API.Services
{
    /// <summary>
    /// Interface for service to manage user accounts.
    /// </summary>
    interface IAccountService
    {
        /// <summary>
        /// User authentication.
        /// </summary>
        /// <param name="loginDTO">User login data.</param>
        /// <returns>Operation result.</returns>
        Task<TokenModel> AuthenticateAsync(LoginDTO loginDTO);

        /// <summary>
        /// User registration.
        /// </summary>
        /// <param name="accountDTO">User account data.</param>
        /// <returns>Uperation result.</returns>
        Task<(bool result, string message)> RegisterAsync(AccountDTO accountDTO);

        /// <summary>
        /// Get account by email address.
        /// </summary>
        /// <param name="email">Email address.</param>
        /// <returns>Account DTO.</returns>
        Task<AccountDTO> GetAccountByEmailAsync(string email);

        /// <summary>
        /// Get user account by user Id.
        /// </summary>
        /// <param name="accoundId">Account Identifier (GUID).</param>
        /// <returns>Account DTO.</returns>
        Task<AccountDTO> GetAccountByIdAsync(Guid accoundId);

        /// <summary>
        /// Get all user accounts.
        /// </summary>
        /// <returns>Collection of user account DTO.</returns>
        Task<ICollection<AccountDTO>> GetAllAccountsAsync();

        /// <summary>
        /// Update user account.
        /// </summary>
        /// <param name="accountDTO">User account DTO..</param>
        /// <returns>Operation result.</returns>
        Task<bool> UpdateAccountAsync(AccountDTO accountDTO);
    }
}