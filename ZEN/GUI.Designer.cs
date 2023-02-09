namespace ZEN
{
    partial class GUI
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
            this.title = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Sep = new Guna.UI2.WinForms.Guna2Separator();
            this.slider1 = new ZEN.Slider();
            this.label2 = new System.Windows.Forms.Label();
            this.ThemeToggle = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Enabled = true;
            this.title.Interval = 1000;
            this.title.Tick += new System.EventHandler(this.title_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMPLE EXAMPLE OF MC CLICKING. USED TO DISPLAY THEMING EXAMPLE \r\n";
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSize = true;
            this.Checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Checkbox.CheckedState.BorderRadius = 1;
            this.Checkbox.CheckedState.BorderThickness = 1;
            this.Checkbox.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Checkbox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Checkbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Checkbox.Location = new System.Drawing.Point(36, 43);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Size = new System.Drawing.Size(88, 19);
            this.Checkbox.TabIndex = 2;
            this.Checkbox.Text = "CHECK BOX";
            this.Checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Checkbox.UncheckedState.BorderRadius = 1;
            this.Checkbox.UncheckedState.BorderThickness = 1;
            this.Checkbox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // Sep
            // 
            this.Sep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Sep.Location = new System.Drawing.Point(33, 27);
            this.Sep.Name = "Sep";
            this.Sep.Size = new System.Drawing.Size(412, 10);
            this.Sep.TabIndex = 3;
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.Transparent;
            this.slider1.DecimalPlaces = 1;
            this.slider1.ForeColor = System.Drawing.Color.Transparent;
            this.slider1.Location = new System.Drawing.Point(36, 88);
            this.slider1.Maximum = 100D;
            this.slider1.Minimum = 0D;
            this.slider1.Name = "slider1";
            this.slider1.Round = true;
            this.slider1.Size = new System.Drawing.Size(409, 19);
            this.slider1.SliderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.slider1.SliderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.slider1.TabIndex = 4;
            this.slider1.TextColor = System.Drawing.Color.White;
            this.slider1.Value = 50D;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "CUSTOM SLIDER -> CAN BE USED FOR FOV ECT...";
            // 
            // ThemeToggle
            // 
            this.ThemeToggle.AnimatedGIF = true;
            this.ThemeToggle.BorderRadius = 6;
            this.ThemeToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ThemeToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ThemeToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ThemeToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ThemeToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.ThemeToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThemeToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ThemeToggle.Location = new System.Drawing.Point(36, 118);
            this.ThemeToggle.Name = "ThemeToggle";
            this.ThemeToggle.Size = new System.Drawing.Size(221, 29);
            this.ThemeToggle.TabIndex = 6;
            this.ThemeToggle.Text = "TOGGLE THEME -> CURRENT: DARK";
            this.ThemeToggle.Click += new System.EventHandler(this.ThemeToggle_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(480, 307);
            this.Controls.Add(this.ThemeToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.Sep);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer title;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox Checkbox;
        private Guna.UI2.WinForms.Guna2Separator Sep;
        private Slider slider1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ThemeToggle;
    }
}