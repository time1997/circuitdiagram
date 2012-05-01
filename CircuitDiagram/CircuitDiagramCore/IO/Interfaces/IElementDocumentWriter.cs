﻿// IElementDocumentWriter.cs
//
// Circuit Diagram http://www.circuit-diagram.org/
//
// Copyright (C) 2012  Sam Fisher
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CircuitDiagram.IO
{
    /// <summary>
    /// Provides methods to write an IODocument to a stream, in the form of components and/or connections.
    /// </summary>
    public interface IElementDocumentWriter
    {
        /// <summary>
        /// The save options to use.
        /// </summary>
        ISaveOptions Options { get; set; }

        /// <summary>
        /// The document to write.
        /// </summary>
        IODocument Document { get; set; }

        /// <summary>
        /// Initializes the document writer, before the write method is called.
        /// </summary>
        void Begin();

        /// <summary>
        /// Writes the document to the stream.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        void Write(Stream stream);

        /// <summary>
        /// Closes the document writer, after the write method has been called.
        /// </summary>
        void End();
    }
}