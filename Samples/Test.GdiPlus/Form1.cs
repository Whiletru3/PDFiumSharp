using System;
using System.Drawing;
using System.Windows.Forms;
using PDFiumSharp;

namespace Test.GdiPlus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			using (var doc = new PdfDocument("TestDoc.pdf", "password"))
			{
				var page = doc.Pages[0];
				Bitmap bitmap = new Bitmap((int)page.Width, (int)page.Height);
				page.Render(bitmap);
				this.pictureBox1.Image = bitmap;
			}
		}
	}
}
