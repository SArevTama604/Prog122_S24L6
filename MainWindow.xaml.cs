using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace Prog122_S24L6
{
    public class Person
    {
        // Private string to store person's information
        private string firstName;
        private string lastName;
        private int age;

        // Constructor to begin person's information
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // Properties to allow access to person's information
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }

        // Override ToString() method for custom string representation of a Person object
        public override string ToString()
        {
            return $"{firstName} {lastName} - Age: {age}";
        }
    }

    public partial class MainWindow : Window
    {
        List<Person> people; // Declaration of a List to store Person objects

        public MainWindow()
        {
            InitializeComponent();

            people = new List<Person>(); // Initialization of the List in the constructor

            // Adding Person objects to the List
            people.Add(new Person("Bob", "Johnson", 25));
            people.Add(new Person("David", "Brown", 20));
            people.Add(new Person("Sarah", "Williams", 32));
            people.Add(new Person("Mark", "Anderson", 45));
            people.Add(new Person("Jennifer", "Lee", 28));

            // Inserting a Person object at specific positions
            people.Insert(3, new Person("Johnny", "Rocket", 70));

            // Removing Person objects from the List
            people.RemoveAt(0); // Remove by index
            people.Remove(people[1]); // Remove by reference
            people.Remove(people[2]); // Remove by reference

            // Displaying people in a RichTextBox
            DisplayPeopleInRichTextBox(people);
        }

        // Method to display List data in a RichTextBox
        public void DisplayPeopleInRichTextBox(List<Person> people)
        {
            runErrorMessages.Text = ""; // Clearing RichTextBox content
            foreach (Person person in people)
            {
                runErrorMessages.Text += person + "\n"; // Displaying each person's information in a new line
            }
        }
    }
}