namespace PostKidUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            textBox1 = new TextBox();
            resultsText = new TextBox();
            callApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(21, 29);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(201, 70);
            formHeader.TabIndex = 0;
            formHeader.Text = "PostKid";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(30, 121);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(50, 30);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            apiLabel.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(86, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(716, 37);
            textBox1.TabIndex = 2;
            // 
            // resultsText
            // 
            resultsText.Location = new Point(30, 231);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(890, 267);
            resultsText.TabIndex = 3;
            resultsText.TextChanged += resultsText_TextChanged;
            // 
            // callApi
            // 
            callApi.Location = new Point(808, 118);
            callApi.Name = "callApi";
            callApi.Size = new Size(112, 37);
            callApi.TabIndex = 4;
            callApi.Text = "Request";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += button1_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 527);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(950, 37);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(72, 30);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(30, 182);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(84, 30);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            resultsLabel.Click += label1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(950, 564);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(callApi);
            Controls.Add(resultsText);
            Controls.Add(textBox1);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "PostKid: A clone of Postman";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox textBox1;
        private TextBox resultsText;
        private Button callApi;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
