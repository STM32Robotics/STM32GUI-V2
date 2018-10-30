using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STM32GUI
{
    public class XController
    {
        public Controller controller;
        public Gamepad gamepad;
        public bool connected = false;
        public int deadband = 2500;
        public Point leftThumb, rightThumb = new Point(0, 0);
        public float leftTrigger, rightTrigger;
        public bool rightThumbDown = false;
        public bool leftThumbDown = false;
        public bool AButton = false;
        public bool BButton = false;
        public bool XButton = false;
        public bool YButton = false;
        public bool LBButton = false;
        public bool RBButton = false;
        public bool UpButton = false;
        public bool DownButton = false;
        public bool LeftButton = false;
        public bool RightButton = false;

        public XController()
        {
            controller = new Controller(UserIndex.One);
            connected = controller.IsConnected;
        }

        public void Update()
        {
            connected = controller.IsConnected;
            if (!connected)
                return;
            gamepad = controller.GetState().Gamepad;

            leftTrigger = gamepad.LeftTrigger;
            rightTrigger = gamepad.RightTrigger;

            if (gamepad.LeftThumbX < deadband && gamepad.LeftThumbX > -deadband)
            {
                gamepad.LeftThumbX = 0;
            }
            if (gamepad.LeftThumbY < deadband && gamepad.LeftThumbY > -deadband)
            {
                gamepad.LeftThumbY = 0;
            }
            if (gamepad.RightThumbX < deadband && gamepad.RightThumbX > -deadband)
            {
                gamepad.RightThumbX = 0;
            }
            if (gamepad.RightThumbY < deadband && gamepad.RightThumbY > -deadband)
            {
                gamepad.RightThumbY = 0;
            }

            int leftThumbX = (int)((float)gamepad.LeftThumbX / short.MaxValue * 100.0f);

            int leftThumbY = (int)((float)gamepad.LeftThumbY / short.MaxValue * 100.0f);

            int rightThumbX = (int)((float)gamepad.RightThumbX / short.MaxValue * 100.0f);

            int rightThumbY = (int)((float)gamepad.RightThumbY / short.MaxValue * 100.0f);

            leftThumb = new Point(leftThumbX, leftThumbY);
            rightThumb = new Point(rightThumbX, rightThumbY);

            rightThumbDown = gamepad.Buttons.HasFlag(GamepadButtonFlags.RightThumb);
            leftThumbDown = gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftThumb);
            AButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
            BButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
            XButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
            YButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
            LBButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder);
            RBButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder);
            UpButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
            DownButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
            LeftButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
            RightButton = gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);
        }
    }

    public class SerialPortProgram
    {
        public object LockObjectSend = new object();
        public object LockObjectReceive = new object();
        public XController controller;
        MainWindowForm platform;
        string Buffer = "";
        public SerialPort port;
        private int Try = 0;
        public List<string> Errors = new List<string>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timr2 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timr3 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timr4 = new System.Windows.Forms.Timer();
        public SerialPortProgram(MainWindowForm plat)
        {
            controller = new XController();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = 200;
            timer.Enabled = true;
            timer.Start();
            timr2.Tick += new EventHandler(timerTick2);
            timr2.Interval = 100;
            timr2.Enabled = true;
            timr2.Start();
            platform = plat;
            timr3.Tick += new EventHandler(timerTick3);
            timr3.Interval = 400;
            timr3.Enabled = true;
            timr3.Start();
            timr4.Tick += new EventHandler(timerTick4);
            timr4.Interval = 500;
            timr4.Enabled = true;
            timr4.Start();
        }

        bool OnlineCheck = false;
        bool OnlineCheckReceived = false;
        bool IsOnline = false;
        void timerTick4(object sender, EventArgs e)
        {
            if (controller.connected)
            {
                SendString("type local");
                Control d = platform.Controls.Find("localButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = true;
                });
                d = platform.Controls.Find("remoteButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = false;
                });
            }
            else
            {
                SendString("type remote");
                Control d = platform.Controls.Find("localButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = false;
                });
                d = platform.Controls.Find("remoteButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = true;
                });
            }
        }
        void timerTick2(object sender, EventArgs e)
        {
            if (controller == null)
            {
                Control d = platform.Controls.Find("controllerButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Text = "Controller\nDisconnected";
                });
                return;
            }
                
            controller.Update();

            if(!controller.connected)
            {
                Control d = platform.Controls.Find("controllerButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Text = "Controller\nDisconnected";
                });
            }
            else
            {
                Control d = platform.Controls.Find("controllerButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Text = "Controller\nConnected";
                });
            }

            if (controller.connected && controller.LeftButton)
            {
                SendString("stepper init");
            }
            else
            {
                int lM = 0;
                int rM = 0;
                int stepper = 0;
                int servo = 90;
                if (controller.connected)
                {
                    lM = controller.leftThumb.Y + controller.leftThumb.X;
                    rM = controller.leftThumb.Y - controller.leftThumb.X;
                    if(controller.rightThumb.X > 50 || controller.rightThumb.X < -50)
                        stepper = controller.rightThumb.X;
                    if (controller.rightThumb.Y > 0)
                        servo += controller.rightThumb.Y;
                }
                SendString("motor " + lM.ToString() + " " + rM.ToString());
                SendString("stepper " + stepper.ToString());
                SendString("servo " + servo.ToString());
            }
        }

        void timerTick3(object sender, EventArgs e)
        {
            if (OnlineCheckReceived == false)
            {
                IsOnline = false;
                Control d = platform.Controls.Find("offlineStatusButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = true;
                });
                d = platform.Controls.Find("pendingStatusButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = false;
                });
                d = platform.Controls.Find("onlineStatusButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = false;
                });

                d = platform.Controls.Find("autonomousButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("returnButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("cameraButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("controllerButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("errorButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("OTAButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("resetButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("uidButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("uidLabel", true).First();
                d.Invoke((Action)delegate
                {
                    d.Text = "UID: xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
                });
                d = platform.Controls.Find("sendButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
                d = platform.Controls.Find("commandBox", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = false;
                });
            }
            else
            {
                IsOnline = true;
                Control d = platform.Controls.Find("offlineStatusButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = false;
                });
                d = platform.Controls.Find("pendingStatusButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = false;
                });
                d = platform.Controls.Find("onlineStatusButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Visible = true;
                });

                d = platform.Controls.Find("autonomousButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("returnButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("cameraButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("controllerButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("errorButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("OTAButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("resetButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("uidButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("sendButton", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
                d = platform.Controls.Find("commandBox", true).First();
                d.Invoke((Action)delegate
                {
                    d.Enabled = true;
                });
            }

            OnlineCheck = true;
            OnlineCheckReceived = false;
        }

        void timerTick(object sender, EventArgs e)
        {
            SendStringDelay("online", 5);
        }

        public void port_data(object sender, SerialDataReceivedEventArgs e)
        {
            lock (LockObjectReceive)
            {
                char x = (char)port.ReadChar();
                if (x == '\r')
                {
                    if (OnlineCheck && Buffer.Contains("online"))
                    {
                        OnlineCheck = false;
                        OnlineCheckReceived = true;
                    }
                    else if (Buffer.Contains("UID:"))
                    {
                        Control c = platform.Controls.Find("uidLabel", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = Buffer;
                        });
                    }
                    else if(Buffer.Contains("msp "))
                    {
                        string[] args = Buffer.Split(' ');
                        if(args.Length >= 5)
                        {
                            Control c = platform.Controls.Find("motor1Button", true).First();
                            c.Invoke((Action)delegate
                            {
                                if(args[2] == "1")
                                    c.Text = "Motor 1: -" + args[1] + "%";
                                else
                                    c.Text = "Motor 1: " + args[1] + "%";
                            });
                            c = platform.Controls.Find("motor2Button", true).First();
                            c.Invoke((Action)delegate
                            {
                                if (args[4] == "1")
                                    c.Text = "Motor 2: -" + args[3] + "%";
                                else
                                    c.Text = "Motor 2: " + args[3] + "%";
                            });
                        }
                    }
                    else if (Buffer.Contains("led"))
                    {
                        /*if (Buffer.Contains("green"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.Green;
                            });
                        }
                        else if (Buffer.Contains("red"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.Red;
                            });
                        }
                        else if (Buffer.Contains("blue"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.Blue;
                            });
                        }
                        else if (Buffer.Contains("yellow"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.Yellow;
                            });
                        }
                        else if (Buffer.Contains("off"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.LightGray;
                            });
                        }
                        else if (Buffer.Contains("magenta"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.Magenta;
                            });
                        }
                        else if (Buffer.Contains("cyan"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.Cyan;
                            });
                        }
                        else if (Buffer.Contains("white"))
                        {
                            Control c = platform.Controls.Find("LEDButton", true).First();
                            c.Invoke((Action)delegate
                            {
                                c.BackColor = System.Drawing.Color.White;
                            });
                        }*/
                    }
                    else if (!Buffer.Contains("online"))
                    {
                        Try++;
                        Control c = platform.Controls.Find("errorButton", true).First();
                        c.Invoke((Action)delegate
                        {
                            c.Text = "Logs: " + Try;
                        });
                        Errors.Add(Buffer);
                    }
                    Buffer = "";
                }
                else
                {
                    Buffer += x;
                }
                //port.DiscardInBuffer();
            }
        }

        public void SendString(string str)
        {
            if (port == null)
                return;
            if (!port.IsOpen)
                return;
            lock (LockObjectSend)
            {
                string[] arr = str.Split(' ');
                arr[0] = arr[0].ToLower();
                string newstr = string.Join(" ", arr);
                //str = str.ToLower();
                port.Write(newstr + '\r');
                port.DiscardOutBuffer();
            }
        }

        public void SendStringDelay(string str, int delay)
        {
            if (port == null)
                return;
            if (!port.IsOpen)
                return;
            lock (LockObjectSend)
            {
                string[] arr = str.Split(' ');
                arr[0] = arr[0].ToLower();
                string newstr = string.Join(" ", arr);
                //str = str.ToLower();
                port.Write(newstr + '\r');
                port.DiscardOutBuffer();
                Thread.Sleep(delay);
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindowForm form = new MainWindowForm();
            form.portProgram = new SerialPortProgram(form);
            Application.Run(form);
        }
    }
}
