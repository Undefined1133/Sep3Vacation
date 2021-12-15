#pragma checksum "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30c0bc62fed974549684c0fe4ececa44d30391d3"
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
#line 2 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
using Sep3Vacation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
using Sep3Vacation.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
           [Authorize(Policy = "RoleAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageUsersRole")]
    public partial class ManageUsersRole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ManageUsersRole</h3>");
#nullable restore
#line 9 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
 if (users == null)
 {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
 }
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mdc-data-table");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mdc-data-table__table-container");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "mdc-data-table__table");
            __builder.AddAttribute(8, "aria-label", "Dessert calories");
            __builder.AddMarkupContent(9, @"<thead><tr class=""mdc-data-table__header-row""><th class=""mdc-data-table__header-cell mdc-data-table__header-cell--numeric"" role=""columnheader"" scope=""col"">Id</th>
                    <th class=""mdc-data-table__header-cell"" role=""columnheader"" scope=""col"">UserName</th>
                    <th class=""mdc-data-table__header-cell"" role=""columnheader"" scope=""col"">Password</th>
                    <th class=""mdc-data-table__header-cell mdc-data-table__header-cell--numeric"" role=""columnheader"" scope=""col"">Email</th>
                    <th class=""mdc-data-table__header-cell"" role=""columnheader"" scope=""col"">Role</th></tr></thead>
                ");
            __builder.OpenElement(10, "tbody");
            __builder.AddAttribute(11, "class", "mdc-data-table__content");
#nullable restore
#line 33 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                 foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.AddAttribute(13, "class", "mdc-data-table__row");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "mdc-data-table__cell mdc-data-table__cell--numeric");
            __builder.AddContent(16, 
#nullable restore
#line 36 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                                                                                        user.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "class", "mdc-data-table__cell");
            __builder.AddContent(20, 
#nullable restore
#line 37 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                                                          user.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "class", "mdc-data-table__cell");
            __builder.AddContent(24, 
#nullable restore
#line 38 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                                                          user.password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "mdc-data-table__cell mdc-data-table__cell--numeric");
            __builder.AddContent(28, 
#nullable restore
#line 39 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                                                                                        user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "class", "mdc-data-table__cell");
            __builder.AddContent(32, 
#nullable restore
#line 40 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                                                          user.role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                                                () => Edit(user.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\ManageUsersRole.razor"
       
    private IList<User> allUsers;
    private List<User> users ;
    private string? errorMessage;

    protected override async Task OnInitializedAsync()
    {
        allUsers = await UserService.GetAllUsers();
        // users =  allUsers.Where(p => p.role.Contains("user")).ToList(); 
        users = allUsers.ToList();
    }
    private void Edit(int id)
    {
        _navigationManager.NavigateTo($"EditUserRole/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591