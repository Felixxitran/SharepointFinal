using Demo_Sharepoint_API.Pages.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Demo_Sharepoint_API.Pages
{
    public class SharepointInstructionModel : PageModel
    {
        
        public ActionResult OnPost()
        {
            //tenantInfo.clientID = Request.Form["clientID"];
            //tenantInfo.clientSecret = Request.Form["clientSecret"];
            //tenantInfo.DomainSite = Request.Form["DomainSite"];
            //tenantInfo.FolderName = "Beta_Folder";


            //connect to Sharepoint
            //ConstructREST restClient = new ConstructREST();
            //HTTPRest restHTTPClient = new HTTPRest();
            //restClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            //string accessToken = restHTTPClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);

            //restHTTPClient.createNewFolder(accessToken, tenantInfo.DomainSite, tenantInfo.FolderName);
            return Redirect("Success");
        }
    }

    public class Customers
    {
        public string tenantID { get; set; }
        public string clientSecret { get; set; }
        public string companyName { get; set; }
    }
}

