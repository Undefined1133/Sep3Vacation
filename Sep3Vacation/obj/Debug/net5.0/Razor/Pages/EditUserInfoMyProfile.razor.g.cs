#pragma checksum "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d16a8ae0bb28853f899682958b254e9fa990e012"
// <auto-generated/>
#pragma warning disable 1591
namespace Sep3Vacation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
using Sep3Vacation.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
using Sep3Vacation.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
using Sep3Vacation.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditUserInfoMyProfile/{Id:int}")]
    public partial class EditUserInfoMyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditUserInfoMyProfile</h3>");
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
 if (_userToEdit == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<em>User not found!</em>");
#nullable restore
#line 13 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                      _userToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                                                   Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n            UserName:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(11);
                __builder2.AddAttribute(12, "rows", "4");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                                                 _userToEdit.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userToEdit.username = __value, _userToEdit.username))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userToEdit.username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n            Password:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "rows", "4");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                                                             _userToEdit.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userToEdit.password = __value, _userToEdit.password))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userToEdit.password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n            Email:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(30);
                __builder2.AddAttribute(31, "rows", "4");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                                                 _userToEdit.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userToEdit.Email = __value, _userToEdit.Email))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userToEdit.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(36, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Save</button></p>\r\n        ");
                __builder2.OpenComponent<Blazorise.ListGroup>(37);
                __builder2.AddAttribute(38, "Flush", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ListGroupItem>(40);
                    __builder3.AddAttribute(41, "Name", "danger");
                    __builder3.AddAttribute(42, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 38 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
                                            Color.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, "Careful, you will be logged off!!! ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
   
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\EditUserInfoMyProfile.razor"
       

    [Parameter]
    public int Id { get; set; }


    private User _userToEdit;


    protected override async Task OnInitializedAsync()
    {
        _userToEdit = await UserService.GetUserById(Id);
    }

    private async Task Save()
    {
        await UserService.UpdateUsersInfo( new User()
        {
            id = Id,
            username = _userToEdit.username,
            password = _userToEdit.password,
            Email = _userToEdit.Email,
            role = ""
        });
        await PerformLogout();
    }

    private async Task PerformLogout() {
        try {
            ((CustomAuthenticationStateProvider)AuthenticationStateProvider).Logout();
            _navigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
