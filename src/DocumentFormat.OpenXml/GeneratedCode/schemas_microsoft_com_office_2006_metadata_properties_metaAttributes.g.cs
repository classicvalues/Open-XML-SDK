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

namespace DocumentFormat.OpenXml.Office.MetaAttributes
{
    /// <summary>
    /// <para>Defines the Dummy Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ma:DummyContentTypeElement.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(41, "DummyContentTypeElement")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Dummy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Dummy class.
        /// </summary>
        public Dummy() : base()
        {
        }

        /// <summary>
        /// <para>decimals</para>
        /// <para>Represents the following attribute in the schema: decimals</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "decimals")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Decimals
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>default</para>
        /// <para>Represents the following attribute in the schema: default</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "default")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Default
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "description")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayName</para>
        /// <para>Represents the following attribute in the schema: displayName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "displayName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DisplayName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fieldsID</para>
        /// <para>Represents the following attribute in the schema: fieldsID</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fieldsID")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FieldsID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>format</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "format")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Format
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Hidden
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>index</para>
        /// <para>Represents the following attribute in the schema: index</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "index")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Index
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>internalName</para>
        /// <para>Represents the following attribute in the schema: internalName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "internalName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? InternalName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>LCID</para>
        /// <para>Represents the following attribute in the schema: LCID</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "LCID")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? LCID
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>list</para>
        /// <para>Represents the following attribute in the schema: list</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "list")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? List
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>percentage</para>
        /// <para>Represents the following attribute in the schema: percentage</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "percentage")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Percentage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>readOnly</para>
        /// <para>Represents the following attribute in the schema: readOnly</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "readOnly")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ReadOnly
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>requiredMultiChoice</para>
        /// <para>Represents the following attribute in the schema: requiredMultiChoice</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "requiredMultiChoice")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RequiredMultiChoice
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>root</para>
        /// <para>Represents the following attribute in the schema: root</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "root")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>? Root
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showField</para>
        /// <para>Represents the following attribute in the schema: showField</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "showField")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ShowField
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>web</para>
        /// <para>Represents the following attribute in the schema: web</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "web")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Web
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(41, "DummyContentTypeElement");
            builder.AddElement<Dummy>()
.AddAttribute(0, "decimals", a => a.Decimals)
.AddAttribute(0, "default", a => a.Default)
.AddAttribute(0, "description", a => a.Description)
.AddAttribute(0, "displayName", a => a.DisplayName)
.AddAttribute(0, "fieldsID", a => a.FieldsID)
.AddAttribute(0, "format", a => a.Format)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "index", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
})
.AddAttribute(0, "internalName", a => a.InternalName)
.AddAttribute(0, "LCID", a => a.LCID)
.AddAttribute(0, "list", a => a.List)
.AddAttribute(0, "percentage", a => a.Percentage)
.AddAttribute(0, "readOnly", a => a.ReadOnly)
.AddAttribute(0, "requiredMultiChoice", a => a.RequiredMultiChoice)
.AddAttribute(0, "root", a => a.Root)
.AddAttribute(0, "showField", a => a.ShowField)
.AddAttribute(0, "web", a => a.Web, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Dummy>(deep);
    }

    /// <summary>
    /// Defines the TrueOnlyValues enumeration.
    /// </summary>
    public enum TrueOnlyValues
    {
        /// <summary>
        /// true.
        /// <para>When the item is serialized out as xml, its value is "true".</para>
        /// </summary>
        [EnumString("true")]
        True
    }
}