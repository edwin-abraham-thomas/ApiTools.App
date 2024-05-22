namespace ApiTools.UI;

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
        callApi = new Button();
        responseWindow = new TextBox();
        responseLabel = new Label();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(49, 35);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(162, 47);
        formHeader.TabIndex = 0;
        formHeader.Text = "Api Tools";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(66, 107);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(60, 32);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "URL:";
        // 
        // apiText
        // 
        apiText.BorderStyle = BorderStyle.FixedSingle;
        apiText.Location = new Point(125, 104);
        apiText.Name = "apiText";
        apiText.Size = new Size(690, 39);
        apiText.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.CausesValidation = false;
        callApi.Location = new Point(838, 104);
        callApi.Name = "callApi";
        callApi.Size = new Size(95, 39);
        callApi.TabIndex = 3;
        callApi.Text = "Invoke";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_Click;
        // 
        // responseWindow
        // 
        responseWindow.BorderStyle = BorderStyle.FixedSingle;
        responseWindow.Location = new Point(66, 265);
        responseWindow.Multiline = true;
        responseWindow.Name = "responseWindow";
        responseWindow.ReadOnly = true;
        responseWindow.ScrollBars = ScrollBars.Both;
        responseWindow.Size = new Size(867, 309);
        responseWindow.TabIndex = 4;
        // 
        // responseLabel
        // 
        responseLabel.AutoSize = true;
        responseLabel.Location = new Point(66, 220);
        responseLabel.Name = "responseLabel";
        responseLabel.Size = new Size(115, 32);
        responseLabel.TabIndex = 6;
        responseLabel.Text = "Response";
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.Transparent;
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 592);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(959, 22);
        statusStrip.TabIndex = 7;
        statusStrip.Text = "statusStrip1";
        // 
        // systemStatus
        // 
        systemStatus.BackColor = Color.Transparent;
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(39, 17);
        systemStatus.Text = "Ready";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightGray;
        ClientSize = new Size(959, 614);
        Controls.Add(statusStrip);
        Controls.Add(responseLabel);
        Controls.Add(responseWindow);
        Controls.Add(callApi);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Margin = new Padding(6);
        Name = "Dashboard";
        Text = "Api Tools";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private Button callApi;
    private TextBox responseWindow;
    private Label responseLabel;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
}
