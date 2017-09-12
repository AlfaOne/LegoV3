using System;
using MonoBrickFirmware;
using MonoBrickFirmware.Sensors;
using MonoBrickFirmware.Display.Dialogs;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Movement;
using MonoBrickFirmware.UserInput;
using System.Threading;
using System.Threading.Tasks;

namespace MonoBrickHelloWorld
{
	class MainClass
	{
		public static void Hefarm (sbyte i, int j)
		{
			Motor motorC = new Motor (MotorPort.OutC);
			motorC.SetSpeed (i);
			Thread.Sleep (j);
			motorC.Off ();
		}

		public static void Motoren (sbyte i, int j, sbyte k)
		{
			Motor motor = new Motor (MotorPort.OutA);
			Motor motorB = new Motor (MotorPort.OutB);
			motor.SetSpeed (i);
			motorB.SetSpeed (k);
			Thread.Sleep (j);
			motor.Off ();
			motorB.Off ();
		}
			
		public static int SensorAfstand() 
		{
			MonoBrickFirmware.Sensors.EV3UltrasonicSensor UltraSensor = new MonoBrickFirmware.Sensors.EV3UltrasonicSensor (MonoBrickFirmware.Sensors.SensorPort.In1);
			int distance = UltraSensor.Read ();
			LcdConsole.WriteLine ("Distance: "+ distance);
			return distance;
			}

		public static void Main (string[] args)
		{
//			int n = 1;
//			while (n < 6) {
//				if ( SensorAfstand() < 100) {
//					Hefarm (-10, 1000);
//				}
//				if ( SensorAfstand() > 100) {
//					Hefarm (10, 1000);
//				}
//				LcdConsole.WriteLine ("Distance: " + SensorAfstand());
//			}

			int n = 1;
						while (n < 6) {
							if ( SensorAfstand() < 100) {
					Motoren (50, 1000, 50);
							}
							if ( SensorAfstand() > 100) {
					Motoren (-50, 1000, -50);
				}
					Hefarm (20, 500);
					Hefarm (-20, 500);
							LcdConsole.WriteLine ("Distance: " + SensorAfstand());
						}

			//Hefarm
			for (int i = 0; i < 10; i++) {
				Hefarm (20, 500);
				Hefarm (-20, 500);
				if (i == 4) {
					break;
				};
				}

//				for (int x=0; x<1; x++) {
//					TastenStatus = Buttons.GetKeypress();
//					if (TastenStatus == Buttons.ButtonStates.Enter) { terminateProgram.Set();}
//				}
//
//
//			motor.SetSpeed (100);
//			motorB.SetSpeed (-100);
//			Thread.Sleep (4000);
//			motor.Off ();
//			motorB.Off ();
//
//			if (distance < 30) {
//				motor.Off ();
//				motorB.Off ();
//			}

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

