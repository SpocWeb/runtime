// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;

using Internal.Cryptography;

namespace System.Security.Cryptography
{
    public sealed partial class ECDsaCng : ECDsa
    {
        protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) =>
            CngCommon.HashData(data, offset, count, hashAlgorithm);

        protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) =>
            CngCommon.HashData(data, hashAlgorithm);

        protected override bool TryHashData(ReadOnlySpan<byte> source, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten) =>
            CngCommon.TryHashData(source, destination, hashAlgorithm, out bytesWritten);
    }
}
