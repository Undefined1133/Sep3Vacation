#pragma checksum "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af1b66aaa384f9636206967396126771e4b9bb8d"
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
#line 2 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
using Sep3Vacation.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
using Sep3Vacation.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Registration")]
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Registration</h3>\r\n");
            __builder.OpenComponent<Blazorise.Button>(1);
            __builder.AddAttribute(2, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 8 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
               Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                       HandleClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, " Click me");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Blazorise.Modal>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(9);
                __builder2.AddAttribute(10, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ModalSize>(
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                        ModalSize.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Centered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(13);
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.ModalTitle>(15);
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Icon>(17);
                            __builder5.AddAttribute(18, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                            IconName.Add

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(19, "\r\n                Register\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(21);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Validations>(25);
                        __builder4.AddAttribute(26, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ValidationMode>(
#nullable restore
#line 19 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                               ValidationMode.Manual

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Field>(28);
                            __builder5.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.FieldLabel>(30);
                                __builder6.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(32, "Username");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(33, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.TextEdit>(34);
                                __builder6.AddAttribute(35, "Autofocus", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(36, "Placeholder", "Enter username...");
                                __builder6.AddAttribute(37, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                           _username

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(38, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _username = __value, _username))));
                                __builder6.AddAttribute(39, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _username));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(40, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Field>(41);
                            __builder5.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.FieldLabel>(43);
                                __builder6.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(45, "Password");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(46, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.TextEdit>(47);
                                __builder6.AddAttribute(48, "Role", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.TextRole>(
#nullable restore
#line 26 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                                            TextRole.Password

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(49, "Placeholder", "Enter last password...");
                                __builder6.AddAttribute(50, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                           _password

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(51, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _password = __value, _password))));
                                __builder6.AddAttribute(52, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _password));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Validation>(54);
                            __builder5.AddAttribute(55, "Validator", new System.Action<Blazorise.ValidatorEventArgs>(
#nullable restore
#line 28 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                        ValidationRule.IsEmail

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.Field>(57);
                                __builder6.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Blazorise.FieldLabel>(59);
                                    __builder7.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(61, "Email");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(62, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.TextEdit>(63);
                                    __builder7.AddAttribute(64, "Placeholder", "Enter email...");
                                    __builder7.AddAttribute(65, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                               _email

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(66, "TextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _email = __value, _email))));
                                    __builder7.AddAttribute(67, "TextExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _email));
                                    __builder7.AddAttribute(68, "Feedback", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<Blazorise.ValidationError>(69);
                                        __builder8.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(71, "Invalid email");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(72, "\r\n                                ");
                                        __builder8.OpenComponent<Blazorise.ValidationSuccess>(73);
                                        __builder8.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(75, "Good email");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.AddComponentReferenceCapture(76, (__value) => {
#nullable restore
#line 19 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                                            _validations = (Blazorise.Validations)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(78);
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(80);
                        __builder4.AddAttribute(81, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 43 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                           Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(82, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 43 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                                     HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(84, "Close");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(85, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Button>(86);
                        __builder4.AddAttribute(87, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 44 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(88, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 44 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
                                                   Register

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(90, "Register");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(91, (__value) => {
#nullable restore
#line 9 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
             _modalRef = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\cooln\RiderProjects\Sep3Vacation\Sep3Vacation\Pages\Registration.razor"
       
    private Modal _modalRef;
    private string _email;
    private string _password;
    private string _username;
    private Validations _validations;
    private string toBeEncripted;
    public string toBeDecripted;

    private void HandleClick()
    {
        _modalRef.Show();
    }

    private void HideModal()
    {
        _modalRef.Hide();
    }

    private async Task Register()
    {
        if (_validations.ValidateAll().Result)
        {

            await UserService.ValidateRegister(_username, _password, _email);
            
                HideModal();
                await _validations.ClearAll();
                _navigationManager.NavigateTo("/Login");

        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICryptoService _cryptoService { get; set; }
    }
}
#pragma warning restore 1591
