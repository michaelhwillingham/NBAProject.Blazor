using System;
using Cake.Common;
using Cake.Core;
using Cake.Frosting;

namespace Build
{
    public class BuildContext : FrostingContext
    {
        public BuildContext(ICakeContext context) : base(context)
        {
            MsBuildConfiguration = context.Argument("configuration", "Debug");
            ApiBaseUrl = context.Argument("apiBaseUrl", string.Empty);
            ApiUsername = context.Argument("apiUsername", string.Empty);
            ApiPassword = context.Argument("apiPassword", string.Empty);
            IsGitHubActions = context.Argument("isGitHubActions", false);
        }

        public string MsBuildConfiguration { get; }
        public string ApiBaseUrl { get; }
        public string ApiUsername { get; }
        public string ApiPassword { get; }
        public bool IsGitHubActions { get; }
    }
}