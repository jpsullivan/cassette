﻿using Cassette.UI;

namespace Cassette
{
    public interface ICassetteApplication
    {
        IFileSystem RootDirectory { get; }
        bool IsOutputOptimized { get; }
        IUrlGenerator UrlGenerator { get; }

        IPageAssetManager GetPageAssetManager<T>() where T : Module;
    }
}