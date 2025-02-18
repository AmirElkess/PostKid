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
            apiText = new TextBox();
            resultsText = new TextBox();
            callApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            httpVerbSelection = new ComboBox();
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
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(283, 122);
            apiText.Name = "apiText";
            apiText.Size = new Size(1309, 37);
            apiText.TabIndex = 2;
            apiText.TextChanged += textBox1_TextChanged;
            // 
            // resultsText
            // 
            resultsText.Location = new Point(30, 231);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(1700, 645);
            resultsText.TabIndex = 3;
            resultsText.TextChanged += resultsText_TextChanged;
            // 
            // callApi
            // 
            callApi.Location = new Point(1598, 122);
            callApi.Name = "callApi";
            callApi.Size = new Size(132, 39);
            callApi.TabIndex = 4;
            callApi.Text = "Request";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += button1_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 897);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1754, 37);
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
            // httpVerbSelection
            // 
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
            httpVerbSelection.Location = new Point(86, 121);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(191, 38);
            httpVerbSelection.TabIndex = 7;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1754, 934);
            Controls.Add(httpVerbSelection);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(callApi);
            Controls.Add(resultsText);
            Controls.Add(apiText);
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
        private TextBox apiText;
        private TextBox resultsText;
        private Button callApi;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelection;
    }
}
