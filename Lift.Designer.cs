namespace ElevatorAppForm
{
    partial class Lift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lift));
            this.Call = new System.Windows.Forms.Button();
            this.GoOut = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Floors = new System.Windows.Forms.ComboBox();
            this.People = new System.Windows.Forms.ComboBox();
            this.CreatePerson = new System.Windows.Forms.Button();
            this.TargetFloor = new System.Windows.Forms.ComboBox();
            this.GoTargetFloor = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.currentLiftWeight = new System.Windows.Forms.TextBox();
            this.PeopleInLift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.PictureBox();
            this.LiftPicture = new System.Windows.Forms.PictureBox();
            this.countTrips = new System.Windows.Forms.TextBox();
            this.TotalTrips = new System.Windows.Forms.Label();
            this.countEmptyTrips = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmptyLift = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ElevatorLevel = new System.Windows.Forms.TextBox();
            this.PeopleCount = new System.Windows.Forms.Label();
            this.CountPeopleLift = new System.Windows.Forms.TextBox();
            this.BuildingFloor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Call
            // 
            this.Call.BackColor = System.Drawing.Color.Thistle;
            this.Call.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Call.Location = new System.Drawing.Point(1172, 231);
            this.Call.Name = "Call";
            this.Call.Size = new System.Drawing.Size(120, 64);
            this.Call.TabIndex = 1;
            this.Call.Text = "Вызов";
            this.Call.UseVisualStyleBackColor = false;
            this.Call.Click += new System.EventHandler(this.Call_Click);
            // 
            // GoOut
            // 
            this.GoOut.BackColor = System.Drawing.Color.MediumOrchid;
            this.GoOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOut.Location = new System.Drawing.Point(1172, 388);
            this.GoOut.Name = "GoOut";
            this.GoOut.Size = new System.Drawing.Size(120, 65);
            this.GoOut.TabIndex = 4;
            this.GoOut.Text = "Выйти ";
            this.GoOut.UseVisualStyleBackColor = false;
            this.GoOut.Click += new System.EventHandler(this.GoOut_Click);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Plum;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(1172, 312);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(120, 65);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Floors
            // 
            this.Floors.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Floors.FormattingEnabled = true;
            this.Floors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Floors.Location = new System.Drawing.Point(12, 602);
            this.Floors.Name = "Floors";
            this.Floors.Size = new System.Drawing.Size(121, 24);
            this.Floors.TabIndex = 6;
            this.Floors.SelectedIndexChanged += new System.EventHandler(this.Floors_SelectedIndexChanged);
            // 
            // People
            // 
            this.People.FormattingEnabled = true;
            this.People.Location = new System.Drawing.Point(1045, 254);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(121, 24);
            this.People.TabIndex = 7;
            this.People.SelectedIndexChanged += new System.EventHandler(this.People_SelectedIndexChanged);
            // 
            // CreatePerson
            // 
            this.CreatePerson.BackColor = System.Drawing.Color.OliveDrab;
            this.CreatePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePerson.Location = new System.Drawing.Point(1210, 21);
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.Size = new System.Drawing.Size(100, 60);
            this.CreatePerson.TabIndex = 8;
            this.CreatePerson.Text = "Создать человека";
            this.CreatePerson.UseVisualStyleBackColor = false;
            this.CreatePerson.Click += new System.EventHandler(this.CreatePerson_Click);
            // 
            // TargetFloor
            // 
            this.TargetFloor.FormattingEnabled = true;
            this.TargetFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.TargetFloor.Location = new System.Drawing.Point(1234, 129);
            this.TargetFloor.Name = "TargetFloor";
            this.TargetFloor.Size = new System.Drawing.Size(58, 24);
            this.TargetFloor.TabIndex = 9;
            this.TargetFloor.SelectedIndexChanged += new System.EventHandler(this.TargetFloor_SelectedIndexChanged);
            // 
            // GoTargetFloor
            // 
            this.GoTargetFloor.BackColor = System.Drawing.Color.MediumTurquoise;
            this.GoTargetFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoTargetFloor.Location = new System.Drawing.Point(1137, 159);
            this.GoTargetFloor.Name = "GoTargetFloor";
            this.GoTargetFloor.Size = new System.Drawing.Size(155, 53);
            this.GoTargetFloor.TabIndex = 10;
            this.GoTargetFloor.Text = "Переместиться на целевой этаж";
            this.GoTargetFloor.UseVisualStyleBackColor = false;
            this.GoTargetFloor.Click += new System.EventHandler(this.GoTargetFloor_Click);
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(139, 590);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(70, 45);
            this.Ok.TabIndex = 11;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SlateBlue;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(17, 741);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 78);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выйти в меню";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // currentLiftWeight
            // 
            this.currentLiftWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentLiftWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.currentLiftWeight.Location = new System.Drawing.Point(1192, 512);
            this.currentLiftWeight.Name = "currentLiftWeight";
            this.currentLiftWeight.Size = new System.Drawing.Size(100, 27);
            this.currentLiftWeight.TabIndex = 13;
            this.currentLiftWeight.TextChanged += new System.EventHandler(this.currentLiftWeight_TextChanged);
            // 
            // PeopleInLift
            // 
            this.PeopleInLift.FormattingEnabled = true;
            this.PeopleInLift.Location = new System.Drawing.Point(1045, 334);
            this.PeopleInLift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PeopleInLift.Name = "PeopleInLift";
            this.PeopleInLift.Size = new System.Drawing.Size(121, 24);
            this.PeopleInLift.TabIndex = 15;
            this.PeopleInLift.SelectedIndexChanged += new System.EventHandler(this.PeopleInLift_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выбрать этаж здания\r\n";
            this.label1.Click += new System.EventHandler(this.ChooseLevel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1132, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Нагрузка на лифт";
            this.label2.Click += new System.EventHandler(this.burden_Click);
            // 
            // Down
            // 
            this.Down.Image = global::ElevatorAppForm.Properties.Resources.circle_down_arrow_arrow_icon_253893;
            this.Down.Location = new System.Drawing.Point(643, 21);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(78, 80);
            this.Down.TabIndex = 19;
            this.Down.TabStop = false;
            // 
            // Up
            // 
            this.Up.Image = global::ElevatorAppForm.Properties.Resources.arrow_circle_up_arrow_icon_253879;
            this.Up.Location = new System.Drawing.Point(391, 21);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(81, 80);
            this.Up.TabIndex = 18;
            this.Up.TabStop = false;
            // 
            // LiftPicture
            // 
            this.LiftPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LiftPicture.Image = global::ElevatorAppForm.Properties.Resources.elevator_71_594713;
            this.LiftPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("LiftPicture.InitialImage")));
            this.LiftPicture.Location = new System.Drawing.Point(311, 201);
            this.LiftPicture.Name = "LiftPicture";
            this.LiftPicture.Size = new System.Drawing.Size(646, 618);
            this.LiftPicture.TabIndex = 0;
            this.LiftPicture.TabStop = false;
            this.LiftPicture.Click += new System.EventHandler(this.Lift_Click);
            // 
            // countTrips
            // 
            this.countTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTrips.Location = new System.Drawing.Point(1192, 602);
            this.countTrips.Name = "countTrips";
            this.countTrips.Size = new System.Drawing.Size(100, 27);
            this.countTrips.TabIndex = 20;
            this.countTrips.TextChanged += new System.EventHandler(this.countTrips_TextChanged);
            // 
            // TotalTrips
            // 
            this.TotalTrips.AutoSize = true;
            this.TotalTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalTrips.Location = new System.Drawing.Point(1133, 558);
            this.TotalTrips.Name = "TotalTrips";
            this.TotalTrips.Size = new System.Drawing.Size(202, 20);
            this.TotalTrips.TabIndex = 21;
            this.TotalTrips.Text = "Количество поездок";
            // 
            // countEmptyTrips
            // 
            this.countEmptyTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countEmptyTrips.Location = new System.Drawing.Point(1192, 687);
            this.countEmptyTrips.Name = "countEmptyTrips";
            this.countEmptyTrips.Size = new System.Drawing.Size(100, 27);
            this.countEmptyTrips.TabIndex = 22;
            this.countEmptyTrips.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(1042, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Количество холостых поездок";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Warning.Location = new System.Drawing.Point(816, 30);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(244, 38);
            this.Warning.TabIndex = 24;
            this.Warning.Text = "ПЕРЕГРУЗКА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Этаж здания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1000, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Люди вне лифта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1022, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Люди в лифте";
            // 
            // EmptyLift
            // 
            this.EmptyLift.AutoSize = true;
            this.EmptyLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyLift.Location = new System.Drawing.Point(815, 77);
            this.EmptyLift.Name = "EmptyLift";
            this.EmptyLift.Size = new System.Drawing.Size(181, 42);
            this.EmptyLift.TabIndex = 28;
            this.EmptyLift.Text = "ПУСТОЙ";
            this.EmptyLift.Click += new System.EventHandler(this.EmptyLift_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(503, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Этаж лифта";
            // 
            // ElevatorLevel
            // 
            this.ElevatorLevel.BackColor = System.Drawing.Color.PowderBlue;
            this.ElevatorLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElevatorLevel.Location = new System.Drawing.Point(508, 26);
            this.ElevatorLevel.Name = "ElevatorLevel";
            this.ElevatorLevel.Size = new System.Drawing.Size(88, 75);
            this.ElevatorLevel.TabIndex = 30;
            this.ElevatorLevel.TextChanged += new System.EventHandler(this.ElevatorLevel_TextChanged);
            // 
            // PeopleCount
            // 
            this.PeopleCount.AutoSize = true;
            this.PeopleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleCount.Location = new System.Drawing.Point(1013, 741);
            this.PeopleCount.Name = "PeopleCount";
            this.PeopleCount.Size = new System.Drawing.Size(322, 20);
            this.PeopleCount.TabIndex = 31;
            this.PeopleCount.Text = "Количество перевезенных людей";
            // 
            // CountPeopleLift
            // 
            this.CountPeopleLift.Location = new System.Drawing.Point(1192, 781);
            this.CountPeopleLift.Name = "CountPeopleLift";
            this.CountPeopleLift.Size = new System.Drawing.Size(100, 22);
            this.CountPeopleLift.TabIndex = 32;
            this.CountPeopleLift.TextChanged += new System.EventHandler(this.CountPeopleLift_TextChanged);
            // 
            // BuildingFloor
            // 
            this.BuildingFloor.BackColor = System.Drawing.Color.PowderBlue;
            this.BuildingFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingFloor.Location = new System.Drawing.Point(17, 334);
            this.BuildingFloor.Name = "BuildingFloor";
            this.BuildingFloor.Size = new System.Drawing.Size(86, 61);
            this.BuildingFloor.TabIndex = 33;
            // 
            // Lift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1344, 885);
            this.Controls.Add(this.BuildingFloor);
            this.Controls.Add(this.CountPeopleLift);
            this.Controls.Add(this.PeopleCount);
            this.Controls.Add(this.ElevatorLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmptyLift);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countEmptyTrips);
            this.Controls.Add(this.TotalTrips);
            this.Controls.Add(this.countTrips);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeopleInLift);
            this.Controls.Add(this.currentLiftWeight);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.GoTargetFloor);
            this.Controls.Add(this.TargetFloor);
            this.Controls.Add(this.CreatePerson);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Floors);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.GoOut);
            this.Controls.Add(this.Call);
            this.Controls.Add(this.LiftPicture);
            this.Name = "Lift";
            this.Text = "Lift";
            this.Load += new System.EventHandler(this.Lift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiftPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LiftPicture;
        private System.Windows.Forms.Button Call;
        private System.Windows.Forms.Button GoOut;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.ComboBox Floors;
        private System.Windows.Forms.ComboBox People;
        private System.Windows.Forms.Button CreatePerson;
        private System.Windows.Forms.ComboBox TargetFloor;
        private System.Windows.Forms.Button GoTargetFloor;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox currentLiftWeight;
        private System.Windows.Forms.ComboBox PeopleInLift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Up;
        private System.Windows.Forms.PictureBox Down;
        private System.Windows.Forms.TextBox countTrips;
        private System.Windows.Forms.Label TotalTrips;
        private System.Windows.Forms.TextBox countEmptyTrips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EmptyLift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ElevatorLevel;
        private System.Windows.Forms.Label PeopleCount;
        private System.Windows.Forms.TextBox CountPeopleLift;
        private System.Windows.Forms.TextBox BuildingFloor;
    }
}