namespace Flippy_Floop
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
            this.components = new System.ComponentModel.Container();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.forgle = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoretxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipetop
            // 
            this.pipetop.Image = global::Flippy_Floop.Properties.Resources.pipeup_png;
            this.pipetop.Location = new System.Drawing.Point(448, 2);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 241);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 0;
            this.pipetop.TabStop = false;
            // 
            // forgle
            // 
            this.forgle.Image = global::Flippy_Floop.Properties.Resources.forgle;
            this.forgle.Location = new System.Drawing.Point(162, 284);
            this.forgle.Name = "forgle";
            this.forgle.Size = new System.Drawing.Size(100, 50);
            this.forgle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forgle.TabIndex = 1;
            this.forgle.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::Flippy_Floop.Properties.Resources.pipedown_png;
            this.pipebottom.Location = new System.Drawing.Point(448, 398);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(100, 226);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 2;
            this.pipebottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flippy_Floop.Properties.Resources.sand_png;
            this.ground.Location = new System.Drawing.Point(-10, 559);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(645, 118);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoretxt
            // 
            this.scoretxt.AutoSize = true;
            this.scoretxt.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoretxt.Location = new System.Drawing.Point(21, 19);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(97, 19);
            this.scoretxt.TabIndex = 4;
            this.scoretxt.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(626, 676);
            this.Controls.Add(this.scoretxt);
            this.Controls.Add(this.forgle);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Flippy Floop";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pipetop;
        private PictureBox forgle;
        private PictureBox pipebottom;
        private PictureBox ground;
        private Label scoretxt;
        private System.Windows.Forms.Timer timer1;
    }
}