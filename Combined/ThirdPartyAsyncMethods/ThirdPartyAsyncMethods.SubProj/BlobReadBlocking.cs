using Azure.Storage.Blobs;

namespace ThirdPartyAsyncMethods.SubProj;
public class BlobReadBlocking
{
    //public static void Foo()
    //{
    //    BlobContainerClient _blobContainerClient = new("connstri", "foldername");

    //    BlobClient blobClient = _blobContainerClient.GetBlobClient("fileName");

    //    Stream data = FileStream.Null;

    //    blobClient.UploadAsync(data, true).Wait();
    //}
    public static async Task Foo()
    {
        BlobContainerClient _blobContainerClient = new("connstri", "foldername");

        BlobClient blobClient = _blobContainerClient.GetBlobClient("fileName");

        Stream data = FileStream.Null;
        await blobClient.UploadAsync(data, true);
    }
}
