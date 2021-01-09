namespace NBAProject.Services.MySportsFeeds
{
    public interface IApiSettings
    {
        public string BaseUrl { get; set; }

        public string ApiUsername { get; set; }

        public string ApiPassword { get; set; }
    }
}