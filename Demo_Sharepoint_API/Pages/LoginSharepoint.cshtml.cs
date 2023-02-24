using Demo_Sharepoint_API.Pages.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Azure.Core;

namespace Demo_Sharepoint_API.Pages
{
    public class LoginSharepointModel : PageModel
    {
        public void OnGet()
        {
        }
        public GetAccessToken tenantInfo = new GetAccessToken();
        public TokenMemento tokenmemento = new TokenMemento();
        public ActionResult OnPost()
        {

            saveTenantInfo();


            string accessToken = getAccessToken();

            tokenmemento = saveToNewPage(accessToken);

            //restHTTPClient.createNewFolder(accessToken, tenantInfo.DomainSite, tenantInfo.DocumentLibrary,tenantInfo.FolderName);

            return Redirect("SharepointUI");
        }
        public string getAccessToken()
        {
            ConstructREST restClient = new ConstructREST();
            HTTPRest restHTTPClient = new HTTPRest();
            string accessToken = restHTTPClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            return accessToken;
        }
        public TokenMemento saveToNewPage(string accessToken)
        {
            return new TokenMemento(accessToken,tenantInfo.DomainSite,tenantInfo.FolderName,tenantInfo.DocumentLibrary);
        }
        public void saveTenantInfo()
        {
            tenantInfo.clientID = Request.Form["clientID"];
            tenantInfo.clientSecret = Request.Form["clientSecret"];
            tenantInfo.DomainSite = Request.Form["DomainSite"];
            tenantInfo.DocumentLibrary = "SeatechFiles";
            tenantInfo.FolderName = Request.Form["FolderName"];
        }
        public class GetAccessToken
        {
            public string clientID = "";
            public string clientSecret = " ";
            public string DomainSite = "";
            public string DocumentLibrary = "";
            public string FolderName = "";
        }
    }
}
