#pragma checksum "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2adb2c94005955a7ffd8a72d8de3850ee1a42a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShopIndex), @"mvc.1.0.view", @"/Views/Home/ShopIndex.cshtml")]
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
#line 1 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\_ViewImports.cshtml"
using ZooProjF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\_ViewImports.cshtml"
using ZooProjF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2adb2c94005955a7ffd8a72d8de3850ee1a42a6d", @"/Views/Home/ShopIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82888676b601122a5468791cba2500573971ad7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShopIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
  
    ViewData["Title"] = "ShopIndex";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2adb2c94005955a7ffd8a72d8de3850ee1a42a6d5669", async() => {
                WriteLiteral(@"
<section id=""intro"">
    <div class=""intro-container"">
        <div id=""introCarousel"" class=""carousel  slide carousel-fade"" data-ride=""carousel"">

            <ol class=""carousel-indicators""></ol>

            <div class=""carousel-inner"" role=""listbox"">

                <div class=""carousel-item active"">
                    <div class=""carousel-background""><img src=""Content/img/intro-carousel/Panda.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 473, "\"", 479, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                    <div class=""carousel-container"">
                        <div class=""carousel-caption"">
                            <h2>We are professional</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            ");
#nullable restore
#line 21 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
                       Write(Html.ActionLink("Explore", "Index", "Home", new { @class = "btn-get-started scrollto", @style = "text-decoration:none" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"carousel-item\">\r\n                    <div class=\"carousel-background\"><img src=\"Content/img/intro-carousel/Bird.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1307, "\"", 1313, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                    <div class=""carousel-container"">
                        <div class=""carousel-caption"">
                            <h2>At vero eos et accusamus</h2>
                            <p style=""text-align:left"">Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut.</p>
                            ");
#nullable restore
#line 32 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
                       Write(Html.ActionLink("Explore", "Index", "Home", new { @class = "btn-get-started scrollto", @style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"carousel-item\">\r\n                    <div class=\"carousel-background\"><img src=\"Content/img/intro-carousel/Fish.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2177, "\"", 2183, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                    <div class=""carousel-container"">
                        <div class=""carousel-caption"">
                            <h2>Temporibus autem quibusdam</h2>
                            <p>Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt omnis iste natus error sit voluptatem accusantium.</p>
                            ");
#nullable restore
#line 43 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
                       Write(Html.ActionLink("Explore", "Index", "Home", new { @class = "btn-get-started scrollto", @style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"carousel-item\">\r\n                    <div class=\"carousel-background\"><img src=\"Content/img/intro-carousel/flock.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3028, "\"", 3034, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                    <div class=""carousel-container"">
                        <div class=""carousel-caption"">
                            <h2>Nam libero tempore</h2>
                            <p>Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum.</p>
                            ");
#nullable restore
#line 54 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
                       Write(Html.ActionLink("Explore", "Index", "Home", new { @class = "btn-get-started scrollto", @style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"carousel-item\">\r\n                    <div class=\"carousel-background\"><img src=\"Content/img/intro-carousel/fox.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3866, "\"", 3872, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                    <div class=""carousel-container"">
                        <div class=""carousel-caption"">
                            <h2>Magnam aliquam quaerat</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            ");
#nullable restore
#line 65 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
                       Write(Html.ActionLink("Explore", "Index", "Home", new { @class = "btn-get-started scrollto", @style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>

            </div>

            <a class=""carousel-control-prev"" href=""#introCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon ion-chevron-left"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>

            <a class=""carousel-control-next"" href=""#introCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon ion-chevron-right"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>

        </div>
    </div>
</section><!-- End Intro Section -->

<main>


    <!-- Category Area Start-->
    <section class=""category-area section-padding30"">
        <div class=""container-fluid"">

            <nav class=""navbar navbar-expand-lg navbar-light"">


                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
");
                WriteLiteral("                    <ul class=\"navbar-nav mr-auto\" style=\"text-align:right\">\r\n\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2adb2c94005955a7ffd8a72d8de3850ee1a42a6d13655", async() => {
                    WriteLiteral("<i class=\"fas fa-shopping-cart\">Cart</i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2adb2c94005955a7ffd8a72d8de3850ee1a42a6d15324", async() => {
                    WriteLiteral("Check Out");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n\r\n                    </ul>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2adb2c94005955a7ffd8a72d8de3850ee1a42a6d16934", async() => {
                    WriteLiteral(@"
                        <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit""><i class=""fa fa-search""></i></button>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                </div>
            </nav>







            <!-- Section Tittle -->
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-tittle text-center mb-85"">
                        <h2>Shop by Category</h2>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-4 col-lg-6"">
                    <div class=""single-category mb-30"">
                        <div class=""category-img figure"">
                            <img");
                BeginWriteAttribute("src", " src=\"", 6941, "\"", 7007, 1);
#nullable restore
#line 133 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
WriteAttributeValue("", 6947, Url.Content("~/Content/assets_store/img/categori/Food.jpg"), 6947, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""figure-img img-fluid rounded"" alt="" "">
                            <div class=""caption"">
                                <h3 style=""text-align:center"">Food</h3>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-6"">
                    <div class=""single-category mb-30"">
                        <div class=""category-img text-center"">
                            <img");
                BeginWriteAttribute("src", " src=\"", 7502, "\"", 7567, 1);
#nullable restore
#line 143 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
WriteAttributeValue("", 7508, Url.Content("~/Content/assets_store/img/categori/toy.jpg"), 7508, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7568, "\"", 7574, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <div class=""caption"">
                                <h3 style=""text-align:center"">Toys</h3>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-6"">
                    <div class=""single-category mb-30"">
                        <div class=""category-img"">
                            <img");
                BeginWriteAttribute("src", " src=\"", 8012, "\"", 8082, 1);
#nullable restore
#line 153 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
WriteAttributeValue("", 8018, Url.Content("~/Content/assets_store/img/categori/giftshop.png"), 8018, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height:298px\"");
                BeginWriteAttribute("alt", " alt=\"", 8104, "\"", 8110, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <div class=""caption"">
                                <h3 style=""text-align:center"">Souvenirs</h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Category Area End-->
    <!-- Latest Products Start -->
    <section class=""latest-product-area padding-bottom"">
        <div class=""container"">
            <div class=""row product-btn d-flex justify-content-end align-items-end"">
                <!-- Section Tittle -->
                <div class=""col-xl-4 col-lg-5 col-md-5"">
                    <div class=""section-tittle mb-30"">
                        <h2>Products</h2>
                    </div>
                </div>
                <div class=""col-xl-8 col-lg-7 col-md-7"">
                    <div class=""properties__button f-right"">
                        <!--Nav Button  -->
                        <!--End Nav Button  -->
            ");
                WriteLiteral(@"        </div>
                </div>
            </div>
            <!-- Nav Card -->
            <div class=""tab-content"" id=""nav-tabContent"">
                <!-- card one -->
                <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                    <div class=""row"">
                        <div class=""col-xl-4 col-lg-4 col-md-6"">
                            <div class=""single-product mb-60"">
                                <div class=""product-img"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 9706, "\"", 9777, 1);
#nullable restore
#line 189 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
WriteAttributeValue("", 9712, Url.Content("~/Content/assets_store/img/categori/hamburger.jpg"), 9712, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 9778, "\"", 9784, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                                </div>
                                <div class=""product-caption"">

                                    <h4><a href=""#"">Hamburger</a></h4>

                                    <div class=""price"">
                                        <ul>
                                            <li>$9.00</li>

                                        </ul>
                                        <button type=""button"" class=""btn-sm btn-outline-success"" value=""submit"">Add to Cart</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6"">
                            <div class=""single-product mb-60"">
                                <div class=""product-img"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 10696, "\"", 10763, 2);
#nullable restore
#line 209 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
WriteAttributeValue("", 10702, Url.Content("~/Content/assets_store/img/categori/toys.jpg"), 10702, 60, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 10762, "", 10763, 1, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"width:360px;height:240px\"");
                BeginWriteAttribute("alt", " alt=\"", 10797, "\"", 10803, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""product-caption"">

                                    <h4><a href=""#"">Teddy Bears</a></h4>

                                    <div class=""price"">
                                        <ul>
                                            <li>$20.00</li>

                                        </ul>
                                        <button type=""button"" class=""btn-sm btn-outline-success"" value=""submit"">Add to Cart</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-6"">
                            <div class=""single-product mb-60"">
                                <div class=""product-img"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 11716, "\"", 11781, 1);
#nullable restore
#line 228 "C:\Users\Max\Desktop\clone\Databases-Project\new\ZooProjF\ZooProjF\Views\Home\ShopIndex.cshtml"
WriteAttributeValue("", 11722, Url.Content("~/Content/assets_store/img/categori/key.jpg"), 11722, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:360px;height:240px\"");
                BeginWriteAttribute("alt", " alt=\"", 11815, "\"", 11821, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <div class=""new-product"">
                                        <span>Sold Out</span>
                                    </div>
                                </div>
                                <div class=""product-caption"">

                                    <h4><a href=""#"">Animal Key Chains</a></h4>

                                    <div class=""price"">
                                        <ul>
                                            <li>$3.00</li>

                                        </ul>
                                        <button type=""button"" class=""btn-sm btn-outline-success "" value=""submit"">Add to Cart</button>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
            <!-- Card two -->
            <!-- End Nav Card -->
        </div>
    </s");
                WriteLiteral("ection>\r\n    <!-- Latest Products End -->\r\n    <!-- Best Product Start -->\r\n\r\n\r\n</main>\r\n");
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
            WriteLiteral("\r\n");
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
