<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
***
***
***
*** To avoid retyping too much info. Do a search and replace for the following:
*** michaelhwillingham, NBAProject.Blazor, twitter_handle, michaelhwillingham@gmail.com, NBAProject.Blazor, A .NET 5 Blazor Server web application to explore NBA statistics, rosters, and contracts.
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Mozilla Public License 2.0][license-shield]][license-url]
[![CI Status][ci-shield]][ci-url]



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/michaelhwillingham/NBAProject.Blazor">
    <img src="https://s3.amazonaws.com/nbaproject.blazor/project-logo.png" alt="Logo" width="120" height="120">
  </a>

  <h3 align="center">NBAProject.Blazor</h3>

  <p align="center">
    A .NET 5 Blazor Server web application to explore NBA statistics, rosters, and betting odds.
    <br />
    <a href="https://github.com/michaelhwillingham/NBAProject.Blazor/wiki/Architecture"><strong>Explore the architecture wiki »</strong></a>
    <br />
    <br />
    <a href="https://nbaprojectblazor.net">View Demo</a>
    ·
    <a href="https://github.com/michaelhwillingham/NBAProject.Blazor/issues">TODO:Report Bug</a>
    ·
    <a href="https://github.com/michaelhwillingham/NBAProject.Blazor/issues">TODO:Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

TODO:Add screenshot here.

TODO:Add story about project here.


### Built With
* [.NET 5](https://docs.microsoft.com/en-us/dotnet/core/dotnet-five)
* [Blazor Server](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
* [Mudblazor](https://mudblazor.com/)
* [MySportsFeed NBA API](https://www.mysportsfeeds.com/)


<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### MySportsFeeds API Prerequisites

* Register for an account with <a href="https://www.mysportsfeeds.com/">MySportsFeeds</a>. Upon registration, you can optionally request personal usage classification - this grants free, non-live API access to all resources. If you plan to test out MySportsFeeds to write your own *non-public* project, you have the option of using their scrambled API to access all API resources for free.
* Create a new MySportsFeed API key - importantly, this application makes use of the *Stats*, *Details* and *Odds* addons.
* Navigate to the repository directory on your machine, and the "NBAProject.Blazor" subfolder which contains the "NBAProject.Blazor.csproj" file.
* Add the API base url to your user secrets:
  ```sh
  dotnet user-secrets set "ApiSettings:BaseUrl" "https://api.mysportsfeeds.com/v2.1/pull/nba"

  --- OR ---

  dotnet user-secrets set "ApiSettings:BaseUrl" "https://scrambled-api.mysportsfeeds.com/v2.1/pull/nba"
  ```
* Add the API username (your API key) to your user secrets:
  ```sh
  dotnet user-secrets set "ApiSettings:ApiUsername" "{your_api_key_here}"
  ```
* Add the API password ("MYSPORTSFEEDS" for everyone) to your user secrets:
  ```sh
  dotnet user-secrets set "ApiSettings:ApiPassword" "MYSPORTSFEEDS"
  ```

### How to Build

* ***Note** - the referenced Cake Frosting build script will install the appropriate .NET 5 SDK if you do not have it already. (<a href="https://dotnet.microsoft.com/download/dotnet/5.0">v5.0.101</a>)*

1. Clone the repo
   ```sh
   git clone https://github.com/michaelhwillingham/NBAProject.Blazor.git
   ```
2. Execute Cake Frosting build (Windows, MacOS, and Linux)
   ```pwsh
   ./build.ps1
   ```
   or
   ```sh
   build.sh
   ```

<!-- USAGE EXAMPLES -->
## Usage

TODO:Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.



<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/michaelhwillingham/NBAProject.Blazor/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the Mozilla Public License 2.0. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Michael Willingham - michaelhwillingham@protonmail.com

Project Link: [https://github.com/michaelhwillingham/NBAProject.Blazor](https://github.com/michaelhwillingham/NBAProject.Blazor)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
### Application Libraries
* [RestSharp](https://restsharp.dev/)
* [MediatR](https://github.com/jbogard/MediatR)
### CI/CD & Hosting
* [Cake Frosting](https://cakebuild.net/docs/running-builds/runners/cake-frosting)
* [GitHub Actions](https://github.com/features/actions)
* [Azure App Service](https://azure.microsoft.com/en-us/services/app-service/)
### Testing Libraries
* [XUnit](https://xunit.net/)
* [Shouldly](https://shouldly.io/)
### Other
* [Best-README-Template](https://github.com/othneildrew/Best-README-Template)




<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/michaelhwillingham/NBAProject.Blazor.svg?style=for-the-badge
[contributors-url]: https://github.com/michaelhwillingham/NBAProject.Blazor/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/michaelhwillingham/NBAProject.Blazor.svg?style=for-the-badge
[forks-url]: https://github.com/michaelhwillingham/NBAProject.Blazor/network/members
[stars-shield]: https://img.shields.io/github/stars/michaelhwillingham/NBAProject.Blazor.svg?style=for-the-badge
[stars-url]: https://github.com/michaelhwillingham/NBAProject.Blazor/stargazers
[issues-shield]: https://img.shields.io/github/issues/michaelhwillingham/NBAProject.Blazor.svg?style=for-the-badge
[issues-url]: https://github.com/michaelhwillingham/NBAProject.Blazor/issues
[license-shield]: https://img.shields.io/github/license/michaelhwillingham/NBAProject.Blazor.svg?style=for-the-badge
[license-url]: https://github.com/michaelhwillingham/NBAProject.Blazor/blob/master/LICENSE.txt
[ci-shield]: https://img.shields.io/github/workflow/status/michaelhwillingham/NBAProject.Blazor/Build-And-Deploy?style=for-the-badge
[ci-url]: https://github.com/michaelhwillingham/NBAProject.Blazor/actions