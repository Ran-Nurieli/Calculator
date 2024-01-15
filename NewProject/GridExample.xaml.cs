namespace NewProject;

public partial class GridExample : ContentPage
{
	public GridExample()
	{
		InitializeComponent();
	}

    private void Print(object sender, EventArgs e)
    {
        lbl_text.Text += sender.GetType();
    }
    private void NumPressed(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        lbl_text.Text +=btn.Text;
    }
    
}