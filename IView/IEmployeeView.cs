public interface IEmployeeView
{
    void BindEmployees(IEnumerable<Employee> employees);
    void BindDepartments(IEnumerable<string> departments);
    event EventHandler<DepartmentSelectedEventArgs> DepartmentSelected;
}

public class DepartmentSelectedEventArgs : EventArgs
{
    public string Department { get; private set; }
    public DepartmentSelectedEventArgs(string department)
    {
        this.Department = department;
    }
}