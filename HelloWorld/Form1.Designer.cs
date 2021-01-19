
namespace HelloWorld
{
    partial class Form1
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
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.lblDisplayInfo = new System.Windows.Forms.Label();
            this.bntMessage = new System.Windows.Forms.Button();
            this.bntGoodbye = new System.Windows.Forms.Button();
            this.gifEarth = new System.Windows.Forms.PictureBox();
            this.bntShowPic = new System.Windows.Forms.Button();
            this.bntHideWorld = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gifEarth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelloWorld.Location = new System.Drawing.Point(113, 64);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(89, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Say Hello";
            this.btnHelloWorld.UseVisualStyleBackColor = false;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // lblDisplayInfo
            // 
            this.lblDisplayInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayInfo.Location = new System.Drawing.Point(12, 10);
            this.lblDisplayInfo.Name = "lblDisplayInfo";
            this.lblDisplayInfo.Size = new System.Drawing.Size(190, 43);
            this.lblDisplayInfo.TabIndex = 1;
            this.lblDisplayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplayInfo.Click += new System.EventHandler(this.lblDisplayInfo_Click);
            // 
            // bntMessage
            // 
            this.bntMessage.BackColor = System.Drawing.SystemColors.Control;
            this.bntMessage.Location = new System.Drawing.Point(12, 93);
            this.bntMessage.Name = "bntMessage";
            this.bntMessage.Size = new System.Drawing.Size(190, 23);
            this.bntMessage.TabIndex = 2;
            this.bntMessage.Text = "Display Message";
            this.bntMessage.UseVisualStyleBackColor = false;
            this.bntMessage.Click += new System.EventHandler(this.bntMessage_Click);
            // 
            // bntGoodbye
            // 
            this.bntGoodbye.BackColor = System.Drawing.SystemColors.Control;
            this.bntGoodbye.Location = new System.Drawing.Point(12, 64);
            this.bntGoodbye.Name = "bntGoodbye";
            this.bntGoodbye.Size = new System.Drawing.Size(89, 23);
            this.bntGoodbye.TabIndex = 3;
            this.bntGoodbye.Text = "Say Goodbye";
            this.bntGoodbye.UseVisualStyleBackColor = false;
            this.bntGoodbye.Click += new System.EventHandler(this.bntGoodbye_Click);
            // 
            // gifEarth
            // 
            this.gifEarth.Image = global::HelloWorld.Properties.Resources._263dad672dd27fb2b588e9690a14a19a;
            this.gifEarth.Location = new System.Drawing.Point(208, 10);
            this.gifEarth.Name = "gifEarth";
            this.gifEarth.Size = new System.Drawing.Size(168, 164);
            this.gifEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifEarth.TabIndex = 4;
            this.gifEarth.TabStop = false;
            this.gifEarth.Visible = false;
            this.gifEarth.Click += new System.EventHandler(this.gifEarth_Click);
            // 
            // bntShowPic
            // 
            this.bntShowPic.BackColor = System.Drawing.SystemColors.Control;
            this.bntShowPic.Location = new System.Drawing.Point(12, 122);
            this.bntShowPic.Name = "bntShowPic";
            this.bntShowPic.Size = new System.Drawing.Size(89, 23);
            this.bntShowPic.TabIndex = 5;
            this.bntShowPic.Text = "Show World";
            this.bntShowPic.UseVisualStyleBackColor = false;
            this.bntShowPic.Click += new System.EventHandler(this.bntShowPic_Click);
            // 
            // bntHideWorld
            // 
            this.bntHideWorld.BackColor = System.Drawing.SystemColors.Control;
            this.bntHideWorld.Location = new System.Drawing.Point(113, 122);
            this.bntHideWorld.Name = "bntHideWorld";
            this.bntHideWorld.Size = new System.Drawing.Size(89, 23);
            this.bntHideWorld.TabIndex = 6;
            this.bntHideWorld.Text = "Hide World";
            this.bntHideWorld.UseVisualStyleBackColor = false;
            this.bntHideWorld.Click += new System.EventHandler(this.bntHideWorld_Click);
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.SystemColors.Control;
            this.bntClose.Location = new System.Drawing.Point(12, 151);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(190, 23);
            this.bntClose.TabIndex = 7;
            this.bntClose.Text = "Exit";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 185);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntHideWorld);
            this.Controls.Add(this.bntShowPic);
            this.Controls.Add(this.gifEarth);
            this.Controls.Add(this.bntGoodbye);
            this.Controls.Add(this.bntMessage);
            this.Controls.Add(this.lblDisplayInfo);
            this.Controls.Add(this.btnHelloWorld);
            this.Name = "Form1";
            this.Text = "Hello World";
            ((System.ComponentModel.ISupportInitialize)(this.gifEarth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Label lblDisplayInfo;
        private System.Windows.Forms.Button bntMessage;
        private System.Windows.Forms.Button bntGoodbye;
        private System.Windows.Forms.PictureBox gifEarth;
        private System.Windows.Forms.Button bntShowPic;
        private System.Windows.Forms.Button bntHideWorld;
        private System.Windows.Forms.Button bntClose;
    }
}

