namespace Michichan;

partial class Michichan
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(88, 50);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(464, 98);
        label1.TabIndex = 0;
        label1.Text = "countdown";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(336, 45);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(166, 66);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Yellow;
        button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(173, 151);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(235, 64);
        button1.TabIndex = 2;
        button1.Text = "HOLD!!!!!!";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.OrangeRed;
        button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(464, 151);
        button2.Name = "button2";
        button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
        button2.Size = new System.Drawing.Size(235, 64);
        button2.TabIndex = 3;
        button2.Text = "ABORT";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // Michichan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1902, 1033);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Michichan";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}