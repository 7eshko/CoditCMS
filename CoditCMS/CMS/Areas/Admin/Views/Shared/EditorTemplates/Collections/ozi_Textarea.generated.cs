﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CMS.Mvc;
    
    #line 1 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
    using CMS.PagesSettings.Forms;
    
    #line default
    #line hidden
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    using DB.Entities;
    using Libs;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
    using CMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/EditorTemplates/Collections/ozi_Textarea.cshtml")]
    public partial class _Areas_Admin_Views_Shared_EditorTemplates_Collections_ozi_Textarea_cshtml : CMS.Mvc.AdminViewPage<TextareaSettings>
    {
        public _Areas_Admin_Views_Shared_EditorTemplates_Collections_ozi_Textarea_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
  
    var bind = string.Format("{{text: {0}, attr: {{ name: generateName() + '.{0}' }}}}", Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n<textarea \r\n    ");

            
            #line 8 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
Write(Html.Raw(string.Format("data-bind=\"{0}\"", bind) ));

            
            #line default
            #line hidden
WriteLiteral(" \r\n    class=\"ozi-textarea\" \r\n");

            
            #line 10 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
     if (Model.Rows != 0) {
            
            #line default
            #line hidden
WriteLiteral(" rows=\"");

            
            #line 10 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
                                   Write(Model.Rows);

            
            #line default
            #line hidden
WriteLiteral("\" ");

            
            #line 10 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
                                                            } else {
            
            #line default
            #line hidden
WriteLiteral(" rows=\"10\" ");

            
            #line 10 "..\..\Areas\Admin\Views\Shared\EditorTemplates\Collections\ozi_Textarea.cshtml"
                                                                                            }
            
            #line default
            #line hidden
WriteLiteral("></textarea>");

        }
    }
}
#pragma warning restore 1591