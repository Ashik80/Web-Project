#pragma checksum "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9c66dc295c30c9d5ce1e24396cd9815056dd80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/media/ashik/New Volume5/dotnet/Web-Project/Views/_ViewImports.cshtml"
using web_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/ashik/New Volume5/dotnet/Web-Project/Views/_ViewImports.cshtml"
using web_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9c66dc295c30c9d5ce1e24396cd9815056dd80", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64be118e9dec39e768149b6ce759e2a89dbfa2a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Cart/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Cart/responsive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Signup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Logo1o.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Billing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
  

    Layout = null;

    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE HTML>\n<html lang=\"en-US\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd808748", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n\n\n    <title>");
#nullable restore
#line 17 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>


    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css""
        integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""anonymous"" />


    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css""
        integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">





    <!-- Additional CSS Files -->


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e9c66dc295c30c9d5ce1e24396cd9815056dd809764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8010926", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8012785", async() => {
                WriteLiteral("\n\n    <div class=\"upper-header\">\n");
#nullable restore
#line 43 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
          







            var user = (System.Security.Claims.ClaimsIdentity)User.Identity;







            var userName = user.FindFirst("Name")?.Value;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
         if (userName != null)



        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row justify-content-end\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8013678", async() => {
                    WriteLiteral(" <button\n                    class=\"btn btn-primary btn-1 btn-lg\"><i class=\"fas fa-user-hard-hat\"></i>\n                        ");
#nullable restore
#line 69 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                   Write(userName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(", Logout</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8015959", async() => {
                    WriteLiteral("<button class=\"btn btn-2\"><i class=\"fas fa-shopping-basket\"></i>\n                        Shopping busket <br />\n                        <span>£0.00</span></button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n");
#nullable restore
#line 75 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"

        }



        else



        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8017785", async() => {
                    WriteLiteral(" <button class=\"btn btn-primary btn-1\"><i\n                    class=\"fas fa-user-hard-hat\"></i>\n                    Login</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8019375", async() => {
                    WriteLiteral("<button class=\"btn btn-primary btn-1\"><i\n                    class=\"fas fa-user-hard-hat\"></i> Sign\n                    Up</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 92 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n\n    <nav>\n        <div class=\"navbar\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8021179", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <div class=\"menu-toggle\"><span class=\"icon-bar\"></span><span class=\"icon-bar\"></span><span\n                    class=\"icon-bar\"></span></div>\n            <div class=\"menu\">\n                <ul>\n                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8022669", async() => {
                    WriteLiteral("HOME");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                    <li><a href=""#"">SHOP</a></li>
                    <li><a href=""#"">ABOUT </a></li>

                    <li><a href=""#"">CONTACT </a></li>
                </ul>

            </div>


            <div class=""social-icon"">
                <a");
                BeginWriteAttribute("class", " class=\"", 2690, "\"", 2698, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"https://fb.com/templatemo\" target=\"_blank\" rel=\"sponsored\"><i\n                        class=\"fab fa-facebook-f \"></i></a>\n\n                <a");
                BeginWriteAttribute("class", " class=\"", 2847, "\"", 2855, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"https://twitter.com/\" target=\"_blank\"><i class=\"fab fa-twitter  fa-fw me-2\"></i></a>\n                <a");
                BeginWriteAttribute("class", " class=\"", 2966, "\"", 2974, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""https://www.google-plus-g.com/"" target=""_blank""><i
                        class=""fab fa-google-plus-g  fa-fw me-2""></i></a>

                <a class="" "" href=""https://www.linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin  fa-fw""></i></a>
            </div>
        </div>
    </nav>



    <div class=""content-1"">


        <table class=""table  table-1 "">

            <thead>
                <tr>
                    <th class=""th1"">Product</th>
                    <th class=""th2"">Price</th>
                    <th class=""th2"">Quantity</th>

                    <th class=""th3"">Subtotal</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 145 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                  
                    decimal totalPrice = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td>\n                            <h6>");
#nullable restore
#line 152 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                            <p><span>Category:</span> ");
#nullable restore
#line 153 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                                                 Write(item.Product.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n                        </td>\n\n                        <td>\n                            <h6 class=\"pd-top\">$");
#nullable restore
#line 158 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                                           Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\n                        </td>\n                        <td class=\"quantity\">\n                            <p class=\"mr-top\"> <button class=\"minus-btn\">-</button>");
#nullable restore
#line 161 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("<button class=\"plus-btn\">+</button> </p>\n                        </td>\n");
#nullable restore
#line 163 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                          
                            var prodPrice = item.Quantity*item.Product.Price;
                            totalPrice += prodPrice;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\n                            <h6 class=\"float-left pd-top\">$");
#nullable restore
#line 168 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                                                      Write(prodPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\n                            <i class=\"fas fa-times float-right \"></i>\n                        </td>\n\n\n                    </tr>\n");
#nullable restore
#line 174 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            </tbody>
        </table>




    </div>



    <div class=""content-2"">

        <h2>Cart Total</h2>


        <table class=""table table-bordered table-2 "">
            <tbody>
                <tr>



                    <td class=""cl1"">
                        <h6>Subtotal</h6>
                    </td>
                    <td");
                BeginWriteAttribute("class", " class=\"", 5142, "\"", 5150, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        <h6>$");
#nullable restore
#line 202 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                        Write(totalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </h6>
                    </td>



                </tr>



                <tr>
                    <td class=""cl1"">
                        <h6 class=""r1-clm-1"">Shipping</h6>


                    </td>

                    <td>
                        <h6 class=""r1-clm-2"">Free Shipping</h6>

                        <br />

                        <h6 class=""r2-clm-2"">Shipping to 200 N bxel st ARt#1344 Dhaka 126005 </h6>

                        <h6");
                BeginWriteAttribute("class", " class=\"", 5649, "\"", 5657, 0);
                EndWriteAttribute();
                WriteLiteral(">Change Address</h6>\n                    </td>\n\n\n\n\n                </tr>\n                <tr>\n                    <td class=\"cl1\">\n                        <h6>Tax</h6>\n\n\n                    </td>\n\n                    <td>\n                        <h6");
                BeginWriteAttribute("class", " class=\"", 5907, "\"", 5915, 0);
                EndWriteAttribute();
                WriteLiteral(">$12.05</h6>\n\n\n                    </td>\n\n\n\n\n                </tr>\n                <tr>\n                    <td class=\"cl1\">\n                        <h6>Total</h6>\n\n\n                    </td>\n\n                    <td>\n                        <h6");
                BeginWriteAttribute("class", " class=\"", 6161, "\"", 6169, 0);
                EndWriteAttribute();
                WriteLiteral(">$");
#nullable restore
#line 257 "/media/ashik/New Volume5/dotnet/Web-Project/Views/Cart/Index.cshtml"
                                  Write(totalPrice-(decimal)12.05);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n\n\n                    </td>\n\n\n\n\n                </tr>\n\n\n\n            </tbody>\n\n\n        </table>\n\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9c66dc295c30c9d5ce1e24396cd9815056dd8031403", async() => {
                    WriteLiteral(" <button type=\"submit\" class=\"tbl2-btn btn\">Proceed to\n                Checkout</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    </div>










    <div class=""upper-footer"">

        <div class=""row"">

            <div class=""col-sm-6"">

                <h1>ALL ORGANIC</h1>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the
                    industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type
                    and scrambled it to make a type specimen book</p>
                <div class=""u-footer-social-icon"">
                    <a");
                BeginWriteAttribute("class", " class=\"", 6987, "\"", 6995, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"https://fb.com/templatemo\" target=\"_blank\" rel=\"sponsored\"><i\n                            class=\"fab fa-facebook-f f-padding \"></i></a>\n\n                    <a");
                BeginWriteAttribute("class", " class=\"", 7162, "\"", 7170, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"https://twitter.com/\" target=\"_blank\"><i\n                            class=\"fab fa-twitter  fa-fw me-2\"></i></a>\n                    <a");
                BeginWriteAttribute("class", " class=\"", 7313, "\"", 7321, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""https://www.google-plus-g.com/"" target=""_blank""><i
                            class=""fab fa-google-plus-g  fa-fw me-2""></i></a>

                    <a class="" "" href=""https://www.linkedin.com/"" target=""_blank""><i
                            class=""fab fa-linkedin  fa-fw""></i></a>
                </div>
            </div>

            <div class=""col-sm-3"">
                <h4>Category</h4>
                <a href=""h"">Vegetables</a>
                <a href=""h"">Fruits</a>
                <a href=""h"">Meat</a>
                <a href=""h"">Canned Organic</a>
                <a href=""h"">Organic</a>
                <a href=""h"">Mushrooms</a>
                <a href=""h"">Organic Juice</a>

            </div>
            <div class=""col-sm-3"">
                <h4>Contact</h4>
                <a class="" text-decoration-none "" href=""tel:+91 95000 77397"">+91 95000 77397</a>
                <p>Your address here</p>
                <p>info@yourdomain.com</p>

            </div>
        </div>
        <hr />
    </div");
                WriteLiteral(@">



    <div class=""footer"">

        <p>&copy;2021 All ORGANIC SHOP</p>

    </div>













    <!-- JavaScript Files -->
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>

    <script src=""http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.12.0.min.js""></script>

    <script type=""text/javascript"">

        var menu = $("".menu"");
        $(window).resize(function () {
            $("".menu-toggle"").removeClass(""active"");
            if ($(window).innerWidth() > 600) {
                menu.show();
            } else {
                menu.hide();
            }
        });
        $("".menu-toggle"").click(function () {
            $(this).toggleClass(""active"");
            menu.slideToggle();
        })
        $("".open-submenu"").click(function () {
            $(this).toggleClass(""active"");
 ");
                WriteLiteral("           $(this).next(\"ul\").slideToggle();\n            $(this).children(\".arrow\").toggleClass(\"down up\");\n        });\n\n    </script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
