#pragma checksum "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9650494bef78da0b361674aab0675c2fd6fb309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Index), @"mvc.1.0.view", @"/Views/Tasks/Index.cshtml")]
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
#line 1 "F:\Projects\Scheduler\Scheduler\Views\_ViewImports.cshtml"
using Scheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Scheduler\Scheduler\Views\_ViewImports.cshtml"
using Scheduler.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Scheduler\Scheduler\Views\_ViewImports.cshtml"
using Scheduler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9650494bef78da0b361674aab0675c2fd6fb309", @"/Views/Tasks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e73ba902a22480c66fe132e33e47490f84d6910", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyScheduleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tasks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info col-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
  
    ViewData["Title"] = "My Schedule";
    var currentMonth = Model.CurrentDateTime.ToString("MMMM");
    int daysOfCurrentMonth = Calender.Lib.Calender.GetMonthDayCount(currentMonth);
    int tasksCounter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-3\" id=\"calender\">\r\n\r\n    <div class=\"row\">\r\n        <h3 class=\"col-5\">My Schedule</h3>\r\n        <h3 class=\"col-3\">\r\n            <span id=\"month\">");
#nullable restore
#line 14 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                        Write(Model.CurrentDateTime.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>");
#nullable restore
#line 15 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
             Write(Model.CurrentDateTime.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9650494bef78da0b361674aab0675c2fd6fb3095228", async() => {
                WriteLiteral("Add Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <button class=\"col-1 font-weight-bold btn btn-default\" style=\"font-size: 20px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 784, "\"", 852, 5);
            WriteAttributeValue("", 794, "getPrevMonth(\'", 794, 14, true);
#nullable restore
#line 21 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 808, currentMonth, 808, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 821, "\',", 821, 2, true);
#nullable restore
#line 21 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue(" ", 823, Model.CurrentDateTime.Year, 824, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 851, ")", 851, 1, true);
            EndWriteAttribute();
            WriteLiteral("><</button>\r\n        <div class=\"container row col-10\">\r\n");
#nullable restore
#line 23 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
             for (int i = 1; i <= daysOfCurrentMonth; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                 if (i == Model.CurrentDateTime.Day)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"day-box col-2 today\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1111, "\"", 1159, 8);
            WriteAttributeValue("", 1121, "show(", 1121, 5, true);
#nullable restore
#line 27 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 1126, i, 1126, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1128, ",", 1128, 1, true);
            WriteAttributeValue(" ", 1129, "\'", 1130, 2, true);
#nullable restore
#line 27 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 1131, currentMonth, 1131, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1144, "\',", 1144, 2, true);
#nullable restore
#line 27 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue(" ", 1146, Model.Year, 1147, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1158, ")", 1158, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 28 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                         if (tasksCounter < Model.Tasks.Count())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                             if (i == Model.Tasks[tasksCounter].CreationTime.Value.Day)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> - ");
#nullable restore
#line 33 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                                    Write(Model.Tasks[tasksCounter].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 34 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n");
#nullable restore
#line 37 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"day-box col-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1680, "\"", 1728, 8);
            WriteAttributeValue("", 1690, "show(", 1690, 5, true);
#nullable restore
#line 40 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 1695, i, 1695, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1697, ",", 1697, 1, true);
            WriteAttributeValue(" ", 1698, "\'", 1699, 2, true);
#nullable restore
#line 40 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 1700, currentMonth, 1700, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1713, "\',", 1713, 2, true);
#nullable restore
#line 40 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue(" ", 1715, Model.Year, 1716, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1727, ")", 1727, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 41 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                         if (tasksCounter < Model.Tasks.Count())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                             if (i == Model.Tasks[tasksCounter].CreationTime.Value.Day)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> - ");
#nullable restore
#line 46 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                                    Write(Model.Tasks[tasksCounter].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>                    \r\n");
#nullable restore
#line 50 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                 if (tasksCounter < Model.Tasks.Count())
                {
                    if (Model.Tasks[tasksCounter].CreationTime.Value.Day <= i)
                    {
                        tasksCounter++;
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <button class=\"col-1 font-weight-bold btn btn-default\" style=\"font-size: 20px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2562, "\"", 2630, 5);
            WriteAttributeValue("", 2572, "getNextMonth(\'", 2572, 14, true);
#nullable restore
#line 60 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 2586, currentMonth, 2586, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2599, "\',", 2599, 2, true);
#nullable restore
#line 60 "F:\Projects\Scheduler\Scheduler\Views\Tasks\Index.cshtml"
WriteAttributeValue(" ", 2601, Model.CurrentDateTime.Year, 2602, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2629, ")", 2629, 1, true);
            EndWriteAttribute();
            WriteLiteral(">></button>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("calScript", async() => {
                WriteLiteral(@" 
    <script>
        function show(i, currentMonth, year) {
            location.replace(`/Tasks/Details?day=${i}&month=${currentMonth}&year=${year}`);
        }
        const calContainer = document.querySelector('#calender');        
        function getNextMonth(currentMonth, year) {
            $.ajax({
                url: ""/Tasks/NextMonth?current="" + currentMonth + ""&year="" + year,
                success: function (response) {
                    calContainer.innerHTML = response;                    
                }
            })
        }
        function getPrevMonth(currentMonth, year) {
            $.ajax({
                url: ""/Tasks/PrevMonth?current="" + currentMonth +""&year="" + year,
                success: function (response) {
                    calContainer.innerHTML = response;
                }
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyScheduleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591