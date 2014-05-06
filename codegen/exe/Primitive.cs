﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGen
{
    //
    // Primitive types are the "non-D2D types". For example: UINT, WCHAR, HWND, DWRITE_GLYPH_RUN.
    // By convention, in the XML, they are defined under the root node, not in any namespace.
    // 
    // One key reason this codegen needs to know about primitive types is in order to reference
    // D2D's color type. In the XML, D3DCOLORVALUE is a Primitive, later typedefed to D2D::COLOR_F,
    // later typedefed to D2D1::COLOR_F. The name "D2D1::COLOR_F" is used throughout all the API
    // XML to refer to color.
    //
    ///
    public class Primitive : QualifiableType
    {
        [XmlAttributeAttribute]
        public string Name;

        public override string ProjectedName
        {
            get { return Name; }
        }
        public override string NativeName
        {
            get { return Name; }
        }

        public override string ProjectedNameIncludingIndirection
        {
            get { return ProjectedName; }
        }
    }
}
