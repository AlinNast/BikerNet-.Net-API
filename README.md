# BikerNet-.Net-API
This is the Api App for my personal project BikerNet implemented with C#
##### It features:
- Datababe created with Entity framework
- Controller Service Repository Design pattern

## What I've learned:
- How to create Api endpoints in the controllers
- Controller Service Repository design pattern


## How to install:
1. Clone this repo

2. Install Sql server 
  - from here : https://www.microsoft.com/en-us/sql-server/sql-server-downloads

3. Vefify if this in in appsettings.json, if not copy it there:
`"ConnectionStrings": {
    "DefaultConnection" : "server=localhost\\sqlexpress;database=bikernetdb;trusted_connection=true"
  },`

4. Check if entity framework is install with `dotnet ef` in Package Manager console
If not, run : `dotnet tool install --global dotnet-ef`

5. Now to create the database: 
  - Go to Package manager console:
    - `cd .\BikerNetApi`
    - `dotnet ef migrations add CreateInitial`
    - `dotnet ef database update`

6. Run the project


#### Link to Backlog of this poject:
https://trello.com/b/janwdwXI/biker-net-api-c


<!-- questions:  

what does everything in program do
what is to know about controllers
have sql server installed
sql server management studio optional

make sure this""ConnectionStrings": {
    "DefaultConnection" : "server=localhost\\sqlexpress;database=bikernetdb;trusted_connection=true"
  }," is in appsettings.json

  do dotnet ef in PM if not do dotnet tool install --global dotnet-ef

  now create migration:
  in PM 
  cd .\BikerNetApi
  dotnet ef migrations add CreateInitial
  dotnet ef database update
  you can now see db in sql server managment studio

-->