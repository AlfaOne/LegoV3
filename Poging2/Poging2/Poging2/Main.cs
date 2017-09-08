using System;
using MonoBrickFirmware;
using MonoBrickFirmware.Sensors;
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
		
			//Hefarm
			Motor motorC = new Motor (MotorPort.OutC);
			motorC.SetSpeed (20);
			Thread.Sleep (1000);
			motorC.SetSpeed (-20);
			Thread.Sleep (1000);
			motorC.Off ();

			//UltraSonic Sensor
			MonoBrickFirmware.Sensors.EV3UltrasonicSensor UltraSensor = new MonoBrickFirmware.Sensors.EV3UltrasonicSensor (MonoBrickFirmware.Sensors.SensorPort.In1);
			int distance = UltraSensor.Read ();
			Console.WriteLine ("Distance " + distance);


			motor.SetSpeed (100);
			motorB.SetSpeed (-100);
			Thread.Sleep (4000);
			motor.Off ();
			motorB.Off ();

			if (distance < 30) {
				motor.Off ();
				motorB.Off ();
			}

//			if (distance >100) {
//				Console.WriteLine ("boven 100");
//				motor.SetSpeed (-30);
//				motorB.SetSpeed (-30);
//
//							Thread.Sleep (1000);
//				motor.Off ();
//							motorB.Off ();
//							Lcd.Clear ();
//							Lcd.Update ();
//			}





		}
	}
}

