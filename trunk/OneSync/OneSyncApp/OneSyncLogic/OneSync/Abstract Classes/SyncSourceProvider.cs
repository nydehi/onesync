﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneSync.Synchronization
{
    /// <summary>
    /// Class to manage, provide and persist SyncSource information
    /// </summary>
    public abstract class SyncSourceProvider
    {
        // Path to where SyncSource are saved.
        protected string _storagePath;

        /// <summary>
        /// Creates a SyncSource Provider
        /// </summary>
        /// <param name="storagePath">Location where all SyncSource are saved to or loaded from.</param>
        public SyncSourceProvider(string storagePath)
        {
            _storagePath = storagePath;   
        }


        /// <summary>
        /// Adds a SyncSource.
        /// </summary>
        /// <param name="s">SyncSource to be added.</param>
        /// <returns>true if successfully added.</returns>
        public abstract bool Add(SyncSource s);


        /// <summary>
        /// Loads all saved SyncSource.
        /// </summary>
        /// <returns>List of SyncSource.</returns>
        public abstract IList<SyncSource> LoadAll();


        /// <summary>
        /// Update outdated SyncSource.
        /// </summary>
        /// <param name="source">Updated SyncSource.</param>
        /// <returns>true if update is successful.</returns>
        public abstract bool Update(SyncSource source);


        /// <summary>
        /// Returns the number of SyncSource saved in <see cref="StoragePath"/>.
        /// </summary>
        /// <returns></returns>
        public abstract int GetSyncSourceCount();

        /// <summary>
        /// Create default schema
        /// </summary>
        public abstract void CreateSchema();


        #region Public Properties

        /// <summary>
        /// Location where all SyncSource are saved to or loaded from.
        /// </summary>
        public string StoragePath
        {
            get { return _storagePath; }
        }

        #endregion
    }
}
