﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.DocumentHighlighting;

namespace Microsoft.CodeAnalysis.EmbeddedLanguages.LanguageServices
{
    /// <summary>
    /// Services related to a specific embedded language.
    /// </summary>
    internal interface IFeaturesEmbeddedLanguage : IEmbeddedLanguage
    {
        /// <summary>
        /// A optional highlighter that can highlight spans for an embedded language string.
        /// </summary>
        IDocumentHighlightsService Highlighter { get; }

        /// <summary>
        /// An optional analyzer that produces diagnostics for an embedded language string.
        /// </summary>
        DiagnosticAnalyzer DiagnosticAnalyzer { get; }

        /// <summary>
        /// An optional fix provider that can fix the diagnostics produced by <see
        /// cref="DiagnosticAnalyzer"/>
        /// </summary>
        SyntaxEditorBasedCodeFixProvider CodeFixProvider { get; }
    }
}
