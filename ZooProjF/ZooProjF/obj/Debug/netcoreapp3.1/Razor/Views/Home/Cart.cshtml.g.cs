#pragma checksum "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c0c66ddda95e3329e0828ef1250eb60143963c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\_ViewImports.cshtml"
using ZooProjF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\_ViewImports.cshtml"
using ZooProjF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0c66ddda95e3329e0828ef1250eb60143963c0", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82888676b601122a5468791cba2500573971ad7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--================Cart Area =================-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c0c66ddda95e3329e0828ef1250eb60143963c03859", async() => {
                WriteLiteral(@"
    <section class=""cart_area section_padding"">
        <div class=""container"">
            <div class=""cart_inner"">
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">Product</th>
                                <th scope=""col"">Price</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <div class=""media"">
                                        <div class=""d-flex"">
                                            <img");
                BeginWriteAttribute("src", " src=\"", 1029, "\"", 1095, 1);
#nullable restore
#line 27 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1035, Url.Content("~/Content/assets_store/img/categori/toys.jpg"), 1035, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1096, "\"", 1102, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""media-body"">
                                            <p>Minimalistic shop for multipurpose use</p>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <h5>$20.00</h5>
                                </td>
                                <td>
                                    <div class=""product_count"">
                                        <!-- <input type=""text"" value=""1"" min=""0"" max=""10"" title=""Quantity:""
                                          class=""input-text qty input-number"" />
                                        <button
                                          class=""increase input-number-increment items-count"" type=""button"">
                                          <i class=""ti-angle-up""></i>
                            ");
                WriteLiteral(@"            </button>
                                        <button
                                          class=""reduced input-number-decrement items-count"" type=""button"">
                                          <i class=""ti-angle-down""></i>
                                        </button> -->
                                        <span class=""input-number-decrement""> <i class=""ti-minus""></i></span>
                                        <input class=""input-number"" type=""text"" value=""1"" min=""0"" max=""10"">
                                        <span class=""input-number-increment""> <i class=""ti-plus""></i></span>
                                    </div>
                                </td>
                                <td>
                                    <h5>$9.00</h5>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class=""media"">
         ");
                WriteLiteral("                               <div class=\"d-flex\">\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 3252, "\"", 3323, 1);
#nullable restore
#line 62 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3258, Url.Content("~/Content/assets_store/img/categori/hamburger.jpg"), 3258, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3324, "\"", 3330, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""media-body"">
                                            <p>Minimalistic shop for multipurpose use</p>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <h5>$9.00</h5>
                                </td>
                                <td>
                                    <div class=""product_count"">
                                        <span class=""input-number-decrement""> <i class=""ti-minus""></i></span>
                                        <input class=""input-number"" type=""text"" value=""1"" min=""0"" max=""10"">
                                        <span class=""input-number-increment""> <i class=""ti-plus""></i></span>
                                    </div>
                                </td>
                                <td>
");
                WriteLiteral(@"                                    <h5>$9.00</h5>
                                </td>
                            </tr>
                            <tr class=""bottom_button"">
                                <td>
                                    <a class=""btn_1"" href=""#"">Update Cart</a>
                                </td>
                                <td></td>
                                <td></td>

                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td>
                                    <h5>Subtotal</h5>
                                </td>
                                <td>
                                    <h5>$2160.00</h5>
                                </td>
                            </tr>
                            <tr class=""shipping_area"">
                                <td></td>
                                <td></td>
  ");
                WriteLiteral(@"                              <td>
                                    <h5>Shipping</h5>
                                </td>
                                <td>
                                    <div class=""shipping_box"">
                                        <ul class=""list"">
                                            <li>
                                                Flat Rate: $5.00
                                                <input type=""radio"" aria-label=""Radio button for following text input"">
                                            </li>
                                            <li>
                                                Free Shipping
                                                <input type=""radio"" aria-label=""Radio button for following text input"">
                                            </li>
                                            <li>
                                                Flat Rate: $10.00
                                           ");
                WriteLiteral(@"     <input type=""radio"" aria-label=""Radio button for following text input"">
                                            </li>
                                            <li class=""active"">
                                                Local Delivery: $2.00
                                                <input type=""radio"" aria-label=""Radio button for following text input"">
                                            </li>
                                        </ul>
                                        <h6>
                                            Calculate Shipping
                                            <i class=""fa fa-caret-down"" aria-hidden=""true""></i>
                                        </h6>

                                        <input class=""post_code"" type=""text"" placeholder=""Postcode/Zipcode"" />
                                        <a class=""btn_1"" href=""#"">Update Details</a>
                                    </div>
                                </td>
   ");
                WriteLiteral("                         </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <div class=\"checkout_btn_inner float-right\">\r\n                        <a class=\"btn_1\"");
                BeginWriteAttribute("href", " href=\"", 7629, "\"", 7667, 1);
#nullable restore
#line 140 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\Home\Cart.cshtml"
WriteAttributeValue("", 7636, Url.Action("ShopIndex","Home"), 7636, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Continue Shopping</a>\r\n                        <a class=\"btn_1 checkout_btn_1\"");
                BeginWriteAttribute("href", " href=\"", 7747, "\"", 7789, 1);
#nullable restore
#line 141 "C:\Users\Max\Desktop\test\Databases-Project\ZooProjF\ZooProjF\Views\Home\Cart.cshtml"
WriteAttributeValue("", 7754, Url.Action("CheckoutIndex","Home"), 7754, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Proceed to checkout</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!--================End Cart Area =================-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
