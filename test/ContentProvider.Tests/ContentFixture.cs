﻿#region --- License & Copyright Notice ---
/*
ContentProvider Framework
Copyright 2020 Jeevan James

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion

using ContentProvider.EmbeddedResources;

using Xunit;

namespace ContentProvider.Tests
{
    public sealed class ContentFixture
    {
        public ContentFixture()
        {
            ContentManager.Register("Text", new ContentBuilder()
                .From.ResourcesInExecutingAssembly(new EmbeddedResourceContentSourceOptions
                {
                    RootNamespace = "ContentProvider.Tests",
                })
                .Build());
            ContentManager.Register("Json", new ContentBuilder()
                .From.ResourcesInExecutingAssembly(new EmbeddedResourceContentSourceOptions
                {
                    FileExtension = "json",
                    RootNamespace = "ContentProvider.Tests",
                })
                .Build());
        }
    }

    [CollectionDefinition("Content")]
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
    public sealed class ContentCollection : ICollectionFixture<ContentFixture>
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
    {
    }
}
