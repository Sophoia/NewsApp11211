using NewsApp.Models;

namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
		ImgNevs.Source = article.Image;
		LBltitle.Text = article.Title;
		LblContent.Text = article.Content;

    }
}