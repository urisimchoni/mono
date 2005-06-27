//
// System.Web.UI.PartialCachingAttribute.cs
//
// Duncan Mak  (duncan@ximian.com)
//
// (C) Ximian, Inc.
//

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

using System;

namespace System.Web.UI {

	[AttributeUsage (AttributeTargets.Class)]
	public sealed class PartialCachingAttribute : Attribute
	{
		int duration;
		string varyByControls;
		string varyByCustom;
		string varyByParams;
#if NET_1_1
		bool shared;
#endif
		
		public PartialCachingAttribute (int duration)
		{
			this.duration = duration;
		}

		public PartialCachingAttribute (int duration, string varyByParams,
						string varyByControls, string varyByCustom)
		{
			this.duration = duration;
			this.varyByParams = varyByParams;
			this.varyByControls = varyByControls;
			this.varyByCustom = varyByCustom;
		}

#if NET_1_1
		public PartialCachingAttribute (int duration, string varyByParams, string varyByControls,
						string varyByCustom, bool shared)
		{
			this.duration = duration;
			this.varyByParams = varyByParams;
			this.varyByControls = varyByControls;
			this.varyByCustom = varyByCustom;
			this.shared = shared;
		}
#endif

		public int Duration {
			get { return duration; }
		}

		public string VaryByParams {
			get { return varyByParams; }
		}

		public string VaryByControls {
			get { return varyByControls; }
		}

		public string VaryByCustom {
			get { return varyByCustom; }
		}

#if NET_1_1
		public bool Shared {
			get { return shared; }
		}
#endif
	}
}
