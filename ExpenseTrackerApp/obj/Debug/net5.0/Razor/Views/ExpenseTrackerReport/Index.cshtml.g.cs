#pragma checksum "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec46d7b197186383885661f4cd3e56b1e734dde3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExpenseTrackerReport_Index), @"mvc.1.0.view", @"/Views/ExpenseTrackerReport/Index.cshtml")]
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
#line 1 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\_ViewImports.cshtml"
using ExpenseTrackerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\_ViewImports.cshtml"
using ExpenseTrackerApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\_ViewImports.cshtml"
using ExpenseTrackerWebApp.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec46d7b197186383885661f4cd3e56b1e734dde3", @"/Views/ExpenseTrackerReport/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf048d8ea6384e12724599a2f19e6e8adc697d6", @"/Views/_ViewImports.cshtml")]
    public class Views_ExpenseTrackerReport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExpenseTrackerWebApp.Data.Models.ExpenseReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ExpenseTrackerReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec46d7b197186383885661f4cd3e56b1e734dde36512", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec46d7b197186383885661f4cd3e56b1e734dde37626", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec46d7b197186383885661f4cd3e56b1e734dde38665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""//cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.8.0/js/bootstrap-datepicker.js""></script>
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.8.0/css/bootstrap-datepicker.css"" rel=""stylesheet"">

<h2>Personal Expense Manager</h2>
<br />
<div>
    <div style=""float:left"">
        <button class=""btn btn-primary"" onclick=""AddEditExpenses(0)"">Add Expense</button>
        <button class=""btn btn-success"" onclick=""ReportExpense()"">Expense Report</button>
    </div>
    <div style=""float:right; width:40%;"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec46d7b197186383885661f4cd3e56b1e734dde310287", async() => {
                WriteLiteral(@"
            <div class=""col-sm-6 float-left"">
                <input class=""form-control"" type=""text"" name=""SearchString"" placeholder=""Search"">
            </div>
            <button type=""submit"" class=""btn btn-default btn-info"">Filter</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 35 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 36 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 37 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 38 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 39 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpenseCategory.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Action Item</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpenseCategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2289, "\"", 2328, 3);
            WriteAttributeValue("", 2299, "AddEditExpenses(", 2299, 16, true);
#nullable restore
#line 53 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
WriteAttributeValue("", 2315, item.ItemId, 2315, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2327, ")", 2327, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2395, "\"", 2432, 3);
            WriteAttributeValue("", 2405, "DeleteExpense(", 2405, 14, true);
#nullable restore
#line 54 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
WriteAttributeValue("", 2419, item.ItemId, 2419, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2431, ")", 2431, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Sakhawat\source\repos\ExpenseTrackerApp\ExpenseTrackerApp\Views\ExpenseTrackerReport\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""expenseFormModel"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 id=""title"" class=""modal-title"">Add Expense</h3>
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
            </div>
            <div class=""modal-body"" id=""expenseFormModelDiv"">
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""expenseReportModal"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"">Expense Report</h3>
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
            </div>
            <div class=""modal-body"" id=""expenseReportModalDiv"">
            </div>
        </div>
    </div>
</div>

<script>

    var AddEditExpenses = function (itemId) {
        var url = ""/");
            WriteLiteral(@"ExpenseTrackerReport/AddEditExpenses?itemId="" + itemId;
        if (itemId > 0)
            $('#title').html(""Edit Expense"");

        $(""#expenseFormModelDiv"").load(url, function () {
            $(""#expenseFormModel"").modal(""show"");

        });

        $('#expenseFormModel').on('shown.bs.modal', function () {

            $('#calender-container .input-group.date').datepicker({
                todayBtn: true,
                calendarWeeks: true,
                todayHighlight: true,
                autoclose: true,
                container: '#expenseFormModel modal-body'
            });
        });
    }

    var ReportExpense = function () {
        var url = ""/ExpenseTrackerReport/ExpenseSummary"";

        $(""#expenseReportModalDiv"").load(url, function () {
            $(""#expenseReportModal"").modal(""show"");
        })
    }

    var DeleteExpense = function (itemId) {

        var ans = confirm(""Do you want to delete item with Item Id: "" + itemId);
        if (ans) {
  ");
            WriteLiteral(@"          $.ajax({
                type: ""POST"",
                url: ""/ExpenseTrackerReport/Delete/"" + itemId,
                success: function () {
                    window.location.href = ""/ExpenseTrackerReport/Index"";
                }
            })
        }
    }
</script>

<script>

    $('body').on('click', ""#btnSubmit"", function () {
        var myformdata = $(""#expenseForm"").serialize();

        $.ajax({
            type: ""POST"",
            url: ""/ExpenseTrackerReport/Create"",
            data: myformdata,
            success: function () {
                $(""#myModal"").modal(""hide"");
                window.location.href = ""/ExpenseTrackerReport/Index"";
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        })
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExpenseTrackerWebApp.Data.Models.ExpenseReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591