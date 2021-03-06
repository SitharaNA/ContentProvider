﻿#region --- License & Copyright Notice ---
/*
ContentProvider Framework
Copyright (c) 2020 Damian Kulik, Jeevan James

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

using System.Threading.Tasks;

namespace ContentProvider
{
    public interface IContentSet
    {
        /// <summary>
        ///     Gets the value of the content entry named <paramref name="name"/> as a string.
        /// </summary>
        /// <param name="name">The content entry name.</param>
        /// <returns>The content value as a string, if found; otherwise <c>null</c>.</returns>
        Task<string> GetAsString(string name);

        /// <summary>
        ///     Gets the value of the content entry named <paramref name="name"/> as a byte array.
        /// </summary>
        /// <param name="name">The content entry name.</param>
        /// <returns>The content value as a byte array, if found; otherwise <c>null</c>.</returns>
        Task<byte[]> GetAsBinary(string name);

        //TODO: GetRandom methods
    }
}
