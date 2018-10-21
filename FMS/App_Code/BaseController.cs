using System;
using System.Web;
using System.IO;
using System.Xml;
using System.Text;
using System.Security.Cryptography;
using System.Reflection;
using System.Configuration;
using System.Web.UI.WebControls;
using IOM.IECFMS.DAL;
using System.Data.Common;
using System.Collections;
using System.Web.Caching;
using System.Security;
using System.Web.Security;


namespace FMS.BaseController
{
	/// <summary>
	/// Summary description for BaseController.
	/// </summary>
	public class BaseController : System.Web.UI.Page
	{

		
		protected void LoadCache()
		{
			// Add code here if you want to load in to cache
			
		
		}
		
		public BaseController()
		{
		}
		protected override void OnError(System.EventArgs e)
		{
			if (HttpContext.Current.Error != null)
			{			
				
				//AMSCommon.LogErrorToFile(HttpContext.Current.Error, HttpContext.Current.Request.FilePath.ToString(), "", "", true);
				//AMSCommon.SendErrorToMail(HttpContext.Current.Error, AMSCommon.ProjectName, HttpContext.Current.Request.FilePath.ToString(), AMSCommon.ToMail);
				Session["ErrorMsg"] = Server.GetLastError().Message ;
				Response.Redirect("../Default.aspx");
			}
		}

		private void EnvironmentLogin()
		{
			//Redirect the user to the Home page when Session is null
            //string strUserId ;
            //string[]  strRole;
            //strUserId = "";
            //strUserId = Environment.UserName;
            //strRole = Roles.GetRolesForUser(strUserId);

            //if (strUserId != "")
            //{
            //    MembershipUser user = Membership.GetUser(Environment.UserName);
            //    //MembershipUser user = Membership.GetUser(HttpContext.Current.User.IsInRole("role"));
                

            //    Session["UserName"]= strUserId;
            //    Session["Role"] = strRole[0].ToString();
            //    Session.Timeout = 30;
            //}
            //else
            //{
            //    Response.Write( "Not Authorised user");
            //    Response.End();
            //}
		}
				
		protected override void OnLoad(System.EventArgs e)
		{
			//This line of code ensures that the pages are not cached by the browser
			Response.Cache.SetExpires(DateTime.Now);

			//Load Common Message file into Cache
			if (! Page.IsPostBack)
			{
				if (System.Web.HttpContext.Current.Cache["CommonMsg"] == null)
				{
					FMSCommon.objCached.loadMsg(FMSCommon.xmlMsgFilePath);
					System.Web.HttpContext.Current.Cache["CommonMsg"] = FMSCommon.objCached;
					CacheDependency dependency = new CacheDependency(FMSCommon.xmlMsgFilePath);
					System.Web.HttpContext.Current.Cache.Insert("CommonMsg", FMSCommon.objCached, dependency);
				}
				else
				{
					FMSCommon.objCached = (Message) System.Web.HttpContext.Current.Cache["CommonMsg"];
				}
			}


            if (Session["UserId"] == null)
            {
                string authType = System.Configuration.ConfigurationSettings.AppSettings.Get("Authentication").ToString();


                //if (authType == "Windows")
                //{
                //    EnvironmentLogin();
                //    LoadCache();
                //}
                //else if (authType == "Forms")
                //{

                    string pageRequested = System.IO.Path.GetFileName(Convert.ToString(Request.Url));

                    //if (pageRequested.ToLower().IndexOf("login.aspx") == -1)
                    //{
                    //    Response.Redirect("~//Login.aspx");//?key=Not_LoggedIn");
                    //}
                //}
                //}
            }
			base.OnLoad(e);
		}
		
	}

}
