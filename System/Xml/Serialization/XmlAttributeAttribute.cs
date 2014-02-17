// Copyright (C) 2014 dot42
//
// Original filename: XmlAttributeAttribute.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Xml.Schema;

namespace System.Xml.Serialization
{
    /// <summary>
    /// Specifies that the XmlSerializer must serialize the class member as an XML attribute.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public class XmlAttributeAttribute : Attribute
    {
        private string attributeName;

        /// <summary>
        /// Default ctor
        /// </summary>
        public XmlAttributeAttribute()
        {            
        }

        /// <summary>
        /// Attribute name ctor
        /// </summary>
        public XmlAttributeAttribute(string attributeName)
        {
            this.attributeName = attributeName;
        }

        /// <summary>
        /// Type name ctor
        /// </summary>
        public XmlAttributeAttribute(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// Attribute name + type ctor
        /// </summary>
        public XmlAttributeAttribute(string attributeName, Type type)
        {
            this.attributeName = attributeName;
            Type = type;
        }

        /// <summary>
        /// Gets/sets the name of the XML attribute.
        /// </summary>
        public string AttributeName
        {
            get { return attributeName ?? string.Empty; }
            set { attributeName = value; }
        }

        /// <summary>
        /// Gets/sets the namespace of the XML attribute.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets/sets whether the XML element name generated by the XmlSerializer is qualified or unqualified.
        /// </summary>
        public XmlSchemaForm Form { get; set; }

        /// <summary>
        /// Gets/sets the XSD data type of the XML attribute generated by the XmlSerializer.
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets the complex type of the XML attribute.
        /// </summary>
        public Type Type { get; set; }
    }
}

