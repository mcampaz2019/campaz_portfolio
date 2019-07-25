#pragma checksum "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6cde94e2b73e3b8a32b818237a16e5301bee61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6cde94e2b73e3b8a32b818237a16e5301bee61", @"/Views/Home/Contact.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
  
    var location = new List<string>(){
        "Berkeley, CA",
        "Boise, ID",
        "Chicago, IL",
        "Dallas, TX",
        "Los Angeles, CA",
        "Orange County, CA",
        "Seattle, WA",
        "Silicon Valley, CA",
        "Tulsa, OK",
        "Tysons Corner, VA",
        "Online"
    };
    var language = new List<string>(){
        "C",
        "C++",
        "C#",
        "Objective C",
        "Java",
        "Basic",
        "JavaScript",
        "Python",
        "Scala",
        "Go",
        "Swift",
        "Ruby"
    };

#line default
#line hidden
            BeginContext(593, 299, true);
            WriteLiteral(@"<!DOCTYPE html>
<!--[if lt IE 7]>      <html class=""no-js lt-ie9 lt-ie8 lt-ie7""> <![endif]-->
<!--[if IE 7]>         <html class=""no-js lt-ie9 lt-ie8""> <![endif]-->
<!--[if IE 8]>         <html class=""no-js lt-ie9""> <![endif]-->
<!--[if gt IE 8]><!--> <html class=""no-js""> <!--<![endif]-->
    ");
            EndContext();
            BeginContext(892, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb970dd05794ab5be25324746a80aee", async() => {
                BeginContext(898, 308, true);
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <title>Portfolio Contact</title>
        <meta name=""description"" content="""">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <link rel=""stylesheet"" href="""">
    ");
                EndContext();
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
            EndContext();
            BeginContext(1213, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1219, 7510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee1470aa99014b8482866a29ac0df5cb", async() => {
                BeginContext(1225, 29, true);
                WriteLiteral("\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(1255, 26, false);
#line 45 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
       Write(Html.Partial("Navigation"));

#line default
#line hidden
                EndContext();
                BeginContext(1281, 5683, true);
                WriteLiteral(@";
        </div>
        <!--[if lt IE 7]>
            <p class=""browsehappy"">You are using an <strong>outdated</strong> browser. Please <a href=""#"">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
        <div class=""row""><div class=""col-1""></div>
        <div class=""card border-dark mb-3 col-10"" >                
            <div class=""card-body"">        
                <div class=""jumbotron jumbotron-sm"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-sm-10 col-lg-10"">
                                <h1 class=""h1"">
                                    Contact me! <small>Feel free to contact me!</small></h1>
                            </div>
                        </div>
                    </div>
                </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8"">
                        <div class=""well w");
                WriteLiteral(@"ell-sm"">
                            <form>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""name"">
                                            Name</label>
                                        <input type=""text"" class=""form-control"" id=""name"" placeholder=""Enter name"" required=""required"" />
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""email"">
                                            Email Address</label>
                                        <div class=""input-group"">
                                            <span class=""input-group-addon""><span class=""glyphicon glyphicon-envelope""></span>
                                            </span>
                                            <input type=""email"" class=""for");
                WriteLiteral(@"m-control"" id=""email"" placeholder=""Enter email"" required=""required"" /></div>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""subject"">
                                            Subject</label>
                                        <select id=""subject"" name=""subject"" class=""form-control"" required=""required"">
                                            <option value=""na"" selected="""">Choose One:</option>
                                            <option value=""service"">General Customer Service</option>
                                            <option value=""suggestions"">Suggestions</option>
                                            <option value=""product"">Product Support</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                  ");
                WriteLiteral(@"                  <div class=""form-group"">
                                        <label for=""name"">
                                            Message</label>
                                        <textarea name=""message"" id=""message"" class=""form-control"" rows=""9"" cols=""25"" required=""required""
                                            placeholder=""Message""></textarea>
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <button type=""submit"" class=""btn btn-primary pull-right"" id=""btnContactUs"">
                                        Send Message</button>
                                </div>
                            </div>
                            </form>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <form>
                        <legend><span class=""glyphicon glyphicon-globe""></s");
                WriteLiteral(@"pan> Mario Campaz</legend>
                        <address>
                            <strong>Address</strong><br>
                            555 Folsom Ave, Suite 555<br>
                            San Francisco, CA 94555<br>
                            <abbr title=""Phone"">
                                P:</abbr>
                            (555) 555-5555
                        </address>
                        <address>
                            <strong>Mario Diaz Campaz</strong><br>
                            <a href=""mailto:#"">first.last@example.com</a>
                        </address>
                        </form>
                    </div>
                </div>
            </div>
            </div>
        </div>
        </div>
        <div class=""row"">
            <div class=""col-2""></div>    
            <div class=""card border-primary mb-4 col-6"" >                
                <div class=""card-body"">
                                <!-- Default form contact");
                WriteLiteral(@" -->
                    <form class=""text-center border border-light p-5"" action=""DojoSurvey"" method=""post"">

                        <p class=""h4 mb-4"">Dojo Survey Index</p>

                        <!-- Name -->
                        <input type=""text"" id=""defaultContactFormName"" class=""form-control mb-4"" name=""name""  required=""required"" placeholder=""Name"">

                        <!-- Subject -->
                        <label>Dojo Location</label>
                        <select class=""browser-default custom-select mb-4"" name=""location"">
");
                EndContext();
#line 147 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                              
                                for(int i = 0; i < location.Count; i++){
                                    if(i == 0){

#line default
#line hidden
                BeginContext(7119, 47, true);
                WriteLiteral("                                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7166, "\"", 7176, 1);
#line 150 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
WriteAttributeValue("", 7174, i, 7174, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7177, 11, true);
                WriteLiteral(" selected >");
                EndContext();
                BeginContext(7189, 11, false);
#line 150 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                                                Write(location[i]);

#line default
#line hidden
                EndContext();
                BeginContext(7200, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 151 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                    }

#line default
#line hidden
                BeginContext(7250, 43, true);
                WriteLiteral("                                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7293, "\"", 7303, 1);
#line 152 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
WriteAttributeValue("", 7301, i, 7301, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7304, 2, true);
                WriteLiteral(" >");
                EndContext();
                BeginContext(7307, 11, false);
#line 152 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                                   Write(location[i]);

#line default
#line hidden
                EndContext();
                BeginContext(7318, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 153 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                }
                            

#line default
#line hidden
                BeginContext(7395, 240, true);
                WriteLiteral("                        </select>\r\n\r\n                        <!-- Favorite Language -->\r\n                        <label>Favorite Language</label>\r\n                        <select class=\"browser-default custom-select mb-4\" name=\"language\">\r\n");
                EndContext();
#line 160 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                              
                                for(int i = 0; i < language.Count; i++){
                                    if(i == 0){

#line default
#line hidden
                BeginContext(7790, 47, true);
                WriteLiteral("                                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7837, "\"", 7847, 1);
#line 163 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
WriteAttributeValue("", 7845, i, 7845, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7848, 11, true);
                WriteLiteral(" selected >");
                EndContext();
                BeginContext(7860, 11, false);
#line 163 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                                                Write(language[i]);

#line default
#line hidden
                EndContext();
                BeginContext(7871, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 164 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                    }

#line default
#line hidden
                BeginContext(7921, 43, true);
                WriteLiteral("                                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7964, "\"", 7974, 1);
#line 165 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
WriteAttributeValue("", 7972, i, 7972, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7975, 2, true);
                WriteLiteral(" >");
                EndContext();
                BeginContext(7978, 11, false);
#line 165 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                                   Write(language[i]);

#line default
#line hidden
                EndContext();
                BeginContext(7989, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 166 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
                                }
                            

#line default
#line hidden
                BeginContext(8066, 604, true);
                WriteLiteral(@"                        </select>

                        <!-- Message -->
                        <div class=""form-group"">
                            <textarea class=""form-control rounded-0"" name=""message"" id=""exampleFormControlTextarea2"" rows=""5"" placeholder=""Comment (Optional): ""></textarea>
                        </div>

                        <!-- Send button -->
                        <button class=""btn btn-info btn-block col-2 "" type=""submit"">Send</button>

                    </form>
                </div>
            </div>    
        </div>
        <div>
            ");
                EndContext();
                BeginContext(8671, 28, false);
#line 183 "C:\DotNetDev\Projects\Portfolio\campaz_portfolio\dotnet_portfolio\Views\Home\Contact.cshtml"
       Write(Html.Partial("FooterScript"));

#line default
#line hidden
                EndContext();
                BeginContext(8699, 23, true);
                WriteLiteral(";\r\n        </div>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(8729, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
