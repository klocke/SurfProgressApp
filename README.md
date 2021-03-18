# SurfProgressApp

# Overview
With the Web App SurfProgressApp you can keep track of your Surf Progress, Surf Sessions and Surfboards.
On the homepage/ chartpage you can find a chart indicating your Wave Count (Caught Waves) from your Surf Sessions.

![chart](https://user-images.githubusercontent.com/17553693/111614345-c5262400-87df-11eb-91cc-e225554201f8.png)

By navigating to Surfboards on the side panel on the left side, you will get to the Surfboards page.
Here you can view all your Surfboards in a List, Create a new Surfboard, update an existing Surfboard or delete it.

![surfboardlist](https://user-images.githubusercontent.com/17553693/111614427-e0912f00-87df-11eb-9610-c02824db7768.png)

![createsurfboard](https://user-images.githubusercontent.com/17553693/111614473-ebe45a80-87df-11eb-8244-adb25805c3c2.png)

By navigating to Surf Sessions on the side panel, you will get to the Surf Sessions page.
Here you can view all Surf Sessions in a List, Create a new Surf Session, update an existing Surf Session or delete it.

![surfsessionlist](https://user-images.githubusercontent.com/17553693/111614556-061e3880-87e0-11eb-9274-87ffbf05a5ff.png)

![editsurfsession](https://user-images.githubusercontent.com/17553693/111614623-1504eb00-87e0-11eb-89ca-31b361d5ff46.png)

# Project Structure

The Solution consists of three Projects: SurfProgressAPI, SurfProgressAPI.Shared and SurfProgressApp. 

SurfProgressAPI: The Web API Back end of the solution.    
SurfProgressApp: The Blazor WebAssembly Front end.    
SurfProgressAPI.Shared: The Model consisting of two classes: Surfboard and SurfSession shared across the other Projects.


# Model
There is two Tables in the database correlating to the two classes in the model, Surfboards and Surfsessions.
1 SurfSession has 1 Surfboard and 1 Surfboard can be used in many SurfSessions (1 to many relationship).
The Property SurfboardId is hereby used as a foreign key to specify the relationship.

![relationships](https://user-images.githubusercontent.com/17553693/111615505-1c78c400-87e1-11eb-8884-57e1b901aee7.png)

# Get Started

Change "DevConnection" String in SurfProgressAPI -> appsettings.json file.

Change portnumber SurfProgressAPI -> Startup.cs -> Configure Method to suit the Apps portnumber.
```C#       
app.UseCors(options =>
    options.WithOrigins("http://localhost:<portnumber>")
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowAnyOrigin()
);
```
Use 'Add-Migrations Init' in Package Manager Console to initialize the database.
Followed by 'update-database'.

Change portnumber SurfProgressApp -> Program.cs to suit Apis portnumber.
```C#
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://localhost:<portnumber>")
    });
```
Setup multiple startup projects SurfProgressAPI and SurfProgressApp.

# Seed Sample Data

Sample Data can be found in SurfProgressAPI -> Sample-Data. There are two JSON files containing sample data for Surfboards and SurfSessions. They can be seeded using the Swagger UI Post Methods. At this stage every entry needs to be copied one by one.
