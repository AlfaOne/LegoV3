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
//			Motor motor = new Motor (MotorPort.OutA);
//			motor.SetSpeed (50);
//			Thread.Sleep (3000);
//			motor.Off ();
//			Lcd.Clear ();
//			Lcd.Update ();
//
			//Motor Poort B
			Motor motorB = new Motor (MotorPort.OutB);
//			motorB.SetSpeed (50);
//			Thread.Sleep (3000);
//			motorB.Off ();
//			Lcd.Clear ();
//			Lcd.Update ();
		
			//kijken of de sensor werkt 
			MonoBrickFirmware.Sensors.EV3UltrasonicSensor UltraSensor = new MonoBrickFirmware.Sensors.EV3UltrasonicSensor (MonoBrickFirmware.Sensors.SensorPort.In1);
			int distance = UltraSensor.Read ();
			Console.WriteLine ("Distance " + distance);

			if (distance >100) {
				Console.WriteLine ("boven 100");
				motorB.SetSpeed (50);
							Thread.Sleep (3000);
							motorB.Off ();
							Lcd.Clear ();
							Lcd.Update ();
			}





		}
	}
}

