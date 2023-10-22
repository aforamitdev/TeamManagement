Enable a ubuntu settings 

```
   <TargetFramework>net7.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RuntimeIdentifier>ubuntu.22.04-x64</RuntimeIdentifier>
```

dotnet df dbcontext 

`
dotnet ef dbcontext info --project ./EmployeeManagement
`

dotnet add migrations 

` dotnet ef migrations add InitialData --project ./EmployeeManagement
`

dotnet update migrations 

`dotnet ef database update
`