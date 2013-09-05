PeerBeerAwards
==============
Unfortunately github for Windows is not working on my computer and there are lots of files to upload. However the vast majority of them was generated when creating a project from the Intranet ASP.NET MVC4 template. Therefore:

1. Create a new project using that template
2. Add these lines to the web.config:

      <connectionStrings>
        <add name="PeerBeerAwardsContext" connectionString="Data Source=C:\Dev\PeerBeerAwards\db\PeerBeerAwards.sdf;Persist Security Info=True" providerName="System.Data.SqlServerCE.4.0" />
      </connectionStrings>

3. Add the files from this repository.
4. Find a good beer image that you name beer.png and place in the Images folder
4. Fix until it works
