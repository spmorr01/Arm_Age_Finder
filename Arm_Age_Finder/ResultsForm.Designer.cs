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
            this.diagnosisResultsString = new System.Windows.Forms.Label();
            this.diagnosisResults = new System.Windows.Forms.Label();
            this.ageResult = new System.Windows.Forms.Label();
            this.headerResultsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.resultsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsLayoutPanel
            // 
            this.resultsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.resultsLayoutPanel.ColumnCount = 1;
            this.resultsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultsLayoutPanel.Controls.Add(this.diagnosisResultsString, 0, 3);
            this.resultsLayoutPanel.Controls.Add(this.diagnosisResults, 0, 2);
            this.resultsLayoutPanel.Controls.Add(this.ageResult, 0, 1);
            this.resultsLayoutPanel.Controls.Add(this.headerResultsLabel, 0, 0);
            this.resultsLayoutPanel.Controls.Add(this.CloseButton, 0, 4);
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
            this.resultsLayoutPanel.Size = new System.Drawing.Size(1293, 898);
            this.resultsLayoutPanel.TabIndex = 0;
            // 
            // diagnosisResultsString
            // 
            this.diagnosisResultsString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diagnosisResultsString.AutoSize = true;
            this.diagnosisResultsString.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisResultsString.Location = new System.Drawing.Point(314, 578);
            this.diagnosisResultsString.Name = "diagnosisResultsString";
            this.diagnosisResultsString.Size = new System.Drawing.Size(665, 72);
            this.diagnosisResultsString.TabIndex = 3;
            this.diagnosisResultsString.Text = "(Diagnosis Results)";
            this.diagnosisResultsString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diagnosisResults
            // 
            this.diagnosisResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diagnosisResults.AutoSize = true;
            this.diagnosisResults.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisResults.Location = new System.Drawing.Point(457, 411);
            this.diagnosisResults.Name = "diagnosisResults";
            this.diagnosisResults.Size = new System.Drawing.Size(379, 72);
            this.diagnosisResults.TabIndex = 2;
            this.diagnosisResults.Text = "Diagnosis:";
            this.diagnosisResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageResult
            // 
            this.ageResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageResult.AutoSize = true;
            this.ageResult.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageResult.Location = new System.Drawing.Point(461, 244);
            this.ageResult.Name = "ageResult";
            this.ageResult.Size = new System.Drawing.Size(370, 72);
            this.ageResult.TabIndex = 1;
            this.ageResult.Text = "(NUMBER)";
            this.ageResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerResultsLabel
            // 
            this.headerResultsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerResultsLabel.AutoSize = true;
            this.headerResultsLabel.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerResultsLabel.Location = new System.Drawing.Point(84, 77);
            this.headerResultsLabel.Name = "headerResultsLabel";
            this.headerResultsLabel.Size = new System.Drawing.Size(1125, 72);
            this.headerResultsLabel.TabIndex = 0;
            this.headerResultsLabel.Text = "You arm is this many years old:";
            this.headerResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.Location = new System.Drawing.Point(596, 760);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 45);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 898);
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
        private System.Windows.Forms.Button CloseButton;
    }
}