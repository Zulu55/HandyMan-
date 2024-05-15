﻿using Microsoft.AspNetCore.Components;
using Orders.Frontend.Services;

namespace HandyMan_.Frontend.Pages.Auth


{
    public partial class Logout
{
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Inject] private ILoginService LoginService { get; set; } = null!;

        protected override async Task OnInitializedAsync()
        {
            await LoginService.LogoutAsync();
            NavigationManager.NavigateTo("/");
        }
    }
}
