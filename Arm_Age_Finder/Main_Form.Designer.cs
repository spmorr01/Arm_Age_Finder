namespace Arm_Age_Finder
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.pitcherCheckBox = new System.Windows.Forms.CheckBox();
            this.positionPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.dualPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainFormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainFormTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pitcherCheckBox
            // 
            this.pitcherCheckBox.AccessibleName = "Pitcher_CheckBox";
            this.pitcherCheckBox.AutoSize = true;
            this.pitcherCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitcherCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.pitcherCheckBox.Location = new System.Drawing.Point(3, 163);
            this.pitcherCheckBox.Name = "pitcherCheckBox";
            this.pitcherCheckBox.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pitcherCheckBox.Size = new System.Drawing.Size(233, 72);
            this.pitcherCheckBox.TabIndex = 0;
            this.pitcherCheckBox.Text = "Pitcher";
            this.pitcherCheckBox.UseVisualStyleBackColor = true;
            this.pitcherCheckBox.CheckedChanged += new System.EventHandler(this.Pitcher_CheckBox_CheckedChanged);
            // 
            // positionPlayerCheckBox
            // 
            this.positionPlayerCheckBox.AccessibleName = "PP_CheckBox";
            this.positionPlayerCheckBox.AutoSize = true;
            this.positionPlayerCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionPlayerCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.positionPlayerCheckBox.Location = new System.Drawing.Point(3, 323);
            this.positionPlayerCheckBox.Name = "positionPlayerCheckBox";
            this.positionPlayerCheckBox.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.positionPlayerCheckBox.Size = new System.Drawing.Size(405, 72);
            this.positionPlayerCheckBox.TabIndex = 2;
            this.positionPlayerCheckBox.Text = "Position Player";
            this.positionPlayerCheckBox.UseVisualStyleBackColor = true;
            this.positionPlayerCheckBox.CheckedChanged += new System.EventHandler(this.PP_CheckBox_CheckedChanged);
            // 
            // dualPlayerCheckBox
            // 
            this.dualPlayerCheckBox.AccessibleName = "PP_CheckBox";
            this.dualPlayerCheckBox.AutoSize = true;
            this.dualPlayerCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dualPlayerCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.dualPlayerCheckBox.Location = new System.Drawing.Point(3, 483);
            this.dualPlayerCheckBox.Name = "dualPlayerCheckBox";
            this.dualPlayerCheckBox.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dualPlayerCheckBox.Size = new System.Drawing.Size(332, 72);
            this.dualPlayerCheckBox.TabIndex = 3;
            this.dualPlayerCheckBox.Text = "Dual Player";
            this.dualPlayerCheckBox.UseVisualStyleBackColor = true;
            this.dualPlayerCheckBox.CheckedChanged += new System.EventHandler(this.Dual_CheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainFormTableLayout
            // 
            this.mainFormTableLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainFormTableLayout.ColumnCount = 1;
            this.mainFormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainFormTableLayout.Controls.Add(this.pitcherCheckBox, 0, 1);
            this.mainFormTableLayout.Controls.Add(this.positionPlayerCheckBox, 0, 2);
            this.mainFormTableLayout.Controls.Add(this.dualPlayerCheckBox, 0, 3);
            this.mainFormTableLayout.Controls.Add(this.questionLabel, 0, 0);
            this.mainFormTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainFormTableLayout.Name = "mainFormTableLayout";
            this.mainFormTableLayout.RowCount = 4;
            this.mainFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainFormTableLayout.Size = new System.Drawing.Size(1320, 640);
            this.mainFormTableLayout.TabIndex = 5;
            // 
            // questionLabel
            // 
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Gold;
            this.questionLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.questionLabel.Location = new System.Drawing.Point(3, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.questionLabel.Size = new System.Drawing.Size(1314, 160);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "What position do you play?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 640);
            this.Controls.Add(this.mainFormTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arm Age Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainFormTableLayout.ResumeLayout(false);
            this.mainFormTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox pitcherCheckBox;
        private System.Windows.Forms.CheckBox positionPlayerCheckBox;
        private System.Windows.Forms.CheckBox dualPlayerCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel mainFormTableLayout;
        private System.Windows.Forms.Label questionLabel;
    }
}

