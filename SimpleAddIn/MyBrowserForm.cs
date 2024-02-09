using System.Windows.Forms;

namespace SimpleAddIn
{
    public partial class MyBrowserForm : Form
    {
        Inventor.Application _app;

        public MyBrowserForm(Inventor.Application app)
        {
            _app = app;

            // This seems to be needed
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            System.Environment.SetEnvironmentVariable("WEBVIEW2_USER_DATA_FOLDER", path);

            InitializeComponent();

            myWebView2.WebMessageReceived += MyWebView2_WebMessageReceived;
            myWebView2.CoreWebView2InitializationCompleted += MyWebView2_CoreWebView2InitializationCompleted;
            myWebView2.EnsureCoreWebView2Async();
        }

        private void MyWebView2_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            var htmlContent = @"
<html>
<body>
<script>
function onClick() {
  window.chrome.webview.postMessage('Hello from web page');
}
</script>
<button onclick=""onClick()"">Hello</button>
</body>
</html>
            ";
            myWebView2.NavigateToString(htmlContent);
        }

        private void MyWebView2_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            var text = e.TryGetWebMessageAsString();
            var docName = _app.ActiveDocument.DisplayName;
            MessageBox.Show(text + " for " + docName);
        }
    }
}
