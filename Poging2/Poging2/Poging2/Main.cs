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

		public static int Gyroscope()
		{
			MonoBrickFirmware.Sensors.EV3GyroSensor Gyroskoopje = new MonoBrickFirmware.Sensors.EV3GyroSensor(MonoBrickFirmware.Sensors.SensorPort.In2);
			int graden = Gyroskoopje.Read();
			LcdConsole.WriteLine ("Graden: " + graden);
			return graden;
		}

		public static void Boombox()
		{
			MonoBrickFirmware.Sound.Speaker Magneto = new MonoBrickFirmware.Sound.Speaker(100);
			String soundfilename = "/home/root/apps/Poging2/sound/wanderer1.wav";
			Magneto.PlaySoundFile (soundfilename, 100);
			RijBepaaldeAfstand (-600);
			Magneto.Beep (500);
		}

		public static void RijBepaaldeAfstand (int i)
		{
			Motor motor = new Motor (MotorPort.OutA);
			Motor motorB = new Motor (MotorPort.OutB);
			motor.ResetTacho ();

			int n = 1;
			while (n < 6) {

				motor.SetSpeed (25);
				motorB.SetSpeed (25);
				int distance = motor.GetTachoCount ();
				int afstand = distance;

				if ( afstand < (i)) {
					motor.Off ();
					motorB.Off ();
					n = 8;
				}
				LcdConsole.WriteLine ("Afstand: " + afstand);
			}
		}

		public static void Main (string[] args)
		{
			//geluid
			Boombox ();

//			//afstand is -900
//			RijBepaaldeAfstand (-600);
//
//			//Hefarm
//			Hefarm (25, 500);
//			Hefarm (-20, 500);
//			Lcd.Clear ();
//			Lcd.Update ();



//			int n = 1;
//			while (n < 50) {
//				Gyroscope ();
//				n++;
//			}
		}
	}
	}

