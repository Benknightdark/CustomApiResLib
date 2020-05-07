# Custom Api Lib

## Mak response data and  to error message  same format



# Usage

- add this code to **Startup.cs Configure** method 
  
  ```csharp
  app.UseCustomExceptionMiddleware();

  ```
- Add this attribute **[CustomResponseResult]** in you controllers

