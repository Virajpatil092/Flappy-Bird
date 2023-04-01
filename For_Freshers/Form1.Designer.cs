namespace For_Freshers
{
    partial class Gameop
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.Scoretext = new System.Windows.Forms.Label();
            this.Bottompipe = new System.Windows.Forms.PictureBox();
            this.Toppipe = new System.Windows.Forms.PictureBox();
            this.maincharacter = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bottompipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toppipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maincharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // Scoretext
            // 
            this.Scoretext.AutoSize = true;
            this.Scoretext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretext.Location = new System.Drawing.Point(40, 428);
            this.Scoretext.Name = "Scoretext";
            this.Scoretext.Size = new System.Drawing.Size(121, 42);
            this.Scoretext.TabIndex = 4;
            this.Scoretext.Text = "Score";
            // 
            // Bottompipe
            // 
            this.Bottompipe.Image = global::For_Freshers.Properties.Resources.pipe;
            this.Bottompipe.Location = new System.Drawing.Point(369, 288);
            this.Bottompipe.Name = "Bottompipe";
            this.Bottompipe.Size = new System.Drawing.Size(100, 131);
            this.Bottompipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bottompipe.TabIndex = 3;
            this.Bottompipe.TabStop = false;
            // 
            // Toppipe
            // 
            this.Toppipe.Image = global::For_Freshers.Properties.Resources.pipedown;
            this.Toppipe.Location = new System.Drawing.Point(710, -3);
            this.Toppipe.Name = "Toppipe";
            this.Toppipe.Size = new System.Drawing.Size(100, 159);
            this.Toppipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toppipe.TabIndex = 2;
            this.Toppipe.TabStop = false;
            // 
            // maincharacter
            // 
            this.maincharacter.Image = global::For_Freshers.Properties.Resources.bird1;
            this.maincharacter.Location = new System.Drawing.Point(88, 106);
            this.maincharacter.Name = "maincharacter";
            this.maincharacter.Size = new System.Drawing.Size(73, 50);
            this.maincharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maincharacter.TabIndex = 1;
            this.maincharacter.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::For_Freshers.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(12, 415);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(820, 74);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Gameop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(849, 516);
            this.Controls.Add(this.Scoretext);
            this.Controls.Add(this.Bottompipe);
            this.Controls.Add(this.Toppipe);
            this.Controls.Add(this.maincharacter);
            this.Controls.Add(this.Ground);
            this.Name = "Gameop";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Goup);
            ((System.ComponentModel.ISupportInitialize)(this.Bottompipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toppipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maincharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox maincharacter;
        private System.Windows.Forms.PictureBox Toppipe;
        private System.Windows.Forms.PictureBox Bottompipe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.Label Scoretext;
    }
}

