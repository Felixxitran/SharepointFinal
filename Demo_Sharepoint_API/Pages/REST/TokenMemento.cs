namespace Demo_Sharepoint_API.Pages.REST
{
    public class TokenMemento
    {
        public string accessToken { get; set; }
        public string domainString { get; set; }
        public string folderName { get; set; }  

        public string documentLibrary { get; set; }  

        public TokenMemento(string accessToken, string domainString, string folderName, string documentLibrary)
        {
            this.accessToken = accessToken;
            this.domainString = domainString;
            this.folderName = folderName;
            this.documentLibrary = documentLibrary;
        }
        public TokenMemento() { }   
    }
}
