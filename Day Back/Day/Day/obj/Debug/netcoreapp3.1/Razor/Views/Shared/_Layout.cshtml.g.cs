#pragma checksum "C:\Users\tu7kswf4d\Desktop\Day Back\Day\Day\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eabbccf27d6438c31b45d070d20e2fcc3433fa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\tu7kswf4d\Desktop\Day Back\Day\Day\Views\_ViewImports.cshtml"
using Day;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7kswf4d\Desktop\Day Back\Day\Day\Views\_ViewImports.cshtml"
using Day.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7kswf4d\Desktop\Day Back\Day\Day\Views\_ViewImports.cshtml"
using Day.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eabbccf27d6438c31b45d070d20e2fcc3433fa2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d914c566540037ea1e648c20fdfadc1016f3c69", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eabbccf27d6438c31b45d070d20e2fcc3433fa24623", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6eabbccf27d6438c31b45d070d20e2fcc3433fa25064", async() => {
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
                WriteLiteral("\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\"\r\n          integrity=\"sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC\" crossorigin=\"anonymous\">\r\n");
                WriteLiteral(@"    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js""
            integrity=""sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF""
            crossorigin=""anonymous""></script>
    <link rel=""stylesheet""
          href=""https://maxst.icons8.com/vue-static/landings/line-awesome/line-awesome/1.3.0/css/line-awesome.min.css"">
    <title>Day</title>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eabbccf27d6438c31b45d070d20e2fcc3433fa27642", async() => {
                WriteLiteral(@"
    <header>
        <div class=""container d-flex justify-content-between pt-2 pb-2"">
            <div class=""contact d-flex gap-3"">
                <a href=""#"" class=""text-white d-flex gap-1 align-items-baseline"">
                    <i class=""las la-envelope""></i>info@example.com
                </a>
                <span class=""text-white d-flex gap-1 align-items-baseline"">
                    <i class=""las la-mobile""></i>+1 5589 55488
                    55
                </span>
            </div>
            <div class=""social d-flex gap-3"">
                <i class=""lab la-twitter""></i>
                <i class=""lab la-facebook""></i>
                <i class=""lab la-instagram""></i>
                <i class=""lab la-linkedin""></i>
            </div>
        </div>
        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
            <div class=""container-fluid"">
                <div class=""container d-flex"">
                    <a class=""navbar-brand"" href=""#"">DAY</a>
   ");
                WriteLiteral(@"                 <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                            data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                            aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav me-auto mb-2 mb-lg-0 gap-3"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">About</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Services</a>
             ");
                WriteLiteral(@"               </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Portfolio</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Pricing</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Team</a>
                            </li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button""
                                   data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    Dropdown
                                </a>
                                <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                    <li><a class=""dropdown-item"" href=""#"">Dropdown 1</a><");
                WriteLiteral(@"/li>
                                    <li><a class=""dropdown-item"" href=""#"">Dropdown 2</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Dropdown 3</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Dropdown 4</a></li>
                                </ul>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Contact</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </nav>
    </header>
    ");
#nullable restore
#line 91 "C:\Users\tu7kswf4d\Desktop\Day Back\Day\Day\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer class=""site-footer mt-5"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-6"">
                    <h6>About</h6>
                    <p class=""text-justify"">Scanfcode.com <i>CODE WANTS TO BE SIMPLE </i> is an initiative  to help the upcoming programmers with the code. Scanfcode focuses on providing the most efficient code or snippets as the code wants to be simple. We will help programmers build up concepts in different programming languages that include C, C++, Java, HTML, CSS, Bootstrap, JavaScript, PHP, Android, SQL and Algorithm.</p>
                </div>

                <div class=""col-xs-6 col-md-3"">
                    <h6>Categories</h6>
                    <ul class=""footer-links"">
                        <li><a href=""http://scanfcode.com/category/c-language/"">C</a></li>
                        <li><a href=""http://scanfcode.com/category/front-end-development/"">UI Design</a></li>
                        <li><a hr");
                WriteLiteral(@"ef=""http://scanfcode.com/category/back-end-development/"">PHP</a></li>
                        <li><a href=""http://scanfcode.com/category/java-programming-language/"">Java</a></li>
                        <li><a href=""http://scanfcode.com/category/android/"">Android</a></li>
                        <li><a href=""http://scanfcode.com/category/templates/"">Templates</a></li>
                    </ul>
                </div>

                <div class=""col-xs-6 col-md-3"">
                    <h6>Quick Links</h6>
                    <ul class=""footer-links"">
                        <li><a href=""http://scanfcode.com/about/"">About Us</a></li>
                        <li><a href=""http://scanfcode.com/contact/"">Contact Us</a></li>
                        <li><a href=""http://scanfcode.com/contribute-at-scanfcode/"">Contribute</a></li>
                        <li><a href=""http://scanfcode.com/privacy-policy/"">Privacy Policy</a></li>
                        <li><a href=""http://scanfcode.com/sitemap/"">Sitemap</a>");
                WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
            <hr>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 col-sm-6 col-xs-12"">
                    <p class=""copyright-text"">
                        Copyright &copy; 2017 All Rights Reserved by
                        <a href=""#"">Scanfcode</a>.
                    </p>
                </div>

            </div>
        </div>
    </footer>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eabbccf27d6438c31b45d070d20e2fcc3433fa214767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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