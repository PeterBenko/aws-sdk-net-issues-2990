using System;
using Amazon.S3;

namespace ClassLibrary
{
    /// <summary>
    /// Exception when accessing Blob Storage.
    /// </summary>
    public class BlobStorageAccessException : Exception
    {
        /// <inheritdoc />
        public BlobStorageAccessException(string message, AmazonS3Exception innerException) : base(message, innerException)
        {
        }
    }
}
