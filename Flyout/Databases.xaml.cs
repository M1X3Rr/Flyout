namespace Flyout;

public partial class Databases : ContentPage
{
	public List<Subject> Subjects { get; set; }

	public Databases()
	{
		InitializeComponent();

		Subjects = new List<Subject>
		{
            new Subject { Name = "Introduction to Databases", TeacherName = "Freso", Room = "303", 
				Description = "Learn the fundamentals of databases, including database design, management, and querying using SQL." }
        };

        BindingContext = this;
    }
}