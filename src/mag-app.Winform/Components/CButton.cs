using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Winform.Components
{
	public class CButton : Button
	{
		public CButton()
		{
			UseVisualStyleBackColor = false;
			TextImageRelation = TextImageRelation.ImageAboveText;
		}
		public override string Text
		{
			get { return ""; }
			set { base.Text = value; }
		}
		public string LeftText { get; set; }
		public string RightText { get; set; }
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Rectangle rect = ClientRectangle;
			rect.Inflate(-5, -5);
			using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Far })
			{
				using (Brush brush = new SolidBrush(ForeColor))
				{
					pevent.Graphics.DrawString(LeftText, Font, brush, rect, sf);
					sf.Alignment = StringAlignment.Far;
					pevent.Graphics.DrawString(RightText, Font, brush, rect, sf);
				}
			}
		}
	}
}
