#pragma checksum "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d91d9b46b9b266979270a3153d2c9d9430e374c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
using Sep3Vacation.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
using Sep3Vacation.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GetUserByUserNameCheck")]
    public partial class GetUserByUserNameCheck : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GetUserByUserNameCheck</h3>\r\n");
            __builder.AddContent(1, 
#nullable restore
#line 8 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
 _usersId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
 if(_usersId == null){
  

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 17 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
     _usersId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
             
 
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "mdc-button mdc-button--raised");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
                                                             Check

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        Check Get user by username\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\GetUserByUserNameCheck.razor"
       
    private int _usersId;
    private string _userName;

    private void Check()
    {
        _userName = ((CustomAuthenticationStateProvider) _authenticationStateProvider).GetAuthenticationStateAsync().Result.User.Identity?.Name;
        _usersId = _userService.GetUserByUserName(_userName).Id;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
