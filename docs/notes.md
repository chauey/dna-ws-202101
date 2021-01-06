# Commands
check nx version
- `nx --version`

install latest nx
- `npm install -g nx@latest --force`

create nx workspace
- `npx create-nx-workspace@latest`
  - (dna-ws-202101, empty, No)
  - creating ng app will use nx.json npmScope value which is workspace name. If has numbers like 202101, it will fail with "SchematicsException [Error]: Selector (dna-ws-202101-root) is invalid."

add nrwl angular schematics
- `npm i @nrwl/angular --save-dev`

Generate a new Angular application (collection:generator):
- `nx generate @nrwl/angular:app DnaNgApp`
- `nx generate @nrwl/angular:app DnaNgApp`

Generate a new Angular library application:
- `nx generate @nrwl/angular:library DnaSharedUiNg`
- `nx generate @nrwl/angular:library DnaComponentUi`
- `nx generate @nrwl/angular:library Netflix`

# Abp
Install abp libs
npm i @abp/ng.account
npm i @abp/ng.identity
npm i @abp/ng.setting-management
npm i @abp/ng.tenant-management
npm i @abp/ng.theme.basic



# Nx
- empty
- angular
  - jest
  - cypress
  - ngRx
  - storybook

# Abp
- .NET Core EF, SQL Server
- Angular
- Others
  - .NET
  - MongoDB
  - React Native
  - Blazor
  - Razor
  - ...


# ABP INITIAL 1st time
install abp cli
- `dotnet tool install -g Volo.Abp.Cli`
Update ABP CLI
- `dotnet tool update -g Volo.Abp.Cli` (had to update beacuse cuz was running old and could not generate proxy)
run command to create??? or download from website below 

Download https://abp.io/get-started
  (Dna.CodingChallengeangular, EF Core, seperate Identity Server)
run .DBMigrator (it will create the DB)

# ABP RUN APP
run (https://docs.abp.io/en/abp/latest/Startup-Templates/Application)
1. .IdentityServer (auth)
2. .HttpApi.Host (web api)
3. `ng serve` in angular folder - (web app) (admin/1q2w3E*)

# ABP adding Entity etc.
- https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=NG&DB=EF (angular, ef core)
- https://learnabpframework.com/courses/bookstore-application-using-angular-with-entity-framework/
# 1. Server Side

## Create the Show Entity
- Domain Shows.Show AuditedAggregateRoot<int>

## ShowType and RatingType Enum
- Domain.Shared Shows.ShowType, Shows.RatingType

## Add Book Entity to the DbContext
- DbContext 
public DbSet<Show> Shows { get; set; }

## Map the Book Entity to a Database Table

## Add Database Migration
- Add-Migration "Created_Show_Entity"

## Add Sample Seed Data

## Update the Database

## Create the Application Service

### ShowDto

### CreateUpdateShowDto

### IShowAppService

### ShowAppService
## Auto API Controllers
### Swagger UI





# 2. List Page

## Localization

## Install NPM Packages

## Create a Shows Page

### ShowMoulde
- yarn ng generate module show --module app --routing --route shows
### ShowModule

### Routing

### Service Proxy Generation

### ShowComponent


- yarn ng generate module show --module app --routing --route shows
3. CRUD
4. Integration Tests
5. Authorization
6. Domain Layer
7. Database Integration
8. Application Layer
9. UI
10. Relation

data seeding (https://docs.abp.io/en/abp/latest/Data-Seeding)

# TIPS
- https://github.com/azz/pretty-quick#readme

