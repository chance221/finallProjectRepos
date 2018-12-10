namespace FinalProjectSnakeGame
{
    partial class snakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snakeForm));
            this.picGamrBoard = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGamrBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picGamrBoard
            // 
            this.picGamrBoard.Location = new System.Drawing.Point(61, -23);
            this.picGamrBoard.Name = "picGamrBoard";
            this.picGamrBoard.Size = new System.Drawing.Size(420, 420);
            this.picGamrBoard.TabIndex = 0;
            this.picGamrBoard.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "bonus1.png");
            this.imgList1.Images.SetKeyName(1, "bonus2.png");
            this.imgList1.Images.SetKeyName(2, "bonus3.png");
            this.imgList1.Images.SetKeyName(3, "bonus4.png");
            this.imgList1.Images.SetKeyName(4, "snak_body.png");
            this.imgList1.Images.SetKeyName(5, "snake_head.png");
            this.imgList1.Images.SetKeyName(6, "wall.png");
            // 
            // snakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 442);
            this.Controls.Add(this.picGamrBoard);
            this.Name = "snakeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.snakeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnakeKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGamrBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGamrBoard;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imgList1;
    }
}

