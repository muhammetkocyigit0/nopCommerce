﻿using Nop.Core.Caching;

namespace Nop.Services.Caching.CachingDefaults
{
    /// <summary>
    /// Represents default values related to media services
    /// </summary>
    public static partial class NopMediaCachingDefaults
    {
        /// <summary>
        /// Gets a key to cache whether thumb exists
        /// </summary>
        /// <remarks>
        /// {0} : thumb file name
        /// </remarks>
        public static CacheKey ThumbExistsCacheKey => new CacheKey("Nop.azure.thumb.exists-{0}", ThumbsExistsPrefixCacheKey);

        /// <summary>
        /// Gets a key pattern to clear cache
        /// </summary>
        public static string ThumbsExistsPrefixCacheKey => "Nop.azure.thumb.exists";

        /// <summary>
        /// Gets a key to cache
        /// </summary>
        /// <remarks>
        /// {0} : virtual path
        /// </remarks>
        public static CacheKey PicturesByVirtualPathCacheKey => new CacheKey("Nop.pictures.virtualpath-{0}");
    }
}