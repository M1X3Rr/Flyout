namespace Flyout;

public partial class English : ContentPage
{
    public List<Subject> Subjects { get; set; }
	public English()
	{
		InitializeComponent();

        Subjects = new List<Subject>
        {
            new Subject { Name = "English", TeacherName = "Jurišova", Room = "103", 
                Description = "English for IT students, with specialized grammar and lingo for IT sphere." }
        };

        BindingContext = this;
    }
}