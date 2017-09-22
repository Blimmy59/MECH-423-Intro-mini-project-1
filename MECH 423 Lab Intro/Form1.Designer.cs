namespace MECH_423_Lab_Intro
{
    partial class frmMainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblY;
            System.Windows.Forms.Label lblX;
            System.Windows.Forms.Label lblDeltaT;
            this.txtXCoord = new System.Windows.Forms.TextBox();
            this.txtYCoord = new System.Windows.Forms.TextBox();
            this.lstDeltaTime = new System.Windows.Forms.ListBox();
            this.txtDrawingWindow = new System.Windows.Forms.TextBox();
            this.tmrMoveDelayCounter = new System.Windows.Forms.Timer(this.components);
            lblY = new System.Windows.Forms.Label();
            lblX = new System.Windows.Forms.Label();
            lblDeltaT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblY.Location = new System.Drawing.Point(12, 126);
            lblY.Name = "lblY";
            lblY.Size = new System.Drawing.Size(63, 42);
            lblY.TabIndex = 0;
            lblY.Text = "Y :";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblX.Location = new System.Drawing.Point(12, 45);
            lblX.Name = "lblX";
            lblX.Size = new System.Drawing.Size(63, 42);
            lblX.TabIndex = 1;
            lblX.Text = "X :";
            // 
            // lblDeltaT
            // 
            lblDeltaT.AutoSize = true;
            lblDeltaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDeltaT.Location = new System.Drawing.Point(12, 192);
            lblDeltaT.Name = "lblDeltaT";
            lblDeltaT.Size = new System.Drawing.Size(138, 42);
            lblDeltaT.TabIndex = 2;
            lblDeltaT.Text = "Delta T";
            // 
            // txtXCoord
            // 
            this.txtXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXCoord.Location = new System.Drawing.Point(81, 45);
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Size = new System.Drawing.Size(134, 49);
            this.txtXCoord.TabIndex = 3;
            // 
            // txtYCoord
            // 
            this.txtYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYCoord.Location = new System.Drawing.Point(81, 126);
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.Size = new System.Drawing.Size(134, 49);
            this.txtYCoord.TabIndex = 4;
            // 
            // lstDeltaTime
            // 
            this.lstDeltaTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDeltaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeltaTime.FormattingEnabled = true;
            this.lstDeltaTime.ItemHeight = 42;
            this.lstDeltaTime.Location = new System.Drawing.Point(19, 237);
            this.lstDeltaTime.Name = "lstDeltaTime";
            this.lstDeltaTime.Size = new System.Drawing.Size(196, 592);
            this.lstDeltaTime.TabIndex = 5;
            // 
            // txtDrawingWindow
            // 
            this.txtDrawingWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrawingWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawingWindow.Location = new System.Drawing.Point(262, 45);
            this.txtDrawingWindow.Multiline = true;
            this.txtDrawingWindow.Name = "txtDrawingWindow";
            this.txtDrawingWindow.ReadOnly = true;
            this.txtDrawingWindow.Size = new System.Drawing.Size(788, 836);
            this.txtDrawingWindow.TabIndex = 6;
            this.txtDrawingWindow.Text = "Drawing Window";
            this.txtDrawingWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDrawingWindow_MouseMove);
            // 
            // tmrMoveDelayCounter
            // 
            this.tmrMoveDelayCounter.Enabled = true;
            this.tmrMoveDelayCounter.Interval = 50;
            this.tmrMoveDelayCounter.Tick += new System.EventHandler(this.tmrMoveDelayCounter_Tick);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 924);
            this.Controls.Add(this.txtDrawingWindow);
            this.Controls.Add(this.lstDeltaTime);
            this.Controls.Add(this.txtYCoord);
            this.Controls.Add(this.txtXCoord);
            this.Controls.Add(lblDeltaT);
            this.Controls.Add(lblX);
            this.Controls.Add(lblY);
            this.MinimumSize = new System.Drawing.Size(620, 420);
            this.Name = "frmMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.TextBox txtYCoord;
        private System.Windows.Forms.ListBox lstDeltaTime;
        private System.Windows.Forms.TextBox txtDrawingWindow;
        private System.Windows.Forms.Timer tmrMoveDelayCounter;
    }
}

