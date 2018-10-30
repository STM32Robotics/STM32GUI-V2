using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STM32GUI
{
    public partial class MainWindowForm : Form
    {
        public SerialPortProgram portProgram;

        private bool _isDragging = false;
        Point _prevMousePos = MousePosition;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void MainWindowForm_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _prevMousePos = MousePosition;
        }

        private void MainWindowForm_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void MainWindowForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point mousePos = MousePosition;
                int deltaX = (mousePos.X - _prevMousePos.X);
                int deltaY = (mousePos.Y - _prevMousePos.Y);

                Location = new Point(Location.X + deltaX, Location.Y + deltaY);

                _prevMousePos = MousePosition;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point mousePos = MousePosition;
                int deltaX = (mousePos.X - _prevMousePos.X);
                int deltaY = (mousePos.Y - _prevMousePos.Y);

                Location = new Point(Location.X + deltaX, Location.Y + deltaY);

                _prevMousePos = MousePosition;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _prevMousePos = MousePosition;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point mousePos = MousePosition;
                int deltaX = (mousePos.X - _prevMousePos.X);
                int deltaY = (mousePos.Y - _prevMousePos.Y);

                Location = new Point(Location.X + deltaX, Location.Y + deltaY);

                _prevMousePos = MousePosition;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _prevMousePos = MousePosition;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            portProgram.SendString("" + commandBox.Text);
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            onlineStatusButton.Visible = false;
            pendingStatusButton.Visible = false;
            localButton.Visible = false;
            remoteButton.Visible = false;
            autonomousButton.Enabled = false;
            returnButton.Enabled = false;
            cameraButton.Enabled = false;
            controllerButton.Enabled = false;
            errorButton.Enabled = false;
            OTAButton.Enabled = false;
            resetButton.Enabled = false;
            uidButton.Enabled = false;
            sendButton.Enabled = false;
            commandBox.Enabled = false;
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                portComboBox.Items.Add(port);
            }
        }

        private void portRefreshButton_Click(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portComboBox.Items.Add(port);
            }
        }

        private void uidButton_Click(object sender, EventArgs e)
        {
            portProgram.SendString("getuid");
        }

        private void portComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if(portProgram.port != null)
                portProgram.port.Close();
            if (portComboBox.SelectedItem == null)
                return;
            if (portComboBox.SelectedItem.ToString() == "")
                return;
            portProgram.port = new SerialPort(portComboBox.SelectedItem.ToString(), 115200, Parity.None, 8, StopBits.One);
            portProgram.port.DataReceived += new SerialDataReceivedEventHandler(portProgram.port_data);
            portProgram.port.Handshake = Handshake.None;
            portProgram.port.ReadBufferSize = 8192;
            portProgram.port.WriteBufferSize = 128;
            portProgram.port.ReadTimeout = 25;
            portProgram.port.WriteTimeout = 25;
            portProgram.port.Open();
            portProgram.port.DiscardInBuffer();
            portProgram.port.DiscardOutBuffer();
            portProgram.port.DtrEnable = true;
            portProgram.port.RtsEnable = true;

            portProgram.SendString("handshake");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            portProgram.SendString("reset");
        }

        private void commandBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                if (commandBox.Text == "")
                    return;
                portProgram.SendString(commandBox.Text);
            }
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Logs";
            form.Size = new Size(350, 500);
            RichTextBox box = new RichTextBox();
            box.Location = new Point(0, 0);
            box.Size = new Size(350, 500);
            form.Controls.Add(box);
            int x = 0;
            foreach(string str in portProgram.Errors)
            {
                box.Text += "[" + x + "]" + str + "\n";
                x++;
            }
            form.Show();
        }

        private void OTAButton_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 0)
                MessageBox.Show("No file detected.");
            else
            {
                string[] file = files[0].Split('.');
                if(file.Length != 2)
                {
                    MessageBox.Show("File format invalid. Missing extension.");
                }
                else
                {
                    if (file[1].ToLower() != "hex")
                    {
                        MessageBox.Show("File format invalid. Not a hex file.");
                    }
                    else
                    {
                        MessageBox.Show("File: " + files[0]);
                    }
                }
            }
        }

        private void OTAButton_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        Form camForm = null;
        bool isCamOpen = false;
        private void cameraButton_Click(object sender, EventArgs e)
        {
            isCamOpen = !isCamOpen;
            if(!isCamOpen)
            {
                if(camForm != null)
                {
                    camForm.Close();
                    camForm = null;
                }
            }
            else
            {
                if (camForm != null)
                {
                    camForm.Close();
                    camForm = null;
                }
                camForm = new Form();
                camForm.FormBorderStyle = FormBorderStyle.None;
                camForm.Text = "Camera Stream";
                camForm.Size = new Size(700, 700);
                PictureBox box = new PictureBox();
                box.MouseUp += cameraMouseUp;
                box.MouseDown += cameraMouseDown;
                box.MouseMove += cameraMouseMove;
                box.Location = new Point(0, 0);
                box.Size = new Size(700, 700);
                camForm.Controls.Add(box);
                camForm.Show();
            }
        }

        private void cameraMouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void cameraMouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _prevMousePos = MousePosition;
        }

        private void cameraMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point mousePos = MousePosition;
                int deltaX = (mousePos.X - _prevMousePos.X);
                int deltaY = (mousePos.Y - _prevMousePos.Y);

                camForm.Location = new Point(camForm.Location.X + deltaX, camForm.Location.Y + deltaY);

                _prevMousePos = MousePosition;
            }
        }
    }
}
