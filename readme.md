## Synopsis

Neighborhood Web Site

This project demonstrates a neighborhood web site constructed in C#.

This project was done for Code Louisville's Fall 2016 session.

## Points of interest
- Feature article with image carousel
- Additional main-page articles with images
- Links to on-site or YouTube videos
- Provision for advertising content
- Flattering display of neighborhood association board members
- List of useful neighborhood phone numbers
- List of linked archival newsletters
- Panel-based styling features color cycling
- Responsive design for large, medium and small media
- Article images can be optionally hidden on small media
- Top-bar text adapts to small media
- All displayable items editable with content management tools
- Small and simple initial test database
- Test database is persistent and can be reset

# Tools and frameworks
- Developed in Visual Studio 2015 Community Edition
- MVC 5, Entity Framework 6, .NET 4.5
- Styled with Zurb Foundation 5.5.0
- Slick Carousel 1.5.11 for feature image fading
- jQuery 2.2.4
- Modernizr 2.8.3

## Preconditions for demonstration
- Install Visual Studio 2015 Community Edition
- Clone or otherwise retrieve and unpack Github project into a preferred folder
- Locate and open the solution file in Visual Studio
- Prepare the database:
    - ? prepare persistent LocalDB ?
    - In Package Manager Console, run "update-database"
    - In SQL Server Object Explorer, refresh and observe creation of 
      of the persistent database:
        - SQLSOE/SQL Server/MSSQLLocalDB.../Databases/NWS_cs/Tables
- Build and run the project on a preferred web browser
- See .../NWS-cs/Content/Test/... for additional content to link to

- To reset the database:
    - In SQL Server Object Explorer, delete the NWS_cs database
    - If desired, edit seed data in .../Migrations/Configuration.cs
    - In Package Manager Console, re-run "update-database"

## Comments welcome to Calvin Miracle, cbmira01@gmail.com
