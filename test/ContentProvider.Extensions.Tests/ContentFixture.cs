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

using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace ContentProvider.Tests
{
    public sealed class ContentFixture
    {
        public ContentFixture()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddContentProvider("Text", b => b
                .From.ResourcesInExecutingAssembly(rootNamespace: typeof(ServiceCollectionTests).Namespace));
            services.AddContentProvider("Json", b => b
                .From.ResourcesInExecutingAssembly(rootNamespace: typeof(ServiceCollectionTests).Namespace, resourceFileExtension: "json"));
            services.AddContentSet<TextContentSet>();
            services.AddContentSet<JsonContentSet>("Json");
            ServiceProvider = services.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; }
    }

    [CollectionDefinition("Content")]
    public sealed class ContentCollection : ICollectionFixture<ContentFixture>
    {
    }
}
