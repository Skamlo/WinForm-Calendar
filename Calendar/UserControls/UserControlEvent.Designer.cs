
namespace Calendar.UserControls
{
    partial class UserControlEvent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEvent));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDate = new System.Windows.Forms.Panel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimeBetween = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.lblDesription = new System.Windows.Forms.Label();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseEnter += new System.EventHandler(this.lblTitle_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.lblTitle_MouseLeave);
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.lblStartDate);
            this.panelDate.Controls.Add(this.pictureBox1);
            this.panelDate.Controls.Add(this.lblTimeBetween);
            this.panelDate.Controls.Add(this.lblEndDate);
            this.panelDate.Location = new System.Drawing.Point(78, 15);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(427, 25);
            this.panelDate.TabIndex = 1;
            this.panelDate.Click += new System.EventHandler(this.panelDate_Click);
            this.panelDate.MouseEnter += new System.EventHandler(this.panelDate_MouseEnter);
            this.panelDate.MouseLeave += new System.EventHandler(this.panelDate_MouseLeave);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(0, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(160, 25);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "23.12.20222   11:30 am";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            this.lblStartDate.MouseEnter += new System.EventHandler(this.lblStartDate_MouseEnter);
            this.lblStartDate.MouseLeave += new System.EventHandler(this.lblStartDate_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Calendar.Properties.Resources.arrow30x30;
            this.pictureBox1.Location = new System.Drawing.Point(160, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // lblTimeBetween
            // 
            this.lblTimeBetween.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeBetween.ForeColor = System.Drawing.Color.White;
            this.lblTimeBetween.Location = new System.Drawing.Point(360, 0);
            this.lblTimeBetween.Name = "lblTimeBetween";
            this.lblTimeBetween.Size = new System.Drawing.Size(67, 25);
            this.lblTimeBetween.TabIndex = 2;
            this.lblTimeBetween.Text = "23 godz.";
            this.lblTimeBetween.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeBetween.Click += new System.EventHandler(this.lblTimeBetween_Click);
            this.lblTimeBetween.MouseEnter += new System.EventHandler(this.lblTimeBetween_MouseEnter);
            this.lblTimeBetween.MouseLeave += new System.EventHandler(this.lblTimeBetween_MouseLeave);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(190, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(160, 25);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "23.12.20222   11:30 am";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            this.lblEndDate.MouseEnter += new System.EventHandler(this.lblEndDate_MouseEnter);
            this.lblEndDate.MouseLeave += new System.EventHandler(this.lblEndDate_MouseLeave);
            // 
            // lblAddDate
            // 
            this.lblAddDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddDate.ForeColor = System.Drawing.Color.White;
            this.lblAddDate.Location = new System.Drawing.Point(10, 120);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(495, 20);
            this.lblAddDate.TabIndex = 2;
            this.lblAddDate.Text = "Add date: 12.12.2022   11:30 am     Last edit date: 12.12.2022   11:00 pm";
            this.lblAddDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddDate.Click += new System.EventHandler(this.lblAddDate_Click);
            this.lblAddDate.MouseEnter += new System.EventHandler(this.lblAddDate_MouseEnter);
            this.lblAddDate.MouseLeave += new System.EventHandler(this.lblAddDate_MouseLeave);
            // 
            // lblDesription
            // 
            this.lblDesription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesription.ForeColor = System.Drawing.Color.White;
            this.lblDesription.Location = new System.Drawing.Point(10, 61);
            this.lblDesription.Name = "lblDesription";
            this.lblDesription.Size = new System.Drawing.Size(495, 48);
            this.lblDesription.TabIndex = 3;
            this.lblDesription.Text = resources.GetString("lblDesription.Text");
            this.lblDesription.Click += new System.EventHandler(this.lblDesription_Click);
            this.lblDesription.MouseEnter += new System.EventHandler(this.lblDesription_MouseEnter);
            this.lblDesription.MouseLeave += new System.EventHandler(this.lblDesription_MouseLeave);
            // 
            // UserControlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblDesription);
            this.Controls.Add(this.lblAddDate);
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Name = "UserControlEvent";
            this.Size = new System.Drawing.Size(515, 150);
            this.Load += new System.EventHandler(this.UserControlEvent_Load);
            this.BackColorChanged += new System.EventHandler(this.UserControlEvent_BackColorChanged);
            this.SizeChanged += new System.EventHandler(this.UserControlEvent_SizeChanged);
            this.Click += new System.EventHandler(this.UserControlEvent_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlEvent_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlEvent_MouseLeave);
            this.panelDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTimeBetween;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblAddDate;
        private System.Windows.Forms.Label lblDesription;
    }
}
