namespace Vlasov_tomogram_visualizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenButton = new System.Windows.Forms.Button();
            this.layerTrackBar = new System.Windows.Forms.TrackBar();
            this.switchButton = new System.Windows.Forms.Button();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.minTrackBar = new System.Windows.Forms.TrackBar();
            this.glControl1 = new OpenTK.GLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.layerLabel = new System.Windows.Forms.Label();
            this.layerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.layerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(1, 1);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 46);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // layerTrackBar
            // 
            this.layerTrackBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.layerTrackBar.Location = new System.Drawing.Point(77, 2);
            this.layerTrackBar.Name = "layerTrackBar";
            this.layerTrackBar.Size = new System.Drawing.Size(590, 45);
            this.layerTrackBar.TabIndex = 2;
            this.layerTrackBar.Scroll += new System.EventHandler(this.layerTrackBar_Scroll);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(697, 2);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(101, 45);
            this.switchButton.TabIndex = 3;
            this.switchButton.Text = "  Mode:\r\nQuad Strip";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.AutoSize = false;
            this.widthTrackBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.widthTrackBar.LargeChange = 50;
            this.widthTrackBar.Location = new System.Drawing.Point(748, 70);
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widthTrackBar.Size = new System.Drawing.Size(50, 364);
            this.widthTrackBar.TabIndex = 4;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // minTrackBar
            // 
            this.minTrackBar.AutoSize = false;
            this.minTrackBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.minTrackBar.LargeChange = 50;
            this.minTrackBar.Location = new System.Drawing.Point(697, 70);
            this.minTrackBar.Name = "minTrackBar";
            this.minTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.minTrackBar.Size = new System.Drawing.Size(50, 364);
            this.minTrackBar.TabIndex = 5;
            this.minTrackBar.Scroll += new System.EventHandler(this.minTrackBar_Scroll);
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(4, 50);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(692, 397);
            this.glControl1.TabIndex = 6;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(697, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minimum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(748, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(387, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Layers";
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.minTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTextBox.Location = new System.Drawing.Point(697, 50);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(50, 20);
            this.minTextBox.TabIndex = 13;
            this.minTextBox.Text = "0";
            this.minTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthTextBox.Location = new System.Drawing.Point(748, 50);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(50, 20);
            this.widthTextBox.TabIndex = 13;
            this.widthTextBox.Text = "0";
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // layerLabel
            // 
            this.layerLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.layerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.layerLabel.Location = new System.Drawing.Point(667, 2);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(29, 45);
            this.layerLabel.TabIndex = 11;
            this.layerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layerTextBox
            // 
            this.layerTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.layerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layerTextBox.Location = new System.Drawing.Point(668, 16);
            this.layerTextBox.Name = "layerTextBox";
            this.layerTextBox.Size = new System.Drawing.Size(27, 13);
            this.layerTextBox.TabIndex = 13;
            this.layerTextBox.Text = "0";
            this.layerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.layerTextBox.TextChanged += new System.EventHandler(this.layerTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.layerTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.layerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.minTrackBar);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.layerTrackBar);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TrackBar layerTrackBar;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.TrackBar minTrackBar;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.TextBox layerTextBox;
    }
}

