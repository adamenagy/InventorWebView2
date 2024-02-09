
namespace SimpleAddIn
{
    partial class MyBrowserForm
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
            this.myWebView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.myWebView2)).BeginInit();
            this.SuspendLayout();
            // 
            // myWebView2
            // 
            this.myWebView2.AllowExternalDrop = true;
            this.myWebView2.CreationProperties = null;
            this.myWebView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.myWebView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myWebView2.Location = new System.Drawing.Point(0, 0);
            this.myWebView2.Name = "myWebView2";
            this.myWebView2.Size = new System.Drawing.Size(800, 450);
            this.myWebView2.TabIndex = 0;
            this.myWebView2.ZoomFactor = 1D;
            // 
            // MyBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myWebView2);
            this.Name = "MyBrowserForm";
            this.Text = "MyBrowserForm";
            ((System.ComponentModel.ISupportInitialize)(this.myWebView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 myWebView2;
    }
}