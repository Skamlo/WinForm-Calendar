
namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeftButtons = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.panelRightButtons = new System.Windows.Forms.Panel();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnMonthUp = new System.Windows.Forms.Button();
            this.btnAddEventTopRight = new System.Windows.Forms.Button();
            this.btnMonthDown = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelLeftButtons.SuspendLayout();
            this.panelRightButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftButtons
            // 
            this.panelLeftButtons.Controls.Add(this.btnSettings);
            this.panelLeftButtons.Controls.Add(this.btnCalendar);
            this.panelLeftButtons.Controls.Add(this.btnEvents);
            this.panelLeftButtons.Location = new System.Drawing.Point(0, 0);
            this.panelLeftButtons.Name = "panelLeftButtons";
            this.panelLeftButtons.Size = new System.Drawing.Size(160, 50);
            this.panelLeftButtons.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::Calendar.Properties.Resources.settings40x40;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(10, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackgroundImage = global::Calendar.Properties.Resources.calendar40x40;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Location = new System.Drawing.Point(60, 10);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(40, 40);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackgroundImage = global::Calendar.Properties.Resources.event40x40;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Location = new System.Drawing.Point(110, 10);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(40, 40);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // panelRightButtons
            // 
            this.panelRightButtons.Controls.Add(this.btnDate);
            this.panelRightButtons.Controls.Add(this.btnMonthUp);
            this.panelRightButtons.Controls.Add(this.btnAddEventTopRight);
            this.panelRightButtons.Controls.Add(this.btnMonthDown);
            this.panelRightButtons.Location = new System.Drawing.Point(336, 0);
            this.panelRightButtons.Name = "panelRightButtons";
            this.panelRightButtons.Size = new System.Drawing.Size(270, 50);
            this.panelRightButtons.TabIndex = 0;
            // 
            // btnDate
            // 
            this.btnDate.FlatAppearance.BorderSize = 0;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.Location = new System.Drawing.Point(10, 10);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(150, 40);
            this.btnDate.TabIndex = 7;
            this.btnDate.Text = "październik 2022";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnMonthUp
            // 
            this.btnMonthUp.BackgroundImage = global::Calendar.Properties.Resources.monthUp40x40;
            this.btnMonthUp.FlatAppearance.BorderSize = 0;
            this.btnMonthUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthUp.Location = new System.Drawing.Point(170, 10);
            this.btnMonthUp.Name = "btnMonthUp";
            this.btnMonthUp.Size = new System.Drawing.Size(40, 40);
            this.btnMonthUp.TabIndex = 4;
            this.btnMonthUp.UseVisualStyleBackColor = true;
            this.btnMonthUp.Click += new System.EventHandler(this.btnMonthUp_Click);
            // 
            // btnAddEventTopRight
            // 
            this.btnAddEventTopRight.BackgroundImage = global::Calendar.Properties.Resources.addEvent40x40;
            this.btnAddEventTopRight.FlatAppearance.BorderSize = 0;
            this.btnAddEventTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEventTopRight.Location = new System.Drawing.Point(220, 10);
            this.btnAddEventTopRight.Name = "btnAddEventTopRight";
            this.btnAddEventTopRight.Size = new System.Drawing.Size(40, 40);
            this.btnAddEventTopRight.TabIndex = 6;
            this.btnAddEventTopRight.UseVisualStyleBackColor = true;
            this.btnAddEventTopRight.Click += new System.EventHandler(this.btnAddEventTopRight_Click);
            // 
            // btnMonthDown
            // 
            this.btnMonthDown.BackgroundImage = global::Calendar.Properties.Resources.monthDown40x40;
            this.btnMonthDown.FlatAppearance.BorderSize = 0;
            this.btnMonthDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthDown.Location = new System.Drawing.Point(220, 10);
            this.btnMonthDown.Name = "btnMonthDown";
            this.btnMonthDown.Size = new System.Drawing.Size(40, 40);
            this.btnMonthDown.TabIndex = 5;
            this.btnMonthDown.UseVisualStyleBackColor = true;
            this.btnMonthDown.Click += new System.EventHandler(this.btnMonthDown_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(606, 460);
            this.panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1077, 592);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelRightButtons);
            this.Controls.Add(this.panelLeftButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(625, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panelLeftButtons.ResumeLayout(false);
            this.panelRightButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftButtons;
        private System.Windows.Forms.Panel panelRightButtons;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnAddEventTopRight;
        private System.Windows.Forms.Button btnMonthUp;
        private System.Windows.Forms.Button btnMonthDown;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnDate;
    }
}

