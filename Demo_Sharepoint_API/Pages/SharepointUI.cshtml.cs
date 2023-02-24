using Demo_Sharepoint_API.Pages.REST;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.EntityFrameworkCore;

namespace Demo_Sharepoint_API.Pages
{
    
    public class SharepointUIModel : PageModel
    {

        LoginSharepointModel loginModel = new LoginSharepointModel();
        public LoginSharepointModel login { get; set; }
        TokenMemento memento = login.saveToken;
        
        public void OnGet()
        {
            //this.access = login.saveToken;
            //Console.WriteLine(access.accessToken);
        }
        public ActionResult OnPost() {
            /*//connect to Sharepoint
            ConstructREST restClient = new ConstructREST();
            HTTPRest restHTTPClient = new HTTPRest();
            //restClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            string accessToken = restHTTPClient.getAccessToken(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            //restClient.getAccessTokenWithHTTP(tenantInfo.clientID, tenantInfo.DomainSite, tenantInfo.clientSecret);
            //return RedirectToPage("Index");
            restHTTPClient.createNewFolder(accessToken, tenantInfo.DomainSite, tenantInfo.FolderName);
            return Redirect("Success");*/
            
            Console.WriteLine("TRAN NGOC MINH KHOA");
            return Redirect("Success");
        }
        public ActionResult OnPostTranfersome() {
            Console.WriteLine("transfer some done");
            return Redirect("Success");
        }
        public ActionResult OnPostTransferall()
        {
            Console.WriteLine("transfer all done");
            Console.WriteLine(login);
            Console.WriteLine(login.saveToken);
            this.access = login.saveToken;
            Console.WriteLine(access);
            return Redirect("Success");
        }
        public ActionResult OnPostDonottransfer()
        {
            Console.WriteLine("Do not transfer anything");
            return Redirect("Success");
        }
    }
}
