namespace Hello_better_world_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.x_cords = new System.Windows.Forms.Label();
            this.y_cords = new System.Windows.Forms.Label();
            this.NumericSeed = new System.Windows.Forms.NumericUpDown();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.NumericOctaves = new System.Windows.Forms.NumericUpDown();
            this.OctavesLabel = new System.Windows.Forms.Label();
            this.ZoomLabel = new System.Windows.Forms.Label();
            this.NumericZoom = new System.Windows.Forms.NumericUpDown();
            this.JumpLabel = new System.Windows.Forms.Label();
            this.NumericJump = new System.Windows.Forms.NumericUpDown();
            this.NoiseType = new System.Windows.Forms.ListBox();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.NumericLight = new System.Windows.Forms.NumericUpDown();
            this.NumericGrey = new System.Windows.Forms.NumericUpDown();
            this.NumericLightGrey = new System.Windows.Forms.NumericUpDown();
            this.NumericGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericLightGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericYellow = new System.Windows.Forms.NumericUpDown();
            this.NumericBlue = new System.Windows.Forms.NumericUpDown();
            this.NumericDarkBlue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumericFrequence = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericOctaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLightGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLightGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDarkBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFrequence)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 560);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x_cords
            // 
            this.x_cords.AutoSize = true;
            this.x_cords.Location = new System.Drawing.Point(848, 9);
            this.x_cords.Name = "x_cords";
            this.x_cords.Size = new System.Drawing.Size(26, 13);
            this.x_cords.TabIndex = 2;
            this.x_cords.Text = "X: 0";
            // 
            // y_cords
            // 
            this.y_cords.AutoSize = true;
            this.y_cords.Location = new System.Drawing.Point(918, 9);
            this.y_cords.Name = "y_cords";
            this.y_cords.Size = new System.Drawing.Size(26, 13);
            this.y_cords.TabIndex = 3;
            this.y_cords.Text = "Y: 0";
            // 
            // NumericSeed
            // 
            this.NumericSeed.Location = new System.Drawing.Point(905, 52);
            this.NumericSeed.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.NumericSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericSeed.Name = "NumericSeed";
            this.NumericSeed.Size = new System.Drawing.Size(91, 20);
            this.NumericSeed.TabIndex = 5;
            this.NumericSeed.Value = new decimal(new int[] {
            123456,
            0,
            0,
            0});
            this.NumericSeed.ValueChanged += new System.EventHandler(this.NumericSeed_ValueChanged);
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(845, 54);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(35, 13);
            this.SeedLabel.TabIndex = 6;
            this.SeedLabel.Text = "Seed:";
            // 
            // NumericOctaves
            // 
            this.NumericOctaves.Location = new System.Drawing.Point(905, 79);
            this.NumericOctaves.Name = "NumericOctaves";
            this.NumericOctaves.Size = new System.Drawing.Size(91, 20);
            this.NumericOctaves.TabIndex = 7;
            this.NumericOctaves.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumericOctaves.ValueChanged += new System.EventHandler(this.NumericOctaves_ValueChanged);
            // 
            // OctavesLabel
            // 
            this.OctavesLabel.AutoSize = true;
            this.OctavesLabel.Location = new System.Drawing.Point(845, 81);
            this.OctavesLabel.Name = "OctavesLabel";
            this.OctavesLabel.Size = new System.Drawing.Size(50, 13);
            this.OctavesLabel.TabIndex = 8;
            this.OctavesLabel.Text = "Octaves:";
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = true;
            this.ZoomLabel.Location = new System.Drawing.Point(847, 107);
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(37, 13);
            this.ZoomLabel.TabIndex = 9;
            this.ZoomLabel.Text = "Zoom:";
            // 
            // NumericZoom
            // 
            this.NumericZoom.DecimalPlaces = 6;
            this.NumericZoom.Location = new System.Drawing.Point(905, 105);
            this.NumericZoom.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericZoom.Name = "NumericZoom";
            this.NumericZoom.Size = new System.Drawing.Size(91, 20);
            this.NumericZoom.TabIndex = 10;
            this.NumericZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NumericZoom.ValueChanged += new System.EventHandler(this.NumericZoom_ValueChanged);
            // 
            // JumpLabel
            // 
            this.JumpLabel.AutoSize = true;
            this.JumpLabel.Location = new System.Drawing.Point(849, 133);
            this.JumpLabel.Name = "JumpLabel";
            this.JumpLabel.Size = new System.Drawing.Size(35, 13);
            this.JumpLabel.TabIndex = 11;
            this.JumpLabel.Text = "Jump:";
            // 
            // NumericJump
            // 
            this.NumericJump.Location = new System.Drawing.Point(905, 131);
            this.NumericJump.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericJump.Name = "NumericJump";
            this.NumericJump.Size = new System.Drawing.Size(91, 20);
            this.NumericJump.TabIndex = 12;
            this.NumericJump.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericJump.ValueChanged += new System.EventHandler(this.NumericJump_ValueChanged);
            // 
            // NoiseType
            // 
            this.NoiseType.FormattingEnabled = true;
            this.NoiseType.Items.AddRange(new object[] {
            "PerlinFractal",
            "Perlin",
            "SimplexFractal",
            "Simplex",
            "CubicFractal",
            "Cubic",
            "CellularFractal",
            "Cellular",
            "WhiteNoise"});
            this.NoiseType.Location = new System.Drawing.Point(848, 412);
            this.NoiseType.Name = "NoiseType";
            this.NoiseType.Size = new System.Drawing.Size(148, 56);
            this.NoiseType.TabIndex = 13;
            this.NoiseType.SelectedIndexChanged += new System.EventHandler(this.NoiseType_SelectedIndexChanged);
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(848, 478);
            this.LoadingBar.Maximum = 471520;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(148, 17);
            this.LoadingBar.Step = 1;
            this.LoadingBar.TabIndex = 14;
            this.LoadingBar.Visible = false;
            // 
            // NumericLight
            // 
            this.NumericLight.DecimalPlaces = 3;
            this.NumericLight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericLight.Location = new System.Drawing.Point(943, 205);
            this.NumericLight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericLight.Name = "NumericLight";
            this.NumericLight.Size = new System.Drawing.Size(53, 20);
            this.NumericLight.TabIndex = 15;
            this.NumericLight.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NumericLight.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericGrey
            // 
            this.NumericGrey.DecimalPlaces = 3;
            this.NumericGrey.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericGrey.Location = new System.Drawing.Point(943, 231);
            this.NumericGrey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericGrey.Name = "NumericGrey";
            this.NumericGrey.Size = new System.Drawing.Size(53, 20);
            this.NumericGrey.TabIndex = 16;
            this.NumericGrey.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.NumericGrey.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericLightGrey
            // 
            this.NumericLightGrey.DecimalPlaces = 3;
            this.NumericLightGrey.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericLightGrey.Location = new System.Drawing.Point(943, 257);
            this.NumericLightGrey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericLightGrey.Name = "NumericLightGrey";
            this.NumericLightGrey.Size = new System.Drawing.Size(53, 20);
            this.NumericLightGrey.TabIndex = 17;
            this.NumericLightGrey.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.NumericLightGrey.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericGreen
            // 
            this.NumericGreen.DecimalPlaces = 3;
            this.NumericGreen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericGreen.Location = new System.Drawing.Point(943, 283);
            this.NumericGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericGreen.Name = "NumericGreen";
            this.NumericGreen.Size = new System.Drawing.Size(53, 20);
            this.NumericGreen.TabIndex = 18;
            this.NumericGreen.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.NumericGreen.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericLightGreen
            // 
            this.NumericLightGreen.DecimalPlaces = 3;
            this.NumericLightGreen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericLightGreen.Location = new System.Drawing.Point(943, 309);
            this.NumericLightGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericLightGreen.Name = "NumericLightGreen";
            this.NumericLightGreen.Size = new System.Drawing.Size(53, 20);
            this.NumericLightGreen.TabIndex = 19;
            this.NumericLightGreen.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.NumericLightGreen.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericYellow
            // 
            this.NumericYellow.DecimalPlaces = 3;
            this.NumericYellow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericYellow.Location = new System.Drawing.Point(943, 335);
            this.NumericYellow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericYellow.Name = "NumericYellow";
            this.NumericYellow.Size = new System.Drawing.Size(53, 20);
            this.NumericYellow.TabIndex = 20;
            this.NumericYellow.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericBlue
            // 
            this.NumericBlue.DecimalPlaces = 3;
            this.NumericBlue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericBlue.Location = new System.Drawing.Point(943, 361);
            this.NumericBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericBlue.Name = "NumericBlue";
            this.NumericBlue.Size = new System.Drawing.Size(53, 20);
            this.NumericBlue.TabIndex = 21;
            this.NumericBlue.Value = new decimal(new int[] {
            35,
            0,
            0,
            -2147352576});
            this.NumericBlue.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // NumericDarkBlue
            // 
            this.NumericDarkBlue.DecimalPlaces = 3;
            this.NumericDarkBlue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericDarkBlue.Location = new System.Drawing.Point(943, 387);
            this.NumericDarkBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericDarkBlue.Name = "NumericDarkBlue";
            this.NumericDarkBlue.Size = new System.Drawing.Size(53, 20);
            this.NumericDarkBlue.TabIndex = 22;
            this.NumericDarkBlue.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NumericDarkBlue.ValueChanged += new System.EventHandler(this.NumericLight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "White:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Grey:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "LightGrey:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(849, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Green:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(849, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "LightGreen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Yellow:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(849, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Blue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "DarkBlue:";
            // 
            // NumericFrequence
            // 
            this.NumericFrequence.DecimalPlaces = 2;
            this.NumericFrequence.Location = new System.Drawing.Point(905, 158);
            this.NumericFrequence.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NumericFrequence.Name = "NumericFrequence";
            this.NumericFrequence.Size = new System.Drawing.Size(91, 20);
            this.NumericFrequence.TabIndex = 31;
            this.NumericFrequence.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericFrequence.ValueChanged += new System.EventHandler(this.NumericFrequence_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(842, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Frequence:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumericFrequence);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericDarkBlue);
            this.Controls.Add(this.NumericBlue);
            this.Controls.Add(this.NumericYellow);
            this.Controls.Add(this.NumericLightGreen);
            this.Controls.Add(this.NumericGreen);
            this.Controls.Add(this.NumericLightGrey);
            this.Controls.Add(this.NumericGrey);
            this.Controls.Add(this.NumericLight);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.NoiseType);
            this.Controls.Add(this.NumericJump);
            this.Controls.Add(this.JumpLabel);
            this.Controls.Add(this.NumericZoom);
            this.Controls.Add(this.ZoomLabel);
            this.Controls.Add(this.OctavesLabel);
            this.Controls.Add(this.NumericOctaves);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.NumericSeed);
            this.Controls.Add(this.y_cords);
            this.Controls.Add(this.x_cords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1025, 601);
            this.MinimumSize = new System.Drawing.Size(1023, 599);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BetterWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericOctaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericJump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLightGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLightGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDarkBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFrequence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label x_cords;
        private System.Windows.Forms.Label y_cords;
        private System.Windows.Forms.NumericUpDown NumericSeed;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.NumericUpDown NumericOctaves;
        private System.Windows.Forms.Label OctavesLabel;
        private System.Windows.Forms.Label ZoomLabel;
        private System.Windows.Forms.NumericUpDown NumericZoom;
        private System.Windows.Forms.Label JumpLabel;
        private System.Windows.Forms.NumericUpDown NumericJump;
        private System.Windows.Forms.ListBox NoiseType;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.NumericUpDown NumericLight;
        private System.Windows.Forms.NumericUpDown NumericGrey;
        private System.Windows.Forms.NumericUpDown NumericLightGrey;
        private System.Windows.Forms.NumericUpDown NumericGreen;
        private System.Windows.Forms.NumericUpDown NumericLightGreen;
        private System.Windows.Forms.NumericUpDown NumericYellow;
        private System.Windows.Forms.NumericUpDown NumericBlue;
        private System.Windows.Forms.NumericUpDown NumericDarkBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NumericFrequence;
        private System.Windows.Forms.Label label9;
    }
}

