#region Copyright and License
/*
This file is part of PDFiumSharp, a wrapper around the PDFium library for the .NET framework.
Copyright (C) 2017 Tobias Meyer
License: Microsoft Reciprocal License (MS-RL)
*/
#endregion
using System.Runtime.InteropServices;

namespace PDFiumSharp.Types
{
	/// <summary>
	/// Rectangle area(float) in device or page coordinate system.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct FS_RECTF
    {
		/// <summary>
		/// The x-coordinate of the left-top corner.
		/// </summary>
		public float Left { get; }

		/// <summary>
		/// The y-coordinate of the left-top corner.
		/// </summary>
		public float Top { get; }

		/// <summary>
		/// The x-coordinate of the right-bottom corner.
		/// </summary>
		public float Right { get; }

		/// <summary>
		/// The y-coordinate of the right-bottom corner.
		/// </summary>
		public float Bottom { get; }

		public FS_RECTF(float left, float top, float right, float bottom)
		{
			Left = left;
			Top = top;
			Right = right;
			Bottom = bottom;
		}
	}
}
