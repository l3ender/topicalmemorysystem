using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Topical_Memory_System
{
	class Selection
	{
		public int Start;
		public int End;
		public Color TextColor;

		public Selection(Color c)
		{
			this.Start = 0;
			this.End = 0;
			this.TextColor = c;
		}

		public Selection(int start, int end, Color c)
		{
			this.Start = start;
			this.End = end;
			this.TextColor = c;
		}
	}
}
