﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileStream.BuildReadWriteProtocols.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Database.Protocol.FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Naos.Database.Domain;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Serialization;

    public partial class FileStream
    {
        /// <inheritdoc />
        public override IStreamReadingProtocols<TId, TObject> GetStreamReadingProtocols<TId, TObject>()
        {
            var result = new FileStream<TId, TObject>(this);
            return result;
        }

        /// <inheritdoc />
        public override IStreamWritingProtocols<TId, TObject> GetStreamWritingProtocols<TId, TObject>()
        {
            var result = new FileStream<TId, TObject>(this);
            return result;
        }
    }
}
