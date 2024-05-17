using Azure.Storage.Blobs;

namespace ThirdPartyAsyncMethods.SubProj;
public class BlobReadBlocking
{
    public static async Task FooAsync()
    {
        BlobContainerClient _blobContainerClient = new("connstri", "foldername");

        BlobClient blobClient = _blobContainerClient.GetBlobClient("fileName");

        Stream data = FileStream.Null;

        await blobClient.UploadAsync(data, true);
    }
}
