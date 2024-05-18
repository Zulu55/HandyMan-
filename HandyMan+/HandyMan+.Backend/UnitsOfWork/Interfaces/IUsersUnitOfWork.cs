﻿using HandyMan_.Shered.DTOs;
using HandyMan_.Shered.Entities;
using Microsoft.AspNetCore.Identity;

namespace HandyMan_.Backend.UnitsOfWork.Interfaces
{
    public interface IUsersUnitOfWork
    {

        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginDTO model);

        Task LogoutAsync();

        Task<User> GetUserAsync(Guid userId);

        Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<string> GeneratePasswordResetTokenAsync(User user);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);
    }
}
