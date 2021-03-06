// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sep3Vacation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Sep3Vacation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Sep3Vacation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\MyProfile.razor"
using Sep3Vacation.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\MyProfile.razor"
using Sep3Vacation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\MyProfile.razor"
using Sep3Vacation.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\MyProfile.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyProfile")]
    public partial class MyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\MyProfile.razor"
       

    private User _currentUser = new();
    private string _usersName = "";
    private List<BoughtPackage> _boughtPackages = new List<BoughtPackage>();
    private BoughtPackage _packageBoughtByThisUser = new BoughtPackage();
    
    protected override async Task OnInitializedAsync()
    {
        _usersName = ((CustomAuthenticationStateProvider)_authenticationStateProvider).GetAuthenticationStateAsync().Result.User.Identity?.Name;
         _currentUser =await _userService.GetUserByUserName(_usersName);
        _boughtPackages = await _boughtPackagesService.GetBoughtPackagesAsync();
        _packageBoughtByThisUser = _boughtPackages.FirstOrDefault(p => p.UserId == _currentUser.id);

    }
    
    private void Edit(int id)
    {
        _navigationManager.NavigateTo($"EditUserInfoMyProfile/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBoughtPackages _boughtPackagesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
    }
}
#pragma warning restore 1591
