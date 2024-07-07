using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp_Ado.Net_classTask1.Models;

public class Person : INotifyPropertyChanged
{
    private string personName;
    private string surname;
    private int age;
    private string username;
    private string password;
    private int iD;

    public int ID { get => iD; set { iD = value; OnPropertyChanged(); } }

    public string PersonName { get => personName; set { personName = value; OnPropertyChanged(); } }

    public string Surname { get => surname; set { surname = value; OnPropertyChanged(); } }

    public int Age { get => age; set { age = value; OnPropertyChanged(); } }

    public string Username { get => username; set { username = value; OnPropertyChanged(); } }
    public string Password { get => password; set { password = value; OnPropertyChanged(); } }

    public Person(int Id,string personName, string surname, int age, string username, string password)
    {
        this.ID = Id;
        PersonName = personName;
        Surname = surname;
        Age = age;
        Username = username;
        Password = password;
    }



    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
