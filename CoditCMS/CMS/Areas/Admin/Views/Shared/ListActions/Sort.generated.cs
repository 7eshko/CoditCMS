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
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    using DB.Entities;
    using Libs;
    
    #line 1 "..\..\Areas\Admin\Views\Shared\ListActions\Sort.cshtml"
    using CMS;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/ListActions/Sort.cshtml")]
    public partial class _Areas_Admin_Views_Shared_ListActions_Sort_cshtml : CMS.Mvc.AdminViewPage<DB.Entities.ISortableEntity>
    {
        public _Areas_Admin_Views_Shared_ListActions_Sort_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SortListItems.Index\"");

WriteAttribute("value", Tuple.Create(" value=\"", 109), Tuple.Create("\"", 126)
            
            #line 4 "..\..\Areas\Admin\Views\Shared\ListActions\Sort.cshtml"
, Tuple.Create(Tuple.Create("", 117), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 117), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 152), Tuple.Create("\"", 186)
, Tuple.Create(Tuple.Create("", 159), Tuple.Create("SortListItems[", 159), true)
            
            #line 5 "..\..\Areas\Admin\Views\Shared\ListActions\Sort.cshtml"
, Tuple.Create(Tuple.Create("", 173), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 173), false)
, Tuple.Create(Tuple.Create("", 182), Tuple.Create("].Id", 182), true)
);

WriteAttribute("value", Tuple.Create(" value=\"", 187), Tuple.Create("\"", 204)
            
            #line 5 "..\..\Areas\Admin\Views\Shared\ListActions\Sort.cshtml"
, Tuple.Create(Tuple.Create("", 195), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 195), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"text\"");

WriteAttribute("name", Tuple.Create(" name=\"", 228), Tuple.Create("\"", 264)
, Tuple.Create(Tuple.Create("", 235), Tuple.Create("SortListItems[", 235), true)
            
            #line 6 "..\..\Areas\Admin\Views\Shared\ListActions\Sort.cshtml"
, Tuple.Create(Tuple.Create("", 249), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 249), false)
, Tuple.Create(Tuple.Create("", 258), Tuple.Create("].Sort", 258), true)
);

WriteLiteral(" class=\"sort\"");

WriteAttribute("value", Tuple.Create(" value=\"", 278), Tuple.Create("\"", 297)
            
            #line 6 "..\..\Areas\Admin\Views\Shared\ListActions\Sort.cshtml"
, Tuple.Create(Tuple.Create("", 286), Tuple.Create<System.Object, System.Int32>(Model.Sort
            
            #line default
            #line hidden
, 286), false)
);

WriteLiteral(" />\r\n");

        }
    }
}
#pragma warning restore 1591
