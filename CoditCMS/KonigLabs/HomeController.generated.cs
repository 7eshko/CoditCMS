// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace KonigLabs.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Member()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Member);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Project()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Project);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Article()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Article);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Projects()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Projects);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Contact()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Contact);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult BlogPost()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogPost);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Blog()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Blog);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Comment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Comment);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Member = "Member";
            public readonly string Project = "Project";
            public readonly string Article = "Article";
            public readonly string Projects = "Projects";
            public readonly string Contact = "Contact";
            public readonly string BlogPost = "BlogPost";
            public readonly string Blog = "Blog";
            public readonly string Comment = "Comment";
            public readonly string PageNotFound = "PageNotFound";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Member = "Member";
            public const string Project = "Project";
            public const string Article = "Article";
            public const string Projects = "Projects";
            public const string Contact = "Contact";
            public const string BlogPost = "BlogPost";
            public const string Blog = "Blog";
            public const string Comment = "Comment";
            public const string PageNotFound = "PageNotFound";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string language = "language";
        }
        static readonly ActionParamsClass_Member s_params_Member = new ActionParamsClass_Member();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Member MemberParams { get { return s_params_Member; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Member
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Project s_params_Project = new ActionParamsClass_Project();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Project ProjectParams { get { return s_params_Project; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Project
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Article s_params_Article = new ActionParamsClass_Article();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Article ArticleParams { get { return s_params_Article; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Article
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Projects s_params_Projects = new ActionParamsClass_Projects();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Projects ProjectsParams { get { return s_params_Projects; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Projects
        {
            public readonly string language = "language";
        }
        static readonly ActionParamsClass_Contact s_params_Contact = new ActionParamsClass_Contact();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Contact ContactParams { get { return s_params_Contact; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Contact
        {
            public readonly string contact = "contact";
        }
        static readonly ActionParamsClass_BlogPost s_params_BlogPost = new ActionParamsClass_BlogPost();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_BlogPost BlogPostParams { get { return s_params_BlogPost; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_BlogPost
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Blog s_params_Blog = new ActionParamsClass_Blog();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Blog BlogParams { get { return s_params_Blog; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Blog
        {
            public readonly string language = "language";
            public readonly string page = "page";
            public readonly string tag = "tag";
            public readonly string cat = "cat";
            public readonly string search = "search";
        }
        static readonly ActionParamsClass_Comment s_params_Comment = new ActionParamsClass_Comment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Comment CommentParams { get { return s_params_Comment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Comment
        {
            public readonly string name = "name";
            public readonly string email = "email";
            public readonly string text = "text";
            public readonly string commentId = "commentId";
            public readonly string postId = "postId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Blog = "Blog";
                public readonly string BlogPost = "BlogPost";
                public readonly string Contact = "Contact";
                public readonly string Index_en = "Index_en";
                public readonly string Index_ru = "Index_ru";
            }
            public readonly string Blog = "~/Views/Home/Blog.cshtml";
            public readonly string BlogPost = "~/Views/Home/BlogPost.cshtml";
            public readonly string Contact = "~/Views/Home/Contact.cshtml";
            public readonly string Index_en = "~/Views/Home/Index_en.cshtml";
            public readonly string Index_ru = "~/Views/Home/Index_ru.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : KonigLabs.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string language);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(string language)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "language", language);
            IndexOverride(callInfo, language);
            return callInfo;
        }

        [NonAction]
        partial void MemberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Member(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Member);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            MemberOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void ProjectOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Project(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Project);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ProjectOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void ArticleOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Article(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Article);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ArticleOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void ProjectsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string language);

        [NonAction]
        public override System.Web.Mvc.ActionResult Projects(string language)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Projects);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "language", language);
            ProjectsOverride(callInfo, language);
            return callInfo;
        }

        [NonAction]
        partial void ContactOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, KonigLabs.Models.ViewContact contact);

        [NonAction]
        public override System.Web.Mvc.ActionResult Contact(KonigLabs.Models.ViewContact contact)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Contact);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "contact", contact);
            ContactOverride(callInfo, contact);
            return callInfo;
        }

        [NonAction]
        partial void BlogPostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult BlogPost(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogPost);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            BlogPostOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void BlogOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string language, int? page, int? tag, int? cat, string search);

        [NonAction]
        public override System.Web.Mvc.ActionResult Blog(string language, int? page, int? tag, int? cat, string search)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Blog);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "language", language);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "tag", tag);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cat", cat);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "search", search);
            BlogOverride(callInfo, language, page, tag, cat, search);
            return callInfo;
        }

        [NonAction]
        partial void CommentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string name, string email, string text, int? commentId, int? postId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Comment(string name, string email, string text, int? commentId, int? postId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Comment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "email", email);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "text", text);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "commentId", commentId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            CommentOverride(callInfo, name, email, text, commentId, postId);
            return callInfo;
        }

        [NonAction]
        partial void PageNotFoundOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PageNotFound()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PageNotFound);
            PageNotFoundOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
