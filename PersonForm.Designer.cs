namespace ElevatorAppForm
{
    partial class PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CurrentFloor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FloorBox = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.CreatePerson = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ElevatorAppForm.Properties.Resources.standing_man;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 578);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(519, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(186, 22);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // CurrentFloor
            // 
            this.CurrentFloor.AutoSize = true;
            this.CurrentFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentFloor.Location = new System.Drawing.Point(517, 96);
            this.CurrentFloor.Name = "CurrentFloor";
            this.CurrentFloor.Size = new System.Drawing.Size(139, 20);
            this.CurrentFloor.TabIndex = 2;
            this.CurrentFloor.Text = "Текущий этаж";
            this.CurrentFloor.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(516, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // FloorBox
            // 
            this.FloorBox.Location = new System.Drawing.Point(520, 128);
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.Size = new System.Drawing.Size(100, 22);
            this.FloorBox.TabIndex = 4;
            this.FloorBox.TextChanged += new System.EventHandler(this.FloorBox_TextChanged);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight.Location = new System.Drawing.Point(518, 176);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(43, 20);
            this.Weight.TabIndex = 5;
            this.Weight.Text = "Вес";
            this.Weight.Click += new System.EventHandler(this.Weight_Click);
            // 
            // WeightBox
            // 
            this.WeightBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WeightBox.Location = new System.Drawing.Point(519, 208);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(100, 22);
            this.WeightBox.TabIndex = 6;
            this.WeightBox.TextChanged += new System.EventHandler(this.WeightBox_TextChanged);
            // 
            // CreatePerson
            // 
            this.CreatePerson.BackColor = System.Drawing.Color.AliceBlue;
            this.CreatePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePerson.Location = new System.Drawing.Point(519, 272);
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.Size = new System.Drawing.Size(158, 52);
            this.CreatePerson.TabIndex = 7;
            this.CreatePerson.Text = "Создать";
            this.CreatePerson.UseVisualStyleBackColor = false;
            this.CreatePerson.Click += new System.EventHandler(this.Create_Click);
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return.Location = new System.Drawing.Point(782, 579);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(157, 43);
            this.Return.TabIndex = 8;
            this.Return.Text = "Назад";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(951, 634);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.CreatePerson);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentFloor);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label CurrentFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FloorBox;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Button CreatePerson;
        private System.Windows.Forms.Button Return;
    }
}