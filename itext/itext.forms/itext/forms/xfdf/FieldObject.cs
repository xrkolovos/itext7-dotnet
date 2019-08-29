/*
This file is part of the iText (R) project.
Copyright (c) 1998-2019 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;

namespace iText.Forms.Xfdf {
    /// <summary>Represents the field element, a child of the fields and field elements.</summary>
    /// <remarks>
    /// Represents the field element, a child of the fields and field elements.
    /// The field element corresponds to a form field.
    /// Content model: ( field* | value* | ( value? & value-richtext? )).
    /// Required attributes: name.
    /// For more details see paragraph 6.3.2 in Xfdf document specification.
    /// </remarks>
    public class FieldObject {
        private String name;

        private String value;

        private String richTextValue;

        private bool containsRichText;

        private iText.Forms.Xfdf.FieldObject parent;

        public FieldObject() {
        }

        public FieldObject(String name, String value, bool containsRichText) {
            this.name = name;
            this.containsRichText = containsRichText;
            if (containsRichText) {
                this.richTextValue = value;
            }
            else {
                this.value = value;
            }
        }

        public virtual String GetName() {
            return name;
        }

        public virtual void SetName(String name) {
            this.name = name;
        }

        public virtual String GetValue() {
            return value;
        }

        public virtual void SetValue(String value) {
            this.value = value;
        }

        public virtual String GetRichTextValue() {
            return richTextValue;
        }

        public virtual void SetRichTextValue(String richTextValue) {
            this.richTextValue = richTextValue;
        }

        public virtual bool IsContainsRichText() {
            return containsRichText;
        }

        public virtual void SetContainsRichText(bool containsRichText) {
            this.containsRichText = containsRichText;
        }

        public virtual iText.Forms.Xfdf.FieldObject GetParent() {
            return parent;
        }

        public virtual void SetParent(iText.Forms.Xfdf.FieldObject parent) {
            this.parent = parent;
        }
    }
}