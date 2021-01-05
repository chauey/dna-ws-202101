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