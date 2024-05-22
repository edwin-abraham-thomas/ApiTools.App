using ApiTools.Library.Services.Api;

namespace ApiTools.UI;

public partial class Dashboard : Form
{
    private readonly IApiService _apiService = new ApiService();
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling api";
        responseWindow.Text = "";

        var url = apiText.Text;

        if (!_apiService.IsValidUrl(url))
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {
            responseWindow.Text = await _apiService.CallApiAsync(url);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            responseWindow.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
