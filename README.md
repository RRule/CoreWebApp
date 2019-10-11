# CoreWebApp
CoreWebApp Tester



Starting from the default ASPNET Core Angular application:

1. install npm package: Vue Cli MiddleWare
    install; Microsoft.AspNetCore.SpaServices.Extensions
    
2. Go to Startup.cs
  change spa.UseAngular to spa.UseVueCli(npmScript: "serve", port: 8080);
                    // if you just prefer to proxy requests from client app, use proxy to SPA dev server instead:
                    // app should be already running before starting a .NET client
                    // spa.UseProxyToSpaDevelopmentServer("http://localhost:8080"); // your Vue app port
  
3. Delete ClientApp Folder
4. Open powershell in project root
5. Enter Command `vue create -n -b client-app`
6. Set Typescript build to - Use latest available
7. open projectname.csproj, edit ClientApp to `client-app`
8. start debug

For more info and tips try:
https://wildermuth.com/2019/04/08/Using-Vue-CLI-Inside-an-ASP-NET-Core-Project

