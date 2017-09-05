
using System;
using MonoBrickFirmware;
using MonoBrickFirmware.Display.Dialogs;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Movement;
using System.Threading;

namespace MonoBrickHelloWorld
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Motor motor = new Motor (MotorPort.OutA);
			motor.SetSpeed (50);
			Thread.Sleep (3000);
			motor.Off ();
			Lcd.Clear ();
			Lcd.Update ();
			// hello test
		}
	}
}

