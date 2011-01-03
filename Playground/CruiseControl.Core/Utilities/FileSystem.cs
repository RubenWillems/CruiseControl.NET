﻿namespace CruiseControl.Core.Utilities
{
    using System;
    using System.IO;
    using CruiseControl.Core.Interfaces;
    using NLog;

    /// <summary>
    /// Implements the functionality for working with the file system.
    /// </summary>
    public class FileSystem
        : IFileSystem
    {
        #region Private fields
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Public methods
        #region CheckIfFileExists()
        /// <summary>
        /// Checks if a file exists.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>
        /// <c>true</c> if the file exists; <c>false</c> otherwise.
        /// </returns>
        public bool CheckIfFileExists(string filename)
        {
            logger.Trace("Checking if file '" + (filename ?? string.Empty) + "' exists");
            var exists = File.Exists(filename);
            return exists;
        }
        #endregion

        #region OpenFileForRead()
        /// <summary>
        /// Opens the file for read.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>
        /// The <see cref="Stream"/> containing the file data.
        /// </returns>
        public Stream OpenFileForRead(string filePath)
        {
            return File.Open(filePath, FileMode.Open);
        }
        #endregion
        #endregion
    }
}