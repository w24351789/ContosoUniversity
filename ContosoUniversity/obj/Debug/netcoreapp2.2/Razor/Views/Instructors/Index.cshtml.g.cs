#pragma checksum "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Index.cshtml", typeof(AspNetCore.Views_Instructors_Index))]
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
#line 1 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.SchoolViewModels.InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructor";

#line default
#line hidden
            BeginContext(118, 34, true);
            WriteLiteral("\r\n<h1>Instructor</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(152, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed5119", async() => {
                BeginContext(175, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(189, 279, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 24 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Instructors)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["InstructorID"])
            {
                selectedRow = "table-success";
            }



#line default
#line hidden
            BeginContext(709, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 724, "\"", 744, 1);
#line 33 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 732, selectedRow, 732, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(745, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(791, 43, false);
#line 35 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(834, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(902, 47, false);
#line 38 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(949, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1017, 43, false);
#line 41 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 44 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                     if (item.OfficeAssignment != null)
                    {
                        

#line default
#line hidden
            BeginContext(1212, 30, false);
#line 46 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                   Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 46 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                                       
                    }

#line default
#line hidden
            BeginContext(1267, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 50 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                      
                        foreach (var course in item.CourseAssignments)
                        {
                            

#line default
#line hidden
            BeginContext(1464, 22, false);
#line 53 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                       Write(course.Course.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(1486, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1489, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1491, 19, false);
#line 53 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                                  Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 54 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1569, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1634, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed11390", async() => {
                BeginContext(1680, 7, true);
                WriteLiteral(" Select");
                EndContext();
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
#line 58 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1691, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1715, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed13758", async() => {
                BeginContext(1760, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1768, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1792, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed16122", async() => {
                BeginContext(1840, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1851, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1875, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ec4df6f2237c4187aa57fbb8d80084bb0d77ed18492", async() => {
                BeginContext(1922, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1932, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1987, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 68 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
            BeginContext(2045, 223, true);
            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Number</th>\r\n            <th>Title</th>\r\n            <th>Department</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 79 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == (int?)ViewData["CourseID"])
            {
                selectedRow = "table-success";
            }

#line default
#line hidden
            BeginContext(2503, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2518, "\"", 2538, 1);
#line 86 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 2526, selectedRow, 2526, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2539, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2585, 68, false);
#line 88 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.ActionLink("Select", "Index", new { courseID = item.CourseID }));

#line default
#line hidden
            EndContext();
            BeginContext(2653, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2721, 13, false);
#line 91 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(2734, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2802, 10, false);
#line 94 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2812, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2880, 20, false);
#line 97 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2900, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 100 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2955, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 103 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2974, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 105 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
 if (Model.Enrollments != null)
{

#line default
#line hidden
            BeginContext(3012, 178, true);
            WriteLiteral("    <h3>\r\n        Students Enrolled in Selected Course\r\n    </h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
            EndContext();
#line 115 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
            BeginContext(3251, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3312, 21, false);
#line 119 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3333, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3401, 40, false);
#line 122 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3441, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 125 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3496, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 127 "C:\Users\atwta\Desktop\ContosoUniversity\ContosoUniversity\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
