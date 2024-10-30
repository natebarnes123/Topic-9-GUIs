namespace Topic_9_GUIs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgUnused = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUnused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(224, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 58);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click me";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // imgUnused
            // 
            this.imgUnused.Image = ((System.Drawing.Image)(resources.GetObject("imgUnused.Image")));
            this.imgUnused.Location = new System.Drawing.Point(611, 12);
            this.imgUnused.Name = "imgUnused";
            this.imgUnused.Size = new System.Drawing.Size(127, 140);
            this.imgUnused.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUnused.TabIndex = 1;
            this.imgUnused.TabStop = false;
            this.imgUnused.Visible = false;
            this.imgUnused.Click += new System.EventHandler(this.imgUnused_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(297, 243);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(160, 13);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Click on the button or picturebox";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(297, 271);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // imgCharacter
            // 
            this.imgCharacter.Image = ((System.Drawing.Image)(resources.GetObject("imgCharacter.Image")));
            this.imgCharacter.Location = new System.Drawing.Point(316, 40);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(227, 112);
            this.imgCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCharacter.TabIndex = 4;
            this.imgCharacter.TabStop = false;
            this.imgCharacter.Visible = false;
            this.imgCharacter.Click += new System.EventHandler(this.imgCharacter_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(224, 84);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 56);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.imgUnused);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Controls, events and properties";
            ((System.ComponentModel.ISupportInitialize)(this.imgUnused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox imgUnused;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Button btnQuit;
    }
}

