
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
/**
 * Namespace:   System.Web.UI.Design.WebControls
 * Class:       AdRotatorDesigner
 *
 * Author:      Gaurav Vaish
 * Maintainer:  gvaish_mono@lycos.com
 *
 * (C) Gaurav Vaish (2002)
 */

using System;
using System.IO;
using System.Web.UI.WebControls;
using System.Web.UI.Design;

namespace System.Web.UI.Design.WebControls
{
	public class AdRotatorDesigner : ControlDesigner
	{
		public AdRotatorDesigner() : base()
		{
		}

		public override string GetDesignTimeHtml()
		{
			if(Component != null && Component is AdRotator)
			{
				AdRotator      toDesign = (AdRotator)Component;
				HtmlTextWriter writer   = new HtmlTextWriter(new StringWriter());
				HyperLink      link     = new HyperLink();
				Image          disp     = new Image();

				link.ID          = toDesign.ID;
				link.NavigateUrl = String.Empty;
				link.Target      = toDesign.Target;
				link.AccessKey   = toDesign.AccessKey;
				link.Enabled     = toDesign.Enabled;
				link.TabIndex    = toDesign.TabIndex;

				disp.ApplyStyle(toDesign.ControlStyle);
				disp.ImageUrl      = String.Empty;
				disp.AlternateText = toDesign.ID;
				disp.ToolTip       = toDesign.ToolTip;

				link.RenderBeginTag(writer);
				link.RenderControl(writer);
				link.RenderEndTag(writer);

				return writer.ToString();
			}
			return String.Empty;
		}
	}
}
