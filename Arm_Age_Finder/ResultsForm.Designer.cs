namespace Arm_Age_Finder
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.resultsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RestartButton = new System.Windows.Forms.Button();
            this.diagnosisResultsString = new System.Windows.Forms.Label();
            this.diagnosisResults = new System.Windows.Forms.Label();
            this.ageResult = new System.Windows.Forms.Label();
            this.headerResultsLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.resultsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsLayoutPanel
            // 
            this.resultsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.resultsLayoutPanel.ColumnCount = 2;
            this.resultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resultsLayoutPanel.Controls.Add(this.RestartButton, 0, 4);
            this.resultsLayoutPanel.Controls.Add(this.diagnosisResultsString, 0, 3);
            this.resultsLayoutPanel.Controls.Add(this.diagnosisResults, 0, 2);
            this.resultsLayoutPanel.Controls.Add(this.ageResult, 0, 1);
            this.resultsLayoutPanel.Controls.Add(this.headerResultsLabel, 0, 0);
            this.resultsLayoutPanel.Controls.Add(this.ExitButton, 1, 4);
            this.resultsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsLayoutPanel.Name = "resultsLayoutPanel";
            this.resultsLayoutPanel.Padding = new System.Windows.Forms.Padding(30);
            this.resultsLayoutPanel.RowCount = 5;
            this.resultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsLayoutPanel.Size = new System.Drawing.Size(1293, 733);
            this.resultsLayoutPanel.TabIndex = 0;
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestartButton.BackColor = System.Drawing.Color.Gold;
            this.RestartButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(288, 612);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(100, 45);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // diagnosisResultsString
            // 
            this.resultsLayoutPanel.SetColumnSpan(this.diagnosisResultsString, 2);
            this.diagnosisResultsString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnosisResultsString.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisResultsString.ForeColor = System.Drawing.Color.Gold;
            this.diagnosisResultsString.Location = new System.Drawing.Point(33, 432);
            this.diagnosisResultsString.Name = "diagnosisResultsString";
            this.diagnosisResultsString.Size = new System.Drawing.Size(1227, 134);
            this.diagnosisResultsString.TabIndex = 3;
            this.diagnosisResultsString.Text = "(Diagnosis Results)";
            this.diagnosisResultsString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diagnosisResults
            // 
            this.diagnosisResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diagnosisResults.AutoSize = true;
            this.resultsLayoutPanel.SetColumnSpan(this.diagnosisResults, 2);
            this.diagnosisResults.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisResults.Location = new System.Drawing.Point(484, 324);
            this.diagnosisResults.Name = "diagnosisResults";
            this.diagnosisResults.Size = new System.Drawing.Size(325, 81);
            this.diagnosisResults.TabIndex = 2;
            this.diagnosisResults.Text = "Diagnosis:";
            this.diagnosisResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageResult
            // 
            this.ageResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageResult.AutoSize = true;
            this.resultsLayoutPanel.SetColumnSpan(this.ageResult, 2);
            this.ageResult.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageResult.ForeColor = System.Drawing.Color.Gold;
            this.ageResult.Location = new System.Drawing.Point(466, 186);
            this.ageResult.Name = "ageResult";
            this.ageResult.Size = new System.Drawing.Size(361, 90);
            this.ageResult.TabIndex = 1;
            this.ageResult.Text = "(NUMBER)";
            this.ageResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerResultsLabel
            // 
            this.headerResultsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerResultsLabel.AutoSize = true;
            this.resultsLayoutPanel.SetColumnSpan(this.headerResultsLabel, 2);
            this.headerResultsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerResultsLabel.ForeColor = System.Drawing.Color.Black;
            this.headerResultsLabel.Location = new System.Drawing.Point(188, 56);
            this.headerResultsLabel.Name = "headerResultsLabel";
            this.headerResultsLabel.Size = new System.Drawing.Size(917, 81);
            this.headerResultsLabel.TabIndex = 0;
            this.headerResultsLabel.Text = "You arm is this many years old:";
            this.headerResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.BackColor = System.Drawing.Color.Gold;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(904, 612);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 45);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 733);
            this.Controls.Add(this.resultsLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arm Age Results";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.resultsLayoutPanel.ResumeLayout(false);
            this.resultsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel resultsLayoutPanel;
        private System.Windows.Forms.Label diagnosisResultsString;
        private System.Windows.Forms.Label diagnosisResults;
        private System.Windows.Forms.Label ageResult;
        private System.Windows.Forms.Label headerResultsLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
    }
}