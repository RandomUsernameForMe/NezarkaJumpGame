namespace JumpingPlatformGame {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.worldPanel = new System.Windows.Forms.Panel();
            this.jumpingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.customer_listBox = new System.Windows.Forms.ListBox();
            this.button_add_customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // worldPanel
            // 
            this.worldPanel.BackColor = System.Drawing.Color.White;
            this.worldPanel.Location = new System.Drawing.Point(16, 50);
            this.worldPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.worldPanel.Name = "worldPanel";
            this.worldPanel.Size = new System.Drawing.Size(928, 512);
            this.worldPanel.TabIndex = 0;
            // 
            // jumpingPanel
            // 
            this.jumpingPanel.BackColor = System.Drawing.Color.Khaki;
            this.jumpingPanel.Location = new System.Drawing.Point(16, 570);
            this.jumpingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jumpingPanel.Name = "jumpingPanel";
            this.jumpingPanel.Size = new System.Drawing.Size(1133, 118);
            this.jumpingPanel.TabIndex = 1;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 40;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // customer_listBox
            // 
            this.customer_listBox.FormattingEnabled = true;
            this.customer_listBox.ItemHeight = 16;
            this.customer_listBox.Location = new System.Drawing.Point(951, 50);
            this.customer_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_listBox.Name = "customer_listBox";
            this.customer_listBox.Size = new System.Drawing.Size(201, 404);
            this.customer_listBox.TabIndex = 6;
            // 
            // button_add_customer
            // 
            this.button_add_customer.Location = new System.Drawing.Point(951, 460);
            this.button_add_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_customer.Name = "button_add_customer";
            this.button_add_customer.Size = new System.Drawing.Size(201, 103);
            this.button_add_customer.TabIndex = 7;
            this.button_add_customer.Text = "Add Customer Boxcar";
            this.button_add_customer.UseVisualStyleBackColor = true;
            this.button_add_customer.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 703);
            this.Controls.Add(this.button_add_customer);
            this.Controls.Add(this.customer_listBox);
            this.Controls.Add(this.jumpingPanel);
            this.Controls.Add(this.worldPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Jumping Platform Game";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel worldPanel;
		private System.Windows.Forms.FlowLayoutPanel jumpingPanel;
		private System.Windows.Forms.Timer updateTimer;
		private System.Windows.Forms.ListBox customer_listBox;
		private System.Windows.Forms.Button button_add_customer;
	}
}

