
https://kruschecompany.com/blog/post/gdpr-smart-practices

https://docs.microsoft.com/en-us/aspnet/core/security/gdpr?view=aspnetcore-2.1

https://blogs.msdn.microsoft.com/webdev/2018/03/04/asp-net-core-2-1-0-preview1-gdpr-enhancements/

https://docs.microsoft.com/en-us/sql/relational-databases/security/encryption/transparent-data-encryption?view=sql-server-2017

Add, download, and delete custom user data to Identity in an ASP.NET Core project
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/add-user-data?view=aspnetcore-2.1&tabs=visual-studio

https://docs.microsoft.com/en-us/sql/relational-databases/security/encryption/transparent-data-encryption?view=sql-server-2017



https://github.com/blowdart/AspNetCoreIdentityEncryption
To have Identity encrypt your custom IdentityUser model, annotate your model fields with [ProtectedPersonalData].

https://www.tabsoverspaces.com/233700-custom-encryption-of-field-with-entity-framework-core

https://www.tabsoverspaces.com/233708-using-value-converter-for-custom-encryption-of-field-on-entity-framework-core-2-1

https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/security-considerations

Properties decorated with the PersonalData attribute are:

    Deleted when the Areas/Identity/Pages/Account/Manage/DeletePersonalData.cshtml Razor Page calls UserManager.Delete.
    Included in the downloaded data by the Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml Razor Page.

https://github.com/aspnet/Identity/blob/master/src/Stores/IdentityUser.cs
[ProtectedPersonalData]
public virtual string Email { get; set; }
