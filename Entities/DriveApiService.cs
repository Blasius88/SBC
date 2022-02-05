using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class DriveApiService
{

    /// <summary>
    /// ссылка на страницу https://zznob.ru/codding/csharp/ispolzovanie-google-drive-v-prilozhenii-c/
    /// еще одна ссылка https://developers.google.com/drive/api/v3/quickstart/dotnet
    /// ссылка на googleCloud https://console.cloud.google.com/apis/api/drive.googleapis.com/drive_sdk?project=sbc-340410
    /// https://overcoder.net/q/1262658/%D0%B7%D0%B0%D0%B3%D1%80%D1%83%D0%B7%D0%B8%D1%82%D0%B5-%D1%84%D0%B0%D0%B9%D0%BB%D1%8B-%D0%BD%D0%B0-google-drive-%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D1%83%D1%8F-google-drive-api-%D0%B2-aspnet-%D1%81-c
    /// </summary>
    protected static string[] scopes = { DriveService.Scope.Drive };
    protected readonly UserCredential credential;
    static string ApplicationName = "Название приложения";
    protected readonly DriveService service;
    protected readonly FileExtensionContentTypeProvider fileExtensionProvider;
   
    
    /*
    public DriveApiService()
    {
        var email = "romanmebelholl@gmail.com";
        using (var stream =
            new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
        {
            string credPath = "token.json";

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                scopes,
                email, // Используйте константу или читайте из файла настроек
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;

            fileExtensionProvider = new FileExtensionContentTypeProvider();
        }

        service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });
        //services.AddSingleton<DriveApiService>();
    }


    /// <summary>
    /// список файлов 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public IList<Google.Apis.Drive.v3.Data.File> ListEntities(string id = "root")
    {
        FilesResource.ListRequest listRequest = service.Files.List();
        listRequest.PageSize = 100;
        listRequest.Fields = "nextPageToken, files(id, name, parents, createdTime, modifiedTime, mimeType)";
        listRequest.Q = $"'{id}' in parents";

        return listRequest.Execute().Files;
    }

    /// <summary>
    /// создание папок 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public Google.Apis.Drive.v3.Data.File CreateFolder(string name, string id = "root")
    {
        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
        {
            Name = name,
            MimeType = "application/vnd.google-apps.folder",
            Parents = new[] { id }
        };

        var request = service.Files.Create(fileMetadata);
        request.Fields = "id, name, parents, createdTime, modifiedTime, mimeType";

        return request.Execute();
    }

    /// <summary>
    /// загрузка файлов 
    /// </summary>
    /// <param name="file"></param>
    /// <param name="documentId"></param>
    /// <returns></returns>
    public async Task<Google.Apis.Drive.v3.Data.File> Upload(IFormFile file, string documentId)
    {
        var name = ($"{DateTime.UtcNow.ToString()}.{Path.GetExtension(file.FileName)}");
        var mimeType = file.ContentType;

        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
        {
            Name = name,
            MimeType = mimeType,
            Parents = new[] { documentId }
        };

        FilesResource.CreateMediaUpload request;
        using (var stream = file.OpenReadStream())
        {
            request = service.Files.Create(
                fileMetadata, stream, mimeType);
            request.Fields = "id, name, parents, createdTime, modifiedTime, mimeType, thumbnailLink";
            await request.UploadAsync();
        }


        return request.ResponseBody;
    }*/

}