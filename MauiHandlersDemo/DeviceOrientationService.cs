using System;
namespace MauiHandlersDemo
{
	public enum DeviceOrientation
	{
		Undefined,
		Landscape,
		Portrait
	}

	public partial class DeviceOrientationService
	{
		public partial DeviceOrientation GetOrientation();
	}
}

