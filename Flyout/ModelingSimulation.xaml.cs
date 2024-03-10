namespace Flyout;

public partial class ModelingSimulation : ContentPage
{
    public List<Subject> Subjects { get; set; }
    public ModelingSimulation()
	{
		InitializeComponent();

        Subjects = new List<Subject>
        {
            new Subject { Name = "Modeling and Simulation", TeacherName = "Stefanocic", Room = "103", 
                Description = "Dive into the realm of modeling and simulation, understanding how to simulate and analyze real-world processes for various applications." },
        };

        BindingContext = this;
    }
}