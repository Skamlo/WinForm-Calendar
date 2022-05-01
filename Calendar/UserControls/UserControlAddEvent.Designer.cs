
namespace Calendar.UserControls
{
    partial class UserControlAddEvent
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
            this.lblAddNewEvent = new System.Windows.Forms.Label();
            this.pctbxAddNewEvent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxAddNewEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewEvent
            // 
            this.lblAddNewEvent.AutoSize = true;
            this.lblAddNewEvent.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewEvent.ForeColor = System.Drawing.Color.White;
            this.lblAddNewEvent.Location = new System.Drawing.Point(155, 41);
            this.lblAddNewEvent.Name = "lblAddNewEvent";
            this.lblAddNewEvent.Size = new System.Drawing.Size(480, 67);
            this.lblAddNewEvent.TabIndex = 0;
            this.lblAddNewEvent.Text = "Add new event (this)";
            this.lblAddNewEvent.Click += new System.EventHandler(this.lblAddNewEvent_Click);
            this.lblAddNewEvent.MouseEnter += new System.EventHandler(this.lblAddNewEvent_MouseEnter);
            this.lblAddNewEvent.MouseLeave += new System.EventHandler(this.lblAddNewEvent_MouseLeave);
            // 
            // pctbxAddNewEvent
            // 
            this.pctbxAddNewEvent.BackgroundImage = global::Calendar.Properties.Resources.addEvent150x150;
            this.pctbxAddNewEvent.Location = new System.Drawing.Point(0, 0);
            this.pctbxAddNewEvent.Name = "pctbxAddNewEvent";
            this.pctbxAddNewEvent.Size = new System.Drawing.Size(150, 150);
            this.pctbxAddNewEvent.TabIndex = 1;
            this.pctbxAddNewEvent.TabStop = false;
            this.pctbxAddNewEvent.Click += new System.EventHandler(this.pctbxAddNewEvent_Click);
            this.pctbxAddNewEvent.MouseEnter += new System.EventHandler(this.pctbxAddNewEvent_MouseEnter);
            this.pctbxAddNewEvent.MouseLeave += new System.EventHandler(this.pctbxAddNewEvent_MouseLeave);
            // 
            // UserControlAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.pctbxAddNewEvent);
            this.Controls.Add(this.lblAddNewEvent);
            this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Name = "UserControlAddEvent";
            this.Size = new System.Drawing.Size(515, 150);
            this.Load += new System.EventHandler(this.UserControlAddEvent_Load);
            this.SizeChanged += new System.EventHandler(this.UserControlAddEvent_SizeChanged);
            this.Click += new System.EventHandler(this.UserControlAddEvent_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlAddEvent_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlAddEvent_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxAddNewEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewEvent;
        private System.Windows.Forms.PictureBox pctbxAddNewEvent;
    }
}
