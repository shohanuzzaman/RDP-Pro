namespace rdp3
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.animator2 = new BunifuAnimatorNS.Animator(this.components);
            this.blabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fileshare1 = new rdp3.fileshare();
            this.connect1 = new rdp3.connect();
            this.home11 = new rdp3.home1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.logo2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logo);
            this.animator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 502);
            this.panel1.TabIndex = 0;
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.animator2.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.logo2, BunifuAnimatorNS.DecorationType.None);
            this.logo2.Image = ((System.Drawing.Image)(resources.GetObject("logo2.Image")));
            this.logo2.ImageActive = null;
            this.logo2.Location = new System.Drawing.Point(12, 20);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(42, 52);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 7;
            this.logo2.TabStop = false;
            this.logo2.Zoom = 10;
            this.logo2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.animator2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(169, 20);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 52);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // button5
            // 
            this.animator1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(132)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.animator1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(132)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "File Share";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.animator1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(132)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remote Access";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.animator1.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(47, 75);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.blabel4);
            this.panel2.Controls.Add(this.blabel3);
            this.panel2.Controls.Add(this.bLabel2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.bLabel1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.animator2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 40);
            this.panel2.TabIndex = 1;
            // 
            // blabel3
            // 
            this.animator1.SetDecoration(this.blabel3, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.blabel3, BunifuAnimatorNS.DecorationType.None);
            this.blabel3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel3.ForeColor = System.Drawing.Color.White;
            this.blabel3.Location = new System.Drawing.Point(33, 9);
            this.blabel3.Name = "blabel3";
            this.blabel3.Size = new System.Drawing.Size(266, 31);
            this.blabel3.TabIndex = 10;
            this.blabel3.Text = "Remote Computer\'s Informations";
            // 
            // bLabel2
            // 
            this.animator1.SetDecoration(this.bLabel2, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bLabel2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel2.ForeColor = System.Drawing.Color.White;
            this.bLabel2.Location = new System.Drawing.Point(33, 9);
            this.bLabel2.Name = "bLabel2";
            this.bLabel2.Size = new System.Drawing.Size(125, 31);
            this.bLabel2.TabIndex = 9;
            this.bLabel2.Text = "VPN Setup";
            // 
            // panel3
            // 
            this.animator2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(74, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 493);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(888, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.animator1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(917, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 25);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bLabel1
            // 
            this.animator1.SetDecoration(this.bLabel1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bLabel1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel1.ForeColor = System.Drawing.Color.White;
            this.bLabel1.Location = new System.Drawing.Point(33, 9);
            this.bLabel1.Name = "bLabel1";
            this.bLabel1.Size = new System.Drawing.Size(125, 31);
            this.bLabel1.TabIndex = 2;
            this.bLabel1.Text = "Starting Menu";
            this.bLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // pictureBox2
            // 
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.animator1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation3;
            // 
            // label2
            // 
            this.animator1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(133)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(476, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Want to make new connection?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // go
            // 
            this.go.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("go.BackgroundImage")));
            this.go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.go, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.animator2.SetDecoration(this.go, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.go.FlatAppearance.BorderSize = 0;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(538, 238);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(154, 52);
            this.go.TabIndex = 4;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // back
            // 
            this.animator1.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.back.FlatAppearance.BorderSize = 2;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(40)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(266, 462);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 43);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.animator1.SetDecoration(this.next, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.next, BunifuAnimatorNS.DecorationType.None);
            this.next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.next.FlatAppearance.BorderSize = 2;
            this.next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(231)))), ((int)(((byte)(129)))));
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(799, 462);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(112, 43);
            this.next.TabIndex = 8;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.animator1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(133)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(525, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wellcome Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // animator2
            // 
            this.animator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animator2.DefaultAnimation = animation4;
            // 
            // blabel4
            // 
            this.animator1.SetDecoration(this.blabel4, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.blabel4, BunifuAnimatorNS.DecorationType.None);
            this.blabel4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel4.ForeColor = System.Drawing.Color.White;
            this.blabel4.Location = new System.Drawing.Point(33, 9);
            this.blabel4.Name = "blabel4";
            this.blabel4.Size = new System.Drawing.Size(241, 31);
            this.blabel4.TabIndex = 11;
            this.blabel4.Text = "File Share between two Computer";
            // 
            // fileshare1
            // 
            this.fileshare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.animator1.SetDecoration(this.fileshare1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.fileshare1, BunifuAnimatorNS.DecorationType.None);
            this.fileshare1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileshare1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.fileshare1.Location = new System.Drawing.Point(255, 41);
            this.fileshare1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.fileshare1.Name = "fileshare1";
            this.fileshare1.Size = new System.Drawing.Size(685, 412);
            this.fileshare1.TabIndex = 15;
            // 
            // connect1
            // 
            this.connect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.animator1.SetDecoration(this.connect1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.connect1, BunifuAnimatorNS.DecorationType.None);
            this.connect1.Location = new System.Drawing.Point(245, 40);
            this.connect1.Name = "connect1";
            this.connect1.Size = new System.Drawing.Size(698, 413);
            this.connect1.TabIndex = 12;
            // 
            // home11
            // 
            this.home11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.animator1.SetDecoration(this.home11, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.home11, BunifuAnimatorNS.DecorationType.None);
            this.home11.Location = new System.Drawing.Point(238, 40);
            this.home11.Name = "home11";
            this.home11.Size = new System.Drawing.Size(705, 403);
            this.home11.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(943, 530);
            this.Controls.Add(this.fileshare1);
            this.Controls.Add(this.connect1);
            this.Controls.Add(this.home11);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(231)))), ((int)(((byte)(129)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.Animator animator1;
        private BunifuAnimatorNS.Animator animator2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuImageButton logo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bLabel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private home1 home11;
        private System.Windows.Forms.Label label1;
        private connect connect1;
        private Bunifu.Framework.UI.BunifuCustomLabel blabel3;
        private fileshare fileshare1;
        private Bunifu.Framework.UI.BunifuCustomLabel blabel4;
    }
}

