#pragma checksum "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "def69a892aebf5d29e27eadba5986dd05f6abd1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cognitive_Search_Solution_Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Cognitive_Search_Solution_Web.Pages
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
#line 1 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\_ViewImports.cshtml"
using Cognitive_Search_Solution_Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def69a892aebf5d29e27eadba5986dd05f6abd1b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d779f8a2af9d7399fd2ee26762c1d515f48d21ca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "search.score()", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "metadata_storage_name asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "metadata_storage_size desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "metadata_storage_last_modified desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "sentiment desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "Margie's Travel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4\">Search</h1>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def69a892aebf5d29e27eadba5986dd05f6abd1b5879", async() => {
                WriteLiteral("\r\n        <input name=\"search\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 214, "\"", 240, 1);
#nullable restore
#line 13 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
WriteAttributeValue("", 222, Model.SearchTerms, 222, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input name=\"submit\" type=\"submit\" value=\"Search\" />\r\n        <p>");
#nullable restore
#line 15 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
      Write(Model.SearchTerms);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 20 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Get))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <input name=\"search\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 475, "\"", 501, 1);
#nullable restore
#line 23 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
WriteAttributeValue("", 483, Model.SearchTerms, 483, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 25 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
             if (Model.search_results != null)
            {
                // Show the result count.

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
#nullable restore
#line 31 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
               Write(Html.DisplayFor(m => m.search_results.TotalCount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Results\r\n                </p>\r\n");
#nullable restore
#line 33 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"

                // Create author filter options
                List<string> authors = Model.search_results.Facets["metadata_author"].Select(x => x.Value.ToString()).ToList();
                if (authors.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"filterTitle\">Filter by author:</p>\r\n");
#nullable restore
#line 39 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                     for (var c = 0; c < authors.Count; c++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><input name=\"facet\"");
            BeginWriteAttribute("value", " value=\"", 1216, "\"", 1235, 1);
#nullable restore
#line 41 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
WriteAttributeValue("", 1224, authors[c], 1224, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"> ");
#nullable restore
#line 41 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                                                              Write(authors[c]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 42 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                     
                }

                // Create sort list

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"sortList\">\r\n                    Sort by: <select id=\"sort\" name=\"sort\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def69a892aebf5d29e27eadba5986dd05f6abd1b12463", async() => {
                WriteLiteral("Relevance");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
AddHtmlAttributeValue("", 1518, Model.SortOrder == "search.score()", 1518, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def69a892aebf5d29e27eadba5986dd05f6abd1b14189", async() => {
                WriteLiteral("File name");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
AddHtmlAttributeValue("", 1654, Model.SortOrder == "metadata_storage_name asc", 1654, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def69a892aebf5d29e27eadba5986dd05f6abd1b15926", async() => {
                WriteLiteral("Largest file size");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
AddHtmlAttributeValue("", 1802, Model.SortOrder == "metadata_storage_size desc", 1802, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def69a892aebf5d29e27eadba5986dd05f6abd1b17672", async() => {
                WriteLiteral("Most recently modified");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
AddHtmlAttributeValue("", 1968, Model.SortOrder == "metadata_storage_last_modified desc", 1968, 59, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def69a892aebf5d29e27eadba5986dd05f6abd1b19432", async() => {
                WriteLiteral("Positive to negative");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
AddHtmlAttributeValue("", 2127, Model.SortOrder == "sentiment desc", 2127, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </p>\r\n                <input name=\"refine\" type=\"submit\" value=\"Refine Results\" class=\"refineButton\"></input>\r\n");
#nullable restore
#line 57 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"

                // Display search results
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                 foreach (var result in Model.search_results.GetResults())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"result\">\r\n                        <p class=\"resultLink\"><a");
            BeginWriteAttribute("href", " href=\"", 2586, "\"", 2613, 1);
#nullable restore
#line 62 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
WriteAttributeValue("", 2593, result.Document.url, 2593, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 62 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                                                                        Write(result.Document.metadata_storage_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 63 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                         if (result.Highlights != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                             foreach (var highlight in result.Highlights)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                 foreach (var val in highlight.Value)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\'resultExtract\'>");
#nullable restore
#line 69 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                                          Write(Html.Raw(val));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 70 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"resultAttributes\">\r\n                            <li>Author: ");
#nullable restore
#line 74 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                   Write(result.Document.metadata_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>Language: ");
#nullable restore
#line 75 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                     Write(result.Document.language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>Size: ");
#nullable restore
#line 76 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                 Write(result.Document.metadata_storage_size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bytes</li>\r\n                            <li>Modified: ");
#nullable restore
#line 77 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                     Write(result.Document.metadata_storage_last_modified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>\r\n                                Sentiment: ");
#nullable restore
#line 79 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                            if (result.Document.sentiment >= 0.5)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                               Write(Html.Raw("&#128578;"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                                          
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                               Write(Html.Raw("&#128577"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                                         
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 87 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                           Write(result.Document.sentiment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 89 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                             if (result.Document.keyphrases != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>Key Phrases:</li>\r\n                                <ul class=\"resultAttributes\">\r\n");
#nullable restore
#line 93 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                     foreach (var key_phrase in result.Document.keyphrases.Take(5))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 95 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                       Write(key_phrase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 96 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n");
#nullable restore
#line 98 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                             if (result.Document.locations != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>Locations:</li>\r\n                                <ul class=\"resultAttributes\">\r\n");
#nullable restore
#line 103 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                     foreach (var location in result.Document.locations.Take(5))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 105 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                       Write(location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 106 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n");
#nullable restore
#line 108 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                             if (result.Document.imageTags != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>Image Tags:</li>\r\n                                <ul class=\"resultAttributes\">\r\n");
#nullable restore
#line 113 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                     foreach (var tag in result.Document.imageTags.Take(5))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 115 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                       Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 116 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n");
#nullable restore
#line 118 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <hr />\r\n                    </div>\r\n");
#nullable restore
#line 122 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><img src=\"images/margies.jpg\" /></div>\r\n");
#nullable restore
#line 128 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\olowoyinka\source\repos\AI Engineer\Worked\Cognitive_Search_Solution_Web\Cognitive_Search_Solution_Web\Pages\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
