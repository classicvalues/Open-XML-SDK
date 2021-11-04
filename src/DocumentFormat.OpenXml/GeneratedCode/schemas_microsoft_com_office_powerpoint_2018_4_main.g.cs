﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Presentation
{
    /// <summary>
    /// <para>Defines the ClassificationOutcome Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p184:classification.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(91, "classification")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ClassificationOutcome : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ClassificationOutcome class.
        /// </summary>
        public ClassificationOutcome() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Presentation.ClassificationOutcomeType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(91, "classification");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<ClassificationOutcome>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClassificationOutcome>(deep);
    }

    /// <summary>
    /// Defines the ClassificationOutcomeType enumeration.
    /// </summary>
    public enum ClassificationOutcomeType
    {
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// hdr.
        /// <para>When the item is serialized out as xml, its value is "hdr".</para>
        /// </summary>
        [EnumString("hdr")]
        Hdr,
        /// <summary>
        /// ftr.
        /// <para>When the item is serialized out as xml, its value is "ftr".</para>
        /// </summary>
        [EnumString("ftr")]
        Ftr,
        /// <summary>
        /// watermark.
        /// <para>When the item is serialized out as xml, its value is "watermark".</para>
        /// </summary>
        [EnumString("watermark")]
        Watermark
    }
}