using System.Threading.Tasks;
using System;

namespace ElevatorAppForm
{
    partial class StartMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }   
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.CreateSession = new System.Windows.Forms.Button();
            this.StopSystem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.AmountFloors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateSession
            // 
            this.CreateSession.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateSession.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSession.Location = new System.Drawing.Point(621, 14);
            this.CreateSession.Name = "CreateSession";
            this.CreateSession.Size = new System.Drawing.Size(197, 88);
            this.CreateSession.TabIndex = 1;
            this.CreateSession.Text = "Создать сеанс";
            this.CreateSession.UseVisualStyleBackColor = false;
            this.CreateSession.Click += new System.EventHandler(this.CreateSession_Click);
            // 
            // StopSystem
            // 
            this.StopSystem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StopSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopSystem.ForeColor = System.Drawing.Color.Red;
            this.StopSystem.Location = new System.Drawing.Point(621, 108);
            this.StopSystem.Name = "StopSystem";
            this.StopSystem.Size = new System.Drawing.Size(197, 92);
            this.StopSystem.TabIndex = 2;
            this.StopSystem.Text = "Остановить систему";
            this.StopSystem.UseVisualStyleBackColor = false;
            this.StopSystem.Click += new System.EventHandler(this.StopSystem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ElevatorAppForm.Properties.Resources._884792;
            this.pictureBox2.Location = new System.Drawing.Point(26, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 519);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(621, 206);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 80);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AmountFloors
            // 
            this.AmountFloors.Location = new System.Drawing.Point(673, 369);
            this.AmountFloors.Name = "AmountFloors";
            this.AmountFloors.Size = new System.Drawing.Size(100, 22);
            this.AmountFloors.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(569, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество этажей в здании ";
            this.label1.Click += new System.EventHandler(this.AmountFloors_Click);
            // 
            // StartMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(885, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountFloors);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StopSystem);
            this.Controls.Add(this.CreateSession);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartMenu";
            this.Text = "Лифт";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox6;
       // private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CreateSession;
        private System.Windows.Forms.Button StopSystem;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox AmountFloors;
        private System.Windows.Forms.Label label1;
    }
}

