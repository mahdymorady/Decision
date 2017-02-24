﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics;

namespace Decision.Common.Experimental.ObjectPool.Pools
{
    /// <summary>
    ///     Copied from Microsoft Roslyn code at
    ///     http://source.roslyn.codeplex.com/#Microsoft.CodeAnalysis/PooledDictionary.cs,ebb1ac303c777646
    ///     Dictionary that can be recycled via an object pool.
    ///     NOTE: these dictionaries always have the default comparer.
    /// </summary>
    internal class PooledDictionary<K, V> : Dictionary<K, V>
    {
        // global pool
        private static readonly ObjectPool<PooledDictionary<K, V>> s_poolInstance = CreatePool();
        private readonly ObjectPool<PooledDictionary<K, V>> _pool;

        private PooledDictionary(ObjectPool<PooledDictionary<K, V>> pool)
        {
            _pool = pool;
        }

        public void Free()
        {
            Clear();
            if (_pool != null)
            {
                _pool.Free(this);
            }
        }

        // if someone needs to create a pool;
        public static ObjectPool<PooledDictionary<K, V>> CreatePool()
        {
            ObjectPool<PooledDictionary<K, V>> pool = null;
            pool = new ObjectPool<PooledDictionary<K, V>>(() => new PooledDictionary<K, V>(pool), 128);
            return pool;
        }

        public static PooledDictionary<K, V> GetInstance()
        {
            var instance = s_poolInstance.Allocate();
            Debug.Assert(instance.Count == 0);
            return instance;
        }
    }
}