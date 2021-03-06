﻿// ****************************************************************************
// <copyright file="StreamWriterExtensions.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2011
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>03-01-2012</date>
// <project>Cimbalino.Phone.Toolkit</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System.Collections.Generic;
using System.IO;

namespace Cimbalino.Phone.Toolkit.Extensions
{
    /// <summary>
    /// Provides a set of static (Shared in Visual Basic) methods for <see cref="StreamWriter"/> instances.
    /// </summary>
    public static class StreamWriterExtensions
    {
        /// <summary>
        /// Writes all lines.
        /// </summary>
        /// <param name="streamWriter">The stream writer.</param>
        /// <param name="lines">The lines.</param>
        public static void WriteAllLines(this StreamWriter streamWriter, IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                streamWriter.WriteLine(line);
            }
        }
    }
}