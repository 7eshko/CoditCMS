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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/ListActions/Delete.cshtml")]
    public partial class _Areas_Admin_Views_Shared_ListActions_Delete_cshtml : CMS.Mvc.AdminViewPage<dynamic>
    {
        public _Areas_Admin_Views_Shared_ListActions_Delete_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<a");

WriteLiteral(" class=\"list-action\"");

WriteLiteral(" onclick=\"if(!confirm(\'Удалить объект?\')) return false;\"");

WriteAttribute("href", Tuple.Create(" href=\"", 78), Tuple.Create("\"", 143)
            
            #line 1 "..\..\Areas\Admin\Views\Shared\ListActions\Delete.cshtml"
       , Tuple.Create(Tuple.Create("", 85), Tuple.Create<System.Object, System.Int32>(Url.Action(Constants.DeleteAction, new { id = Model.Id })
            
            #line default
            #line hidden
, 85), false)
);

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 149), Tuple.Create("\"", 237)
            
            #line 1 "..\..\Areas\Admin\Views\Shared\ListActions\Delete.cshtml"
                                                                             , Tuple.Create(Tuple.Create("", 155), Tuple.Create<System.Object, System.Int32>( CMS.PagesSettings.Settings.MediaRoot +"/Areas/Admin/Images/Default/delete.png"
            
            #line default
            #line hidden
, 155), false)
);

WriteLiteral(" alt=\"Удалить\"");

WriteLiteral(" /></a>");

        }
    }
}
#pragma warning restore 1591
