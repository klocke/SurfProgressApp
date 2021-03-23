# SurfProgressApp

# Overview
With the Web App SurfProgressApp you can keep track of your Surf Progress, Surf Sessions and Surfboards.
On the homepage/ chartpage you can find a chart indicating your Wave Count (Caught Waves) from your Surf Sessions.

![chart2](https://user-images.githubusercontent.com/17553693/112140875-dfdc0c80-8bd4-11eb-9f26-b17fbbdfb6c4.png)

By navigating to Surfboards on the side panel on the left side, you will get to the Surfboards page.
Here you can view all your Surfboards in a List, Create a new Surfboard, update an existing Surfboard or delete it.
In addition, you can view all linked Surf Sessions via the grey list button.

![surfboardlist2](https://user-images.githubusercontent.com/17553693/112140989-069a4300-8bd5-11eb-89be-13e6178922f0.png)

When creating or editing a Surfboard, you can enter all the details and also Add or Edit Surf Sessions that are linked to the Board.

![createsurfboard3](https://user-images.githubusercontent.com/17553693/112141475-9d66ff80-8bd5-11eb-8fe8-8649115fb363.png)

![linksessions](https://user-images.githubusercontent.com/17553693/112142072-6cd39580-8bd6-11eb-9639-3acbcddc4794.PNG)

By navigating to Surf Sessions on the side panel, you will get to the Surf Sessions page.
Here you can view all Surf Sessions in a List, Create a new Surf Session, update an existing Surf Session or delete it.

![surfsessionlist2](https://user-images.githubusercontent.com/17553693/112141602-c091af00-8bd5-11eb-8f33-5dd21333e60b.png)

![editsurfsession](https://user-images.githubusercontent.com/17553693/111614623-1504eb00-87e0-11eb-89ca-31b361d5ff46.png)

# Project Structure

The Solution consists of three Projects: SurfProgressAPI, SurfProgressAPI.Shared and SurfProgressApp. 

SurfProgressAPI: The Web API Back end of the solution.    
SurfProgressApp: The Blazor WebAssembly Front end.    
SurfProgressAPI.Shared: The Model consisting of two classes: Surfboard and SurfSession shared across the other Projects.


# Model
There are two Tables in the database correlating to the two classes in the model, Surfboards and Surfsessions.
1 SurfSession has 1 (or 0) Surfboards and 1 Surfboard can be used in many SurfSessions (1 to many relationship).
The Property SurfboardId is hereby used as a foreign key to specify the relationship.

![Tables_new](https://user-images.githubusercontent.com/17553693/111868138-78c21c00-8978-11eb-9123-15fcdd3d240d.png)

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

Sample Data can be found in SurfProgressAPI -> Sample-Data. There are two JSON files containing sample data for Surfboards and SurfSessions. They can be seeded using the Swagger UI Post Methods. POST api/Surfboard/range and POST api/SurfSession/range.
