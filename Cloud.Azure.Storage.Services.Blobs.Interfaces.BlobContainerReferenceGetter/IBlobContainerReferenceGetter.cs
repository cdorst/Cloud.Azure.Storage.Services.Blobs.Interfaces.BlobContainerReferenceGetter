// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage;

namespace Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerReferenceGetter
{
    /// <summary>Interface for service responsible for getting a blob container reference</summary>
    public interface IBlobContainerReferenceGetter
    {
        /// <summary>Returns reference to an existing blob container</summary>
        CloudBlobContainer GetExistingContainer(string containerName);
    }
}
