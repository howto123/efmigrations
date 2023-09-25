https://learn.microsoft.com/en-us/ef/core/cli/dotnet
https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli

In short:
`dotnet tool update --global dotnet-ef`

`dotnet add package Microsoft.EntityFrameworkCore.Design`

Install provider:
https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli

`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL`

`dotnet ef migrations add InitialCreate`

`dotnet ef database update`


Set environment

`dotnet user-secrets init`
`dotnet user-secrets set "WebApiDatabase" "Host=localhost; Database=dotnet-6-crud-api; Username=postgres; Password=mysecretpassword"`

If you use appsettings, have this in csproj:
        <ItemGroup>
            <None Update="appsettings.json">
                <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
                <CopyToPublishDirectory>Always</CopyToPublishDirectory>
            </None>
        </ItemGroup>


As db admin, create a db
Grant priviledges and change ownership if necessairy