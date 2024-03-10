namespace Flyout;

public partial class GUI : ContentPage
{
    public List<Subject> Subjects { get; set; }

    public GUI()
	{
		InitializeComponent();

        Subjects = new List<Subject>
        {
            new Subject { Name = "GUI", TeacherName = "Kucera", Room = "103",
                Description = "Delve into the design and development of graphical user interfaces, creating intuitive and visually appealing software interfaces." }
        };

        BindingContext = this;
    }
}