# Custom Api Lib

## Mak response data and  to error message  same format



# Usage

- In the **Startup.cs Configure ** method add this code
  
  ```csharp
  app.UseCustomExceptionMiddleware();

  ```

- Add this attribute **[CustomResponseResult]** in you controllers


