<h2 align="center">Francois Smith</h3>
<h3 align="center">Proficiency Assessment | Gendac</h3>

<div align="center">
    <p>
        This is my proficiency assessment for my application to join Gendac for a part time vacation work position.
    </p>
</div>
<br/>

<details>
  <summary>Table of Contents</summary>
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
    <li><a href="#layout">Layout</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

## About The Project

This project must have a web api using ASP.NET with basic CRUD events. For my choice of tools I went for a .NET core api bundled with React.js for visuals. This will showcase my knowledge in react and also my ability to quickly adopt a new toolset in a short period of time with ASP.NET.

## Built With

* [![Bootstrap][Bootstrap.com]][Bootstrap-url]
* [![React][React.js]][React-url]
* [![Net][Asp.net]][Net-url]


## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

Make sure you have the latest LTS version of node installed. You can download it from [here](https://nodejs.org/en/)
* Validate that you have node installed by running the following command in your terminal
  ```sh
    node -v
    ```

### Installation

1. Extract the zip file
2. Clone the repo
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. Enter your API in `config.js`
   ```js
   const API_KEY = 'ENTER YOUR API';
   ```

## Layout

The application is set up using a react front end and a .NET core backend. The front end is set up to use the backend api to perform CRUD operations on the database. The front end is also set up to use a bootstrap theme for styling. All of the code is contained in the ProficiencyAssessment folder.

### Backend
* Program.cs - This is the entry point for the application, it sets up the api endpoints and CORS rules.
* Models/ - This folder contains the data transfer objects, such as products.
* Controllers/ - This folder contains the controllers for the api endpoints.

Within ClientApp/src is the setupProxy file which is used to proxy the api calls to the backend.

### Frontend
All of the frontend code is contained within the ClientApp folder.

* aspnetcore-https.js - This file is used to set up the HTTPS for the application using the ASP.NET Core HTTPS certificate.
* public/ - This folder contains the index.html file which is the entry point for the react application.
* src/ - This folder contains all of the react code.
  * components/ - This folder contains all of the react components.
  * App.js - This file is used to link together all of the components.
  * index.js - This file renders the react application to the DOM using index.html.

## Usage


### Adding Additional API Endpoints

To add additional API endpoints, you must add a controller to the Controllers folder.

The created controller must inherit from the ControllerBase class, it must also be decorated with the ApiController and Route attribute. The route attribute is used to set the route for the controller.

Example:
```csharp
    [ApiController] // This is used to tell the application that this is a controller
    [Route("[controller]")] // This is used to set the route for the controller
    public class ItemController : ControllerBase
    {
        // Controller code
    }
```

To creat a basic get request, create a method that is decorated with the HttpGet attribute, to add a route for the method use the route decorator. This method must return an IActionResult, this is used to return the data to the client. The IActionResult can be created using the Ok method, which takes in data to be returned.

Example:
```csharp
    [HttpGet] //Defines the method as a get request
    [Route("GetItems")] //Defines the route for the get request i.e. api/ItemController/GetItems
    public IActionResult Get()
    {
        var items = new items[]
        return Ok(items); //Returns the items to the client
    }
```

## Contact

Francois Smith - contact@francois-smith.com

Project Link: [https://github.com/francois-smith/Gendac-API](https://github.com/francois-smith/Gendac-API)

[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Asp.net]: https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[Net-url]: https://dotnet.microsoft.com/en-us/
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com

<p align="right">(<a href="#readme-top">back to top</a>)</p>
