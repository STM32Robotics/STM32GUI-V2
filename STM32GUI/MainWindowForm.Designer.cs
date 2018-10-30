namespace STM32GUI
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.autonomousButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.errorButton = new System.Windows.Forms.Button();
            this.controllerButton = new System.Windows.Forms.Button();
            this.cameraButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.OTAButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.uidLabel = new System.Windows.Forms.Button();
            this.onlineStatusButton = new System.Windows.Forms.Button();
            this.offlineStatusButton = new System.Windows.Forms.Button();
            this.pendingStatusButton = new System.Windows.Forms.Button();
            this.remoteButton = new System.Windows.Forms.Button();
            this.localButton = new System.Windows.Forms.Button();
            this.motor1Button = new System.Windows.Forms.Button();
            this.motor2Button = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.stepperButton = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.portRefreshButton = new System.Windows.Forms.Button();
            this.uidButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.autonomousButton);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.errorButton);
            this.panel1.Controls.Add(this.controllerButton);
            this.panel1.Controls.Add(this.cameraButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.OTAButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 650);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 586);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(219, 64);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // autonomousButton
            // 
            this.autonomousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.autonomousButton.FlatAppearance.BorderSize = 0;
            this.autonomousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autonomousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autonomousButton.ForeColor = System.Drawing.Color.White;
            this.autonomousButton.Image = ((System.Drawing.Image)(resources.GetObject("autonomousButton.Image")));
            this.autonomousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autonomousButton.Location = new System.Drawing.Point(0, 138);
            this.autonomousButton.Margin = new System.Windows.Forms.Padding(0);
            this.autonomousButton.Name = "autonomousButton";
            this.autonomousButton.Size = new System.Drawing.Size(219, 64);
            this.autonomousButton.TabIndex = 12;
            this.autonomousButton.Text = "Go Autonomous";
            this.autonomousButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Image = ((System.Drawing.Image)(resources.GetObject("returnButton.Image")));
            this.returnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnButton.Location = new System.Drawing.Point(0, 202);
            this.returnButton.Margin = new System.Windows.Forms.Padding(0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(219, 64);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "Return Home";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // errorButton
            // 
            this.errorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.errorButton.FlatAppearance.BorderSize = 0;
            this.errorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorButton.ForeColor = System.Drawing.Color.White;
            this.errorButton.Image = ((System.Drawing.Image)(resources.GetObject("errorButton.Image")));
            this.errorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorButton.Location = new System.Drawing.Point(0, 394);
            this.errorButton.Margin = new System.Windows.Forms.Padding(0);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(219, 64);
            this.errorButton.TabIndex = 10;
            this.errorButton.Text = "Logs: 0";
            this.errorButton.UseVisualStyleBackColor = true;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // controllerButton
            // 
            this.controllerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.controllerButton.FlatAppearance.BorderSize = 0;
            this.controllerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controllerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerButton.ForeColor = System.Drawing.Color.White;
            this.controllerButton.Image = ((System.Drawing.Image)(resources.GetObject("controllerButton.Image")));
            this.controllerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.controllerButton.Location = new System.Drawing.Point(0, 330);
            this.controllerButton.Margin = new System.Windows.Forms.Padding(0);
            this.controllerButton.Name = "controllerButton";
            this.controllerButton.Size = new System.Drawing.Size(219, 64);
            this.controllerButton.TabIndex = 9;
            this.controllerButton.Text = "Controller\r\nDisconnected";
            this.controllerButton.UseVisualStyleBackColor = true;
            // 
            // cameraButton
            // 
            this.cameraButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraButton.FlatAppearance.BorderSize = 0;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraButton.ForeColor = System.Drawing.Color.White;
            this.cameraButton.Image = ((System.Drawing.Image)(resources.GetObject("cameraButton.Image")));
            this.cameraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cameraButton.Location = new System.Drawing.Point(0, 266);
            this.cameraButton.Margin = new System.Windows.Forms.Padding(0);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(219, 64);
            this.cameraButton.TabIndex = 8;
            this.cameraButton.Text = "Camera Stream";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "STM32F303RE";
            // 
            // resetButton
            // 
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetButton.Location = new System.Drawing.Point(0, 522);
            this.resetButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(219, 64);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // OTAButton
            // 
            this.OTAButton.AllowDrop = true;
            this.OTAButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OTAButton.FlatAppearance.BorderSize = 0;
            this.OTAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OTAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTAButton.ForeColor = System.Drawing.Color.White;
            this.OTAButton.Image = ((System.Drawing.Image)(resources.GetObject("OTAButton.Image")));
            this.OTAButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OTAButton.Location = new System.Drawing.Point(0, 458);
            this.OTAButton.Margin = new System.Windows.Forms.Padding(0);
            this.OTAButton.Name = "OTAButton";
            this.OTAButton.Size = new System.Drawing.Size(219, 64);
            this.OTAButton.TabIndex = 6;
            this.OTAButton.Text = "OTA Flash\r\n(Drag && Drop)\r\n";
            this.OTAButton.UseVisualStyleBackColor = true;
            this.OTAButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.OTAButton_DragDrop);
            this.OTAButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.OTAButton_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(130, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(538, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(564, 609);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(25, 25);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsButton.TabIndex = 4;
            this.settingsButton.TabStop = false;
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(232, 392);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(220, 20);
            this.commandBox.TabIndex = 5;
            this.commandBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.commandBox_KeyUp);
            // 
            // sendButton
            // 
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.Location = new System.Drawing.Point(455, 391);
            this.sendButton.Margin = new System.Windows.Forms.Padding(0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 20);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send Command";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // uidLabel
            // 
            this.uidLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uidLabel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.uidLabel.FlatAppearance.BorderSize = 0;
            this.uidLabel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.uidLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.uidLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.uidLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidLabel.ForeColor = System.Drawing.Color.White;
            this.uidLabel.Image = ((System.Drawing.Image)(resources.GetObject("uidLabel.Image")));
            this.uidLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uidLabel.Location = new System.Drawing.Point(219, 605);
            this.uidLabel.Margin = new System.Windows.Forms.Padding(0);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(274, 35);
            this.uidLabel.TabIndex = 9;
            this.uidLabel.Text = "UID: xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            this.uidLabel.UseVisualStyleBackColor = true;
            // 
            // onlineStatusButton
            // 
            this.onlineStatusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onlineStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.onlineStatusButton.FlatAppearance.BorderSize = 0;
            this.onlineStatusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.onlineStatusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.onlineStatusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.onlineStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineStatusButton.ForeColor = System.Drawing.Color.White;
            this.onlineStatusButton.Image = ((System.Drawing.Image)(resources.GetObject("onlineStatusButton.Image")));
            this.onlineStatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlineStatusButton.Location = new System.Drawing.Point(219, 570);
            this.onlineStatusButton.Margin = new System.Windows.Forms.Padding(0);
            this.onlineStatusButton.Name = "onlineStatusButton";
            this.onlineStatusButton.Size = new System.Drawing.Size(183, 35);
            this.onlineStatusButton.TabIndex = 10;
            this.onlineStatusButton.Text = "Status: Online";
            this.onlineStatusButton.UseVisualStyleBackColor = true;
            // 
            // offlineStatusButton
            // 
            this.offlineStatusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.offlineStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.offlineStatusButton.FlatAppearance.BorderSize = 0;
            this.offlineStatusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.offlineStatusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.offlineStatusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.offlineStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offlineStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineStatusButton.ForeColor = System.Drawing.Color.White;
            this.offlineStatusButton.Image = ((System.Drawing.Image)(resources.GetObject("offlineStatusButton.Image")));
            this.offlineStatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.offlineStatusButton.Location = new System.Drawing.Point(219, 570);
            this.offlineStatusButton.Margin = new System.Windows.Forms.Padding(0);
            this.offlineStatusButton.Name = "offlineStatusButton";
            this.offlineStatusButton.Size = new System.Drawing.Size(183, 35);
            this.offlineStatusButton.TabIndex = 11;
            this.offlineStatusButton.Text = "Status: Offline";
            this.offlineStatusButton.UseVisualStyleBackColor = true;
            // 
            // pendingStatusButton
            // 
            this.pendingStatusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pendingStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.pendingStatusButton.FlatAppearance.BorderSize = 0;
            this.pendingStatusButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.pendingStatusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.pendingStatusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.pendingStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingStatusButton.ForeColor = System.Drawing.Color.White;
            this.pendingStatusButton.Image = ((System.Drawing.Image)(resources.GetObject("pendingStatusButton.Image")));
            this.pendingStatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pendingStatusButton.Location = new System.Drawing.Point(219, 570);
            this.pendingStatusButton.Margin = new System.Windows.Forms.Padding(0);
            this.pendingStatusButton.Name = "pendingStatusButton";
            this.pendingStatusButton.Size = new System.Drawing.Size(183, 35);
            this.pendingStatusButton.TabIndex = 12;
            this.pendingStatusButton.Text = "Status: Pending...";
            this.pendingStatusButton.UseVisualStyleBackColor = true;
            // 
            // remoteButton
            // 
            this.remoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.remoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.remoteButton.FlatAppearance.BorderSize = 0;
            this.remoteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.remoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.remoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.remoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remoteButton.ForeColor = System.Drawing.Color.White;
            this.remoteButton.Image = ((System.Drawing.Image)(resources.GetObject("remoteButton.Image")));
            this.remoteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remoteButton.Location = new System.Drawing.Point(389, 573);
            this.remoteButton.Margin = new System.Windows.Forms.Padding(0);
            this.remoteButton.Name = "remoteButton";
            this.remoteButton.Size = new System.Drawing.Size(104, 28);
            this.remoteButton.TabIndex = 13;
            this.remoteButton.Text = "Remote";
            this.remoteButton.UseVisualStyleBackColor = true;
            // 
            // localButton
            // 
            this.localButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.localButton.FlatAppearance.BorderSize = 0;
            this.localButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.localButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.localButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.localButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localButton.ForeColor = System.Drawing.Color.White;
            this.localButton.Image = ((System.Drawing.Image)(resources.GetObject("localButton.Image")));
            this.localButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localButton.Location = new System.Drawing.Point(389, 573);
            this.localButton.Margin = new System.Windows.Forms.Padding(0);
            this.localButton.Name = "localButton";
            this.localButton.Size = new System.Drawing.Size(104, 28);
            this.localButton.TabIndex = 14;
            this.localButton.Text = "Local";
            this.localButton.UseVisualStyleBackColor = true;
            // 
            // motor1Button
            // 
            this.motor1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motor1Button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.motor1Button.FlatAppearance.BorderSize = 0;
            this.motor1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.motor1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.motor1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motor1Button.ForeColor = System.Drawing.Color.White;
            this.motor1Button.Image = ((System.Drawing.Image)(resources.GetObject("motor1Button.Image")));
            this.motor1Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motor1Button.Location = new System.Drawing.Point(236, 430);
            this.motor1Button.Margin = new System.Windows.Forms.Padding(0);
            this.motor1Button.Name = "motor1Button";
            this.motor1Button.Size = new System.Drawing.Size(123, 28);
            this.motor1Button.TabIndex = 15;
            this.motor1Button.Text = "Motor 1: 0%";
            this.motor1Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.motor1Button.UseVisualStyleBackColor = true;
            // 
            // motor2Button
            // 
            this.motor2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.motor2Button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.motor2Button.FlatAppearance.BorderSize = 0;
            this.motor2Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.motor2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.motor2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.motor2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motor2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motor2Button.ForeColor = System.Drawing.Color.White;
            this.motor2Button.Image = ((System.Drawing.Image)(resources.GetObject("motor2Button.Image")));
            this.motor2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motor2Button.Location = new System.Drawing.Point(236, 456);
            this.motor2Button.Margin = new System.Windows.Forms.Padding(0);
            this.motor2Button.Name = "motor2Button";
            this.motor2Button.Size = new System.Drawing.Size(123, 28);
            this.motor2Button.TabIndex = 16;
            this.motor2Button.Text = "Motor 2: 0%";
            this.motor2Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.motor2Button.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(459, 481);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 28);
            this.button9.TabIndex = 17;
            this.button9.Text = "Steering: 0*";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(236, 481);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 28);
            this.button10.TabIndex = 18;
            this.button10.Text = "Speed: 0m/s";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // stepperButton
            // 
            this.stepperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stepperButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.stepperButton.FlatAppearance.BorderSize = 0;
            this.stepperButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.stepperButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.stepperButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.stepperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepperButton.ForeColor = System.Drawing.Color.White;
            this.stepperButton.Image = ((System.Drawing.Image)(resources.GetObject("stepperButton.Image")));
            this.stepperButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stepperButton.Location = new System.Drawing.Point(459, 430);
            this.stepperButton.Margin = new System.Windows.Forms.Padding(0);
            this.stepperButton.Name = "stepperButton";
            this.stepperButton.Size = new System.Drawing.Size(123, 28);
            this.stepperButton.TabIndex = 19;
            this.stepperButton.Text = "Stepper: 0*";
            this.stepperButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stepperButton.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.Location = new System.Drawing.Point(459, 456);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(123, 28);
            this.button12.TabIndex = 20;
            this.button12.Text = "Servo: 0*";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 10);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(219, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 10);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(595, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 650);
            this.panel4.TabIndex = 23;
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(219, 10);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 22);
            this.button13.TabIndex = 24;
            this.button13.Text = "COM Port";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // portComboBox
            // 
            this.portComboBox.BackColor = System.Drawing.Color.Gray;
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.ForeColor = System.Drawing.Color.White;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(219, 35);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(96, 21);
            this.portComboBox.TabIndex = 25;
            this.portComboBox.DropDownClosed += new System.EventHandler(this.portComboBox_DropDownClosed);
            // 
            // portRefreshButton
            // 
            this.portRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portRefreshButton.FlatAppearance.BorderSize = 0;
            this.portRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portRefreshButton.ForeColor = System.Drawing.Color.White;
            this.portRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("portRefreshButton.Image")));
            this.portRefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.portRefreshButton.Location = new System.Drawing.Point(318, 35);
            this.portRefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.portRefreshButton.Name = "portRefreshButton";
            this.portRefreshButton.Size = new System.Drawing.Size(22, 21);
            this.portRefreshButton.TabIndex = 15;
            this.portRefreshButton.UseVisualStyleBackColor = true;
            this.portRefreshButton.Click += new System.EventHandler(this.portRefreshButton_Click);
            // 
            // uidButton
            // 
            this.uidButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uidButton.FlatAppearance.BorderSize = 0;
            this.uidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidButton.ForeColor = System.Drawing.Color.White;
            this.uidButton.Image = ((System.Drawing.Image)(resources.GetObject("uidButton.Image")));
            this.uidButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uidButton.Location = new System.Drawing.Point(459, 613);
            this.uidButton.Margin = new System.Windows.Forms.Padding(0);
            this.uidButton.Name = "uidButton";
            this.uidButton.Size = new System.Drawing.Size(22, 21);
            this.uidButton.TabIndex = 26;
            this.uidButton.UseVisualStyleBackColor = true;
            this.uidButton.Click += new System.EventHandler(this.uidButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(605, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uidButton);
            this.Controls.Add(this.portRefreshButton);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.stepperButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.motor2Button);
            this.Controls.Add(this.motor1Button);
            this.Controls.Add(this.localButton);
            this.Controls.Add(this.remoteButton);
            this.Controls.Add(this.offlineStatusButton);
            this.Controls.Add(this.pendingStatusButton);
            this.Controls.Add(this.onlineStatusButton);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindowForm";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button OTAButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button uidLabel;
        private System.Windows.Forms.Button onlineStatusButton;
        private System.Windows.Forms.Button offlineStatusButton;
        private System.Windows.Forms.Button pendingStatusButton;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.Button autonomousButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button errorButton;
        private System.Windows.Forms.Button controllerButton;
        private System.Windows.Forms.Button remoteButton;
        private System.Windows.Forms.Button localButton;
        private System.Windows.Forms.Button motor1Button;
        private System.Windows.Forms.Button motor2Button;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button stepperButton;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button portRefreshButton;
        private System.Windows.Forms.Button uidButton;
    }
}

