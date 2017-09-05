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
		static void Main(string[] args)  
		{  
			var ev3 = new Brick<Sensor,Sensor,Sensor,Sensor>("usb");  
			try{  
				ev3.Connection.Open();  
				ev3.Vehicle.LeftPort = MotorPort.OutA;  
				ev3.Vehicle.RightPort = MotorPort.OutD;  
				ev3.Vehicle.ReverseLeft = false;  
				ev3.Vehicle.ReverseRight = false;  
				sbyte speed = 50;  
				ConsoleKeyInfo cki;    
				Console.WriteLine("Press T to quit");    
				do     
				{    
					cki = Console.ReadKey(true); //press a key    
					switch(cki.Key){      
					case ConsoleKey.W:      
						ev3.Vehicle.Forward(speed);  
						break;                                
					case ConsoleKey.S:       
						ev3.Vehicle.Backward(speed);     
						break;      
					case ConsoleKey.D:       
						ev3.Vehicle.SpinRight(speed);      
						break;      
					case ConsoleKey.A:       
						ev3.Vehicle.SpinLeft(speed);      
						break;      
					case ConsoleKey.Q:      
						ev3.Vehicle.TurnLeftForward(speed, 50);      
						break;    
					case ConsoleKey.E:      
						ev3.Vehicle.TurnRightForward(speed,50);         
						break;    
					case ConsoleKey.C:      
						ev3.Vehicle.TurnRightReverse(speed,50);    
						break;    
					case ConsoleKey.Z:    
						ev3.Vehicle.TurnLeftReverse(speed, 50);  
						break;   
					case ConsoleKey.Spacebar:    
						ev3.Vehicle.Off();  
						break;   
					}    
				} while (cki.Key != ConsoleKey.T);  
			}  
			catch(Exception e){  
				Console.WriteLine(e.StackTrace);  
				Console.WriteLine("Error: " + e.Message);  
				Console.WriteLine("Press any key to end...");  
				Console.ReadKey();                
			}  
			finally{  
				ev3.Connection.Close();  
			}  
		}  
	}
}

