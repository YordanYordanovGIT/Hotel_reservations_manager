#pragma checksum "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c8f7fc600886a15db466651844816aff4a43d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_List), @"mvc.1.0.view", @"/Views/Rooms/List.cshtml")]
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
#line 1 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\_ViewImports.cshtml"
using Hotel_reservations_manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\_ViewImports.cshtml"
using Hotel_reservations_manager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
using Hotel_reservations_manager.Models.Rooms;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c8f7fc600886a15db466651844816aff4a43d6", @"/Views/Rooms/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be4a1336bb98d23d460a0bfd352f5efabb16d64", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotel_reservations_manager.Models.Rooms.RoomsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reserve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
   ViewData["Title"] = "Rooms"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Rooms</h1>\n\n");
#nullable restore
#line 8 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
 if (Model.IsAdmin){

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c8f7fc600886a15db466651844816aff4a43d67267", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n");
#nullable restore
#line 12 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-columns\">\n");
#nullable restore
#line 15 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
     foreach (Room item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\n    <img class=\"card-img-top\" src=\"https://i.pinimg.com/originals/b6/aa/91/b6aa915a8af1139561f0b9ec24a2e5af.jpg\" alt=\"Card image cap\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">Room: ");
#nullable restore
#line 20 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 21 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <ul class=\"list-group list-group-flush\">\n        <li class=\"list-group-item\">");
#nullable restore
#line 24 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">Capacity: ");
#nullable restore
#line 25 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Capacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">");
#nullable restore
#line 26 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" лв.</li>\n    </ul>\n    <div class=\"card-body\">\n");
#nullable restore
#line 29 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
         if (Model.IsAdmin)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c8f7fc600886a15db466651844816aff4a43d611771", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br><br>");
#nullable restore
#line 31 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c8f7fc600886a15db466651844816aff4a43d614471", async() => {
                WriteLiteral("Reserve");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 33 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
         if (Model.IsAdmin)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c8f7fc600886a15db466651844816aff4a43d617352", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 35 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
#nullable restore
#line 37 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<ul class=\"pagination\">\n");
#nullable restore
#line 40 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
     for (var i = 1; i <= Model.Pager.PagesCount; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li");
            BeginWriteAttribute("class", " class=\"", 1537, "\"", 1602, 2);
            WriteAttributeValue("", 1545, "page-item", 1545, 9, true);
#nullable restore
#line 42 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
WriteAttributeValue(" ", 1554, i == Model.Pager.CurrentPage ? "active" : "", 1555, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c8f7fc600886a15db466651844816aff4a43d621261", async() => {
#nullable restore
#line 43 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                                                     Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Pager.CurrentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
                        WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Pager.CurrentPage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Pager.CurrentPage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Pager.CurrentPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</li>\n");
#nullable restore
#line 45 "D:\DAN\Programming\Projects\IT Kariera\Module 13\Proekt\Github\Hotel_reservations_manager\Hotel_reservations_manager\Hotel_reservations_manager\Views\Rooms\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotel_reservations_manager.Models.Rooms.RoomsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
