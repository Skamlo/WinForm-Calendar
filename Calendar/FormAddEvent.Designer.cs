
namespace Calendar
{
    partial class FormAddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEvent));
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.pctbxTitle = new System.Windows.Forms.PictureBox();
            this.pctbxTime = new System.Windows.Forms.PictureBox();
            this.pctbxDescription = new System.Windows.Forms.PictureBox();
            this.txtbxStartDate = new System.Windows.Forms.TextBox();
            this.pctbxArrow = new System.Windows.Forms.PictureBox();
            this.txtbxDescription = new System.Windows.Forms.RichTextBox();
            this.txtbxStartHour = new System.Windows.Forms.TextBox();
            this.txtbxEndDate = new System.Windows.Forms.TextBox();
            this.txtbxEndHour = new System.Windows.Forms.TextBox();
            this.lblTimeBetween = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.BackColor = System.Drawing.Color.Gray;
            this.txtbxTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtbxTitle.Location = new System.Drawing.Point(48, 12);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(576, 30);
            this.txtbxTitle.TabIndex = 0;
            this.txtbxTitle.TextChanged += new System.EventHandler(this.txtbxTitle_TextChanged);
            // 
            // pctbxTitle
            // 
            this.pctbxTitle.BackgroundImage = global::Calendar.Properties.Resources.edit30x30;
            this.pctbxTitle.Location = new System.Drawing.Point(12, 12);
            this.pctbxTitle.Name = "pctbxTitle";
            this.pctbxTitle.Size = new System.Drawing.Size(30, 30);
            this.pctbxTitle.TabIndex = 2;
            this.pctbxTitle.TabStop = false;
            // 
            // pctbxTime
            // 
            this.pctbxTime.BackgroundImage = global::Calendar.Properties.Resources.time30x30;
            this.pctbxTime.Location = new System.Drawing.Point(12, 48);
            this.pctbxTime.Name = "pctbxTime";
            this.pctbxTime.Size = new System.Drawing.Size(30, 30);
            this.pctbxTime.TabIndex = 3;
            this.pctbxTime.TabStop = false;
            // 
            // pctbxDescription
            // 
            this.pctbxDescription.BackgroundImage = global::Calendar.Properties.Resources.description30x30;
            this.pctbxDescription.Location = new System.Drawing.Point(12, 84);
            this.pctbxDescription.Name = "pctbxDescription";
            this.pctbxDescription.Size = new System.Drawing.Size(30, 30);
            this.pctbxDescription.TabIndex = 4;
            this.pctbxDescription.TabStop = false;
            // 
            // txtbxStartDate
            // 
            this.txtbxStartDate.BackColor = System.Drawing.Color.Gray;
            this.txtbxStartDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxStartDate.ForeColor = System.Drawing.Color.White;
            this.txtbxStartDate.Location = new System.Drawing.Point(48, 48);
            this.txtbxStartDate.Name = "txtbxStartDate";
            this.txtbxStartDate.Size = new System.Drawing.Size(107, 30);
            this.txtbxStartDate.TabIndex = 5;
            this.txtbxStartDate.Text = "12.12.2022";
            this.txtbxStartDate.Leave += new System.EventHandler(this.txtbxStartDate_Leave);
            // 
            // pctbxArrow
            // 
            this.pctbxArrow.BackgroundImage = global::Calendar.Properties.Resources.arrow30x30;
            this.pctbxArrow.Location = new System.Drawing.Point(274, 48);
            this.pctbxArrow.Name = "pctbxArrow";
            this.pctbxArrow.Size = new System.Drawing.Size(30, 30);
            this.pctbxArrow.TabIndex = 9;
            this.pctbxArrow.TabStop = false;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.BackColor = System.Drawing.Color.Gray;
            this.txtbxDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtbxDescription.Location = new System.Drawing.Point(48, 84);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Size = new System.Drawing.Size(576, 75);
            this.txtbxDescription.TabIndex = 10;
            this.txtbxDescription.Text = "";
            this.txtbxDescription.TextChanged += new System.EventHandler(this.txtbxDescription_TextChanged);
            // 
            // txtbxStartHour
            // 
            this.txtbxStartHour.BackColor = System.Drawing.Color.Gray;
            this.txtbxStartHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxStartHour.ForeColor = System.Drawing.Color.White;
            this.txtbxStartHour.Location = new System.Drawing.Point(161, 48);
            this.txtbxStartHour.Name = "txtbxStartHour";
            this.txtbxStartHour.Size = new System.Drawing.Size(107, 30);
            this.txtbxStartHour.TabIndex = 11;
            this.txtbxStartHour.Text = "11:30 pm";
            this.txtbxStartHour.Leave += new System.EventHandler(this.txtbxStartHour_Leave);
            // 
            // txtbxEndDate
            // 
            this.txtbxEndDate.BackColor = System.Drawing.Color.Gray;
            this.txtbxEndDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxEndDate.ForeColor = System.Drawing.Color.White;
            this.txtbxEndDate.Location = new System.Drawing.Point(310, 48);
            this.txtbxEndDate.Name = "txtbxEndDate";
            this.txtbxEndDate.Size = new System.Drawing.Size(107, 30);
            this.txtbxEndDate.TabIndex = 12;
            this.txtbxEndDate.Leave += new System.EventHandler(this.txtbxEndDate_Leave);
            // 
            // txtbxEndHour
            // 
            this.txtbxEndHour.BackColor = System.Drawing.Color.Gray;
            this.txtbxEndHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxEndHour.ForeColor = System.Drawing.Color.White;
            this.txtbxEndHour.Location = new System.Drawing.Point(423, 48);
            this.txtbxEndHour.Name = "txtbxEndHour";
            this.txtbxEndHour.Size = new System.Drawing.Size(107, 30);
            this.txtbxEndHour.TabIndex = 13;
            this.txtbxEndHour.Leave += new System.EventHandler(this.txtbxEndHour_Leave);
            // 
            // lblTimeBetween
            // 
            this.lblTimeBetween.AutoSize = true;
            this.lblTimeBetween.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeBetween.ForeColor = System.Drawing.Color.White;
            this.lblTimeBetween.Location = new System.Drawing.Point(536, 49);
            this.lblTimeBetween.Name = "lblTimeBetween";
            this.lblTimeBetween.Size = new System.Drawing.Size(88, 28);
            this.lblTimeBetween.TabIndex = 14;
            this.lblTimeBetween.Text = "23 godz.";
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Gray;
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(530, 165);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(94, 29);
            this.btnCancle.TabIndex = 15;
            this.btnCancle.Text = "button1";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(430, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(830, 345);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.lblTimeBetween);
            this.Controls.Add(this.txtbxEndHour);
            this.Controls.Add(this.txtbxEndDate);
            this.Controls.Add(this.txtbxStartHour);
            this.Controls.Add(this.txtbxDescription);
            this.Controls.Add(this.pctbxArrow);
            this.Controls.Add(this.txtbxStartDate);
            this.Controls.Add(this.pctbxDescription);
            this.Controls.Add(this.pctbxTime);
            this.Controls.Add(this.pctbxTitle);
            this.Controls.Add(this.txtbxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(654, 262);
            this.Name = "FormAddEvent";
            this.Text = "FormAddEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddEvent_FormClosed);
            this.Load += new System.EventHandler(this.FormAddEvent_Load);
            this.SizeChanged += new System.EventHandler(this.FormAddEvent_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.PictureBox pctbxTitle;
        private System.Windows.Forms.PictureBox pctbxTime;
        private System.Windows.Forms.PictureBox pctbxDescription;
        private System.Windows.Forms.TextBox txtbxStartDate;
        private System.Windows.Forms.PictureBox pctbxArrow;
        private System.Windows.Forms.RichTextBox txtbxDescription;
        private System.Windows.Forms.TextBox txtbxStartHour;
        private System.Windows.Forms.TextBox txtbxEndDate;
        private System.Windows.Forms.TextBox txtbxEndHour;
        private System.Windows.Forms.Label lblTimeBetween;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
    }
}