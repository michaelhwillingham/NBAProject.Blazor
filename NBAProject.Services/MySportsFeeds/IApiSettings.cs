namespace NBAProject.Services.MySportsFeeds
{
    public interface IApiSettings
    {
        public string BaseUrl { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}