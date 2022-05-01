
namespace Calendar.UserControls
{
    partial class UserControlSettings
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
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblStyles = new System.Windows.Forms.Label();
            this.lblWritingMethod = new System.Windows.Forms.Label();
            this.lblClockSystem = new System.Windows.Forms.Label();
            this.panelStyles = new System.Windows.Forms.Panel();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.pctbxSlider = new System.Windows.Forms.PictureBox();
            this.panelClockSystem = new System.Windows.Forms.Panel();
            this.rbtnClockSystem24 = new System.Windows.Forms.RadioButton();
            this.rbtnClockSystem12 = new System.Windows.Forms.RadioButton();
            this.panelWritingMethod = new System.Windows.Forms.Panel();
            this.rbtnDYM = new System.Windows.Forms.RadioButton();
            this.rbtnMYD = new System.Windows.Forms.RadioButton();
            this.rbtnYDM = new System.Windows.Forms.RadioButton();
            this.rbtnYMD = new System.Windows.Forms.RadioButton();
            this.rbtnMDY = new System.Windows.Forms.RadioButton();
            this.rbtnDMY = new System.Windows.Forms.RadioButton();
            this.panelFirstDay = new System.Windows.Forms.Panel();
            this.rbtnSunday = new System.Windows.Forms.RadioButton();
            this.rbtnMonday = new System.Windows.Forms.RadioButton();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.panelStyles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxSlider)).BeginInit();
            this.panelClockSystem.SuspendLayout();
            this.panelWritingMethod.SuspendLayout();
            this.panelFirstDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(10, 10);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(155, 45);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "language";
            // 
            // lblStyles
            // 
            this.lblStyles.AutoSize = true;
            this.lblStyles.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStyles.ForeColor = System.Drawing.Color.White;
            this.lblStyles.Location = new System.Drawing.Point(10, 147);
            this.lblStyles.Name = "lblStyles";
            this.lblStyles.Size = new System.Drawing.Size(103, 45);
            this.lblStyles.TabIndex = 1;
            this.lblStyles.Text = "Styles";
            // 
            // lblWritingMethod
            // 
            this.lblWritingMethod.AutoSize = true;
            this.lblWritingMethod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWritingMethod.ForeColor = System.Drawing.Color.White;
            this.lblWritingMethod.Location = new System.Drawing.Point(17, 570);
            this.lblWritingMethod.Name = "lblWritingMethod";
            this.lblWritingMethod.Size = new System.Drawing.Size(249, 45);
            this.lblWritingMethod.TabIndex = 2;
            this.lblWritingMethod.Text = "Writing method";
            // 
            // lblClockSystem
            // 
            this.lblClockSystem.AutoSize = true;
            this.lblClockSystem.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClockSystem.ForeColor = System.Drawing.Color.White;
            this.lblClockSystem.Location = new System.Drawing.Point(17, 845);
            this.lblClockSystem.Name = "lblClockSystem";
            this.lblClockSystem.Size = new System.Drawing.Size(207, 45);
            this.lblClockSystem.TabIndex = 3;
            this.lblClockSystem.Text = "Clock system";
            // 
            // panelStyles
            // 
            this.panelStyles.Controls.Add(this.rbtnCustom);
            this.panelStyles.Controls.Add(this.rbtnBlue);
            this.panelStyles.Controls.Add(this.rbtnGreen);
            this.panelStyles.Controls.Add(this.rbtnRed);
            this.panelStyles.Location = new System.Drawing.Point(17, 196);
            this.panelStyles.Name = "panelStyles";
            this.panelStyles.Size = new System.Drawing.Size(251, 121);
            this.panelStyles.TabIndex = 6;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.ForeColor = System.Drawing.Color.White;
            this.rbtnCustom.Location = new System.Drawing.Point(3, 93);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(117, 24);
            this.rbtnCustom.TabIndex = 3;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "radioButton4";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.rbtnCustom_CheckedChanged);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.ForeColor = System.Drawing.Color.White;
            this.rbtnBlue.Location = new System.Drawing.Point(3, 63);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(117, 24);
            this.rbtnBlue.TabIndex = 2;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "radioButton3";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.rbtnBlue_CheckedChanged);
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.ForeColor = System.Drawing.Color.White;
            this.rbtnGreen.Location = new System.Drawing.Point(3, 33);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(117, 24);
            this.rbtnGreen.TabIndex = 1;
            this.rbtnGreen.TabStop = true;
            this.rbtnGreen.Text = "radioButton2";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            this.rbtnGreen.CheckedChanged += new System.EventHandler(this.rbtnGreen_CheckedChanged);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.ForeColor = System.Drawing.Color.White;
            this.rbtnRed.Location = new System.Drawing.Point(3, 3);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(117, 24);
            this.rbtnRed.TabIndex = 0;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "radioButton1";
            this.rbtnRed.UseVisualStyleBackColor = true;
            this.rbtnRed.CheckedChanged += new System.EventHandler(this.rbtnRed_CheckedChanged);
            // 
            // pctbxSlider
            // 
            this.pctbxSlider.BackgroundImage = global::Calendar.Properties.Resources.colorSliderSmall605x38;
            this.pctbxSlider.Location = new System.Drawing.Point(0, 323);
            this.pctbxSlider.Name = "pctbxSlider";
            this.pctbxSlider.Size = new System.Drawing.Size(613, 38);
            this.pctbxSlider.TabIndex = 7;
            this.pctbxSlider.TabStop = false;
            this.pctbxSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.pctbxSlider_Paint);
            this.pctbxSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctbxSlider_MouseDown);
            this.pctbxSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctbxSlider_MouseMove);
            this.pctbxSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctbxSlider_MouseUp);
            // 
            // panelClockSystem
            // 
            this.panelClockSystem.Controls.Add(this.rbtnClockSystem24);
            this.panelClockSystem.Controls.Add(this.rbtnClockSystem12);
            this.panelClockSystem.Location = new System.Drawing.Point(20, 893);
            this.panelClockSystem.Name = "panelClockSystem";
            this.panelClockSystem.Size = new System.Drawing.Size(248, 64);
            this.panelClockSystem.TabIndex = 8;
            // 
            // rbtnClockSystem24
            // 
            this.rbtnClockSystem24.AutoSize = true;
            this.rbtnClockSystem24.ForeColor = System.Drawing.Color.White;
            this.rbtnClockSystem24.Location = new System.Drawing.Point(3, 33);
            this.rbtnClockSystem24.Name = "rbtnClockSystem24";
            this.rbtnClockSystem24.Size = new System.Drawing.Size(117, 24);
            this.rbtnClockSystem24.TabIndex = 5;
            this.rbtnClockSystem24.TabStop = true;
            this.rbtnClockSystem24.Text = "radioButton6";
            this.rbtnClockSystem24.UseVisualStyleBackColor = true;
            this.rbtnClockSystem24.CheckedChanged += new System.EventHandler(this.rbtnClockSystem24_CheckedChanged);
            // 
            // rbtnClockSystem12
            // 
            this.rbtnClockSystem12.AutoSize = true;
            this.rbtnClockSystem12.ForeColor = System.Drawing.Color.White;
            this.rbtnClockSystem12.Location = new System.Drawing.Point(3, 3);
            this.rbtnClockSystem12.Name = "rbtnClockSystem12";
            this.rbtnClockSystem12.Size = new System.Drawing.Size(117, 24);
            this.rbtnClockSystem12.TabIndex = 4;
            this.rbtnClockSystem12.TabStop = true;
            this.rbtnClockSystem12.Text = "radioButton5";
            this.rbtnClockSystem12.UseVisualStyleBackColor = true;
            this.rbtnClockSystem12.CheckedChanged += new System.EventHandler(this.rbtnClockSystem12_CheckedChanged);
            // 
            // panelWritingMethod
            // 
            this.panelWritingMethod.Controls.Add(this.rbtnDYM);
            this.panelWritingMethod.Controls.Add(this.rbtnMYD);
            this.panelWritingMethod.Controls.Add(this.rbtnYDM);
            this.panelWritingMethod.Controls.Add(this.rbtnYMD);
            this.panelWritingMethod.Controls.Add(this.rbtnMDY);
            this.panelWritingMethod.Controls.Add(this.rbtnDMY);
            this.panelWritingMethod.Location = new System.Drawing.Point(17, 618);
            this.panelWritingMethod.Name = "panelWritingMethod";
            this.panelWritingMethod.Size = new System.Drawing.Size(251, 177);
            this.panelWritingMethod.TabIndex = 7;
            // 
            // rbtnDYM
            // 
            this.rbtnDYM.AutoSize = true;
            this.rbtnDYM.ForeColor = System.Drawing.Color.White;
            this.rbtnDYM.Location = new System.Drawing.Point(3, 150);
            this.rbtnDYM.Name = "rbtnDYM";
            this.rbtnDYM.Size = new System.Drawing.Size(117, 24);
            this.rbtnDYM.TabIndex = 5;
            this.rbtnDYM.TabStop = true;
            this.rbtnDYM.Text = "radioButton4";
            this.rbtnDYM.UseVisualStyleBackColor = true;
            this.rbtnDYM.CheckedChanged += new System.EventHandler(this.rbtnDYM_CheckedChanged);
            // 
            // rbtnMYD
            // 
            this.rbtnMYD.AutoSize = true;
            this.rbtnMYD.ForeColor = System.Drawing.Color.White;
            this.rbtnMYD.Location = new System.Drawing.Point(3, 123);
            this.rbtnMYD.Name = "rbtnMYD";
            this.rbtnMYD.Size = new System.Drawing.Size(117, 24);
            this.rbtnMYD.TabIndex = 4;
            this.rbtnMYD.TabStop = true;
            this.rbtnMYD.Text = "radioButton4";
            this.rbtnMYD.UseVisualStyleBackColor = true;
            this.rbtnMYD.CheckedChanged += new System.EventHandler(this.rbtnMYD_CheckedChanged);
            // 
            // rbtnYDM
            // 
            this.rbtnYDM.AutoSize = true;
            this.rbtnYDM.ForeColor = System.Drawing.Color.White;
            this.rbtnYDM.Location = new System.Drawing.Point(3, 93);
            this.rbtnYDM.Name = "rbtnYDM";
            this.rbtnYDM.Size = new System.Drawing.Size(117, 24);
            this.rbtnYDM.TabIndex = 3;
            this.rbtnYDM.TabStop = true;
            this.rbtnYDM.Text = "radioButton4";
            this.rbtnYDM.UseVisualStyleBackColor = true;
            this.rbtnYDM.CheckedChanged += new System.EventHandler(this.rbtnYDM_CheckedChanged);
            // 
            // rbtnYMD
            // 
            this.rbtnYMD.AutoSize = true;
            this.rbtnYMD.ForeColor = System.Drawing.Color.White;
            this.rbtnYMD.Location = new System.Drawing.Point(3, 63);
            this.rbtnYMD.Name = "rbtnYMD";
            this.rbtnYMD.Size = new System.Drawing.Size(117, 24);
            this.rbtnYMD.TabIndex = 2;
            this.rbtnYMD.TabStop = true;
            this.rbtnYMD.Text = "radioButton3";
            this.rbtnYMD.UseVisualStyleBackColor = true;
            this.rbtnYMD.CheckedChanged += new System.EventHandler(this.rbtnYMD_CheckedChanged);
            // 
            // rbtnMDY
            // 
            this.rbtnMDY.AutoSize = true;
            this.rbtnMDY.ForeColor = System.Drawing.Color.White;
            this.rbtnMDY.Location = new System.Drawing.Point(3, 33);
            this.rbtnMDY.Name = "rbtnMDY";
            this.rbtnMDY.Size = new System.Drawing.Size(117, 24);
            this.rbtnMDY.TabIndex = 1;
            this.rbtnMDY.TabStop = true;
            this.rbtnMDY.Text = "radioButton2";
            this.rbtnMDY.UseVisualStyleBackColor = true;
            this.rbtnMDY.CheckedChanged += new System.EventHandler(this.rbtnMDY_CheckedChanged);
            // 
            // rbtnDMY
            // 
            this.rbtnDMY.AutoSize = true;
            this.rbtnDMY.ForeColor = System.Drawing.Color.White;
            this.rbtnDMY.Location = new System.Drawing.Point(3, 3);
            this.rbtnDMY.Name = "rbtnDMY";
            this.rbtnDMY.Size = new System.Drawing.Size(117, 24);
            this.rbtnDMY.TabIndex = 0;
            this.rbtnDMY.TabStop = true;
            this.rbtnDMY.Text = "radioButton1";
            this.rbtnDMY.UseVisualStyleBackColor = true;
            this.rbtnDMY.CheckedChanged += new System.EventHandler(this.rbtnDMY_CheckedChanged);
            // 
            // panelFirstDay
            // 
            this.panelFirstDay.Controls.Add(this.rbtnSunday);
            this.panelFirstDay.Controls.Add(this.rbtnMonday);
            this.panelFirstDay.Location = new System.Drawing.Point(17, 459);
            this.panelFirstDay.Name = "panelFirstDay";
            this.panelFirstDay.Size = new System.Drawing.Size(251, 61);
            this.panelFirstDay.TabIndex = 8;
            // 
            // rbtnSunday
            // 
            this.rbtnSunday.AutoSize = true;
            this.rbtnSunday.ForeColor = System.Drawing.Color.White;
            this.rbtnSunday.Location = new System.Drawing.Point(3, 33);
            this.rbtnSunday.Name = "rbtnSunday";
            this.rbtnSunday.Size = new System.Drawing.Size(117, 24);
            this.rbtnSunday.TabIndex = 1;
            this.rbtnSunday.TabStop = true;
            this.rbtnSunday.Text = "radioButton2";
            this.rbtnSunday.UseVisualStyleBackColor = true;
            this.rbtnSunday.CheckedChanged += new System.EventHandler(this.rbtnSunday_CheckedChanged);
            // 
            // rbtnMonday
            // 
            this.rbtnMonday.AutoSize = true;
            this.rbtnMonday.ForeColor = System.Drawing.Color.White;
            this.rbtnMonday.Location = new System.Drawing.Point(3, 3);
            this.rbtnMonday.Name = "rbtnMonday";
            this.rbtnMonday.Size = new System.Drawing.Size(117, 24);
            this.rbtnMonday.TabIndex = 0;
            this.rbtnMonday.TabStop = true;
            this.rbtnMonday.Text = "radioButton1";
            this.rbtnMonday.UseVisualStyleBackColor = true;
            this.rbtnMonday.CheckedChanged += new System.EventHandler(this.rbtnMonday_CheckedChanged);
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstDay.ForeColor = System.Drawing.Color.White;
            this.lblFirstDay.Location = new System.Drawing.Point(10, 411);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(145, 45);
            this.lblFirstDay.TabIndex = 7;
            this.lblFirstDay.Text = "First Day";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Location = new System.Drawing.Point(17, 58);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(251, 28);
            this.cbxLanguage.TabIndex = 2;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.panelFirstDay);
            this.Controls.Add(this.lblFirstDay);
            this.Controls.Add(this.panelWritingMethod);
            this.Controls.Add(this.panelClockSystem);
            this.Controls.Add(this.pctbxSlider);
            this.Controls.Add(this.panelStyles);
            this.Controls.Add(this.lblClockSystem);
            this.Controls.Add(this.lblWritingMethod);
            this.Controls.Add(this.lblStyles);
            this.Controls.Add(this.lblLanguage);
            this.MinimumSize = new System.Drawing.Size(605, 430);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(605, 980);
            this.Load += new System.EventHandler(this.UserControlSettings_Load);
            this.panelStyles.ResumeLayout(false);
            this.panelStyles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxSlider)).EndInit();
            this.panelClockSystem.ResumeLayout(false);
            this.panelClockSystem.PerformLayout();
            this.panelWritingMethod.ResumeLayout(false);
            this.panelWritingMethod.PerformLayout();
            this.panelFirstDay.ResumeLayout(false);
            this.panelFirstDay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblStyles;
        private System.Windows.Forms.Label lblWritingMethod;
        private System.Windows.Forms.Label lblClockSystem;
        private System.Windows.Forms.Panel panelStyles;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.PictureBox pctbxSlider;
        private System.Windows.Forms.Panel panelClockSystem;
        private System.Windows.Forms.RadioButton rbtnClockSystem24;
        private System.Windows.Forms.RadioButton rbtnClockSystem12;
        private System.Windows.Forms.Panel panelWritingMethod;
        private System.Windows.Forms.RadioButton rbtnDYM;
        private System.Windows.Forms.RadioButton rbtnMYD;
        private System.Windows.Forms.RadioButton rbtnYDM;
        private System.Windows.Forms.RadioButton rbtnYMD;
        private System.Windows.Forms.RadioButton rbtnMDY;
        private System.Windows.Forms.RadioButton rbtnDMY;
        private System.Windows.Forms.Panel panelFirstDay;
        private System.Windows.Forms.RadioButton rbtnSunday;
        private System.Windows.Forms.RadioButton rbtnMonday;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.ComboBox cbxLanguage;
    }
}
